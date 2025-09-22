using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace xhmpegApp
{
    public sealed class FfprobeService
    {
        private readonly string _ffprobePath;
        private static readonly JsonSerializerOptions _jsonOpts = new() { PropertyNameCaseInsensitive = true };
        public FfprobeService(string ffprobePath) => _ffprobePath = ffprobePath; // stores absolute path to ffprobe.exe

        public async Task<ProbeInfo> GetInfoAsync(string inputPath)
        {
            // guards
            if (!File.Exists(inputPath)) throw new FileNotFoundException("Input not found at path specified", inputPath);
            if (!File.Exists(_ffprobePath)) throw new FileNotFoundException("ffprobe not found at path specified", _ffprobePath);

            // ffprobe command, quiet, json output
            var args = $"-v quiet -print_format json -show_format -show_streams \"{inputPath}\"";
            var json = await RunAsync(_ffprobePath, args); // sends to helper to get stdout
            var root = JsonSerializer.Deserialize<ProbeResult>(json, _jsonOpts) ?? new ProbeResult(); // deserializes json
            var info = new ProbeInfo();

            TimeSpan duration = TimeSpan.Zero;
            if (double.TryParse(root.format?.duration, NumberStyles.Any, CultureInfo.InvariantCulture, out var d) && d > 0)
                duration = TimeSpan.FromSeconds(d);

            var video = root.streams?.FirstOrDefault(s => s.codec_type == "video");
            var audio = root.streams?.FirstOrDefault(s => s.codec_type == "audio");

            return new ProbeInfo // this is the object with the info for video/audio
            {
                Duration = duration,
                Width = video?.width,
                Height = video?.height,
                Fps = ParseRational(video?.avg_frame_rate) ?? ParseRational(video?.r_frame_rate), // prefer avg, fallback to r
                VideoBitrateKbps = ToKbps(video?.bitrate), // stream br may be missing for vbr, also captures format br as fallback
                AudioBitrateKbps = ToKbps(audio?.bitrate),
                ContainerBitrateKbps = ToKbps(root.format?.bitrate),
                RotationDeg = ParseRotation(video),
                AudioChannels = audio?.channels,
                AudioSampleRate = ParseInt(audio?.sample_rate)
            };
        }

        private static async Task<string> RunAsync(string exe, string args)
        {
            var psi = new ProcessStartInfo
            {
                FileName = exe,
                Arguments = args,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            using var p = Process.Start(psi)!;
            var stdOut = p.StandardOutput.ReadToEndAsync();
            var _ = p.StandardError.ReadToEndAsync(); // drain, since process may block if buffer fills
            await p.WaitForExitAsync(); // so ui thread stays responsive
            return await stdOut;
        }

        private static int? ToKbps(string? bitsPerSec) // converts bits per second to kbps, return null if missing
        => (long.TryParse(bitsPerSec, out var bps) && bps > 0) ? (int)(bps / 1000) : null;

        private static double? ParseRational(string? rat) // fps comes out as a fraction, so we must have it as a single number instead
        {
            if (string.IsNullOrWhiteSpace(rat)) return null; // guard
            if (rat.Contains('/'))
            {
                var parts = rat.Split('/');
                if (double.TryParse(parts[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var n) &&
                    double.TryParse(parts[1], NumberStyles.Any, CultureInfo.InvariantCulture, out var d) && d != 0)
                    return n / d;
            }
            // if already plain num, returns the same number
            if (double.TryParse(rat, NumberStyles.Any, CultureInfo.InvariantCulture, out var f)) return f;
            return null; 
        }

        private static int? ParseRotation(ProbeStream? v) // rot may be in float type, rounds that to int
        {
            if (v == null) return null;
            var side = v.sidedata_list?.FirstOrDefault(s => s.rotation.HasValue)?.rotation;
            if (side.HasValue) return (int)Math.Round(side.Value);

            if (v.tags != null && v.tags.TryGetValue("rotate", out var s) && int.TryParse(s, out var deg))
                return deg;

            return null;
        }

        private static int? ParseInt(string? s) // simple util for parsing ints from strings
        => int.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var i) ? i : null;
    }
}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xhmpegApp
{
    public sealed class ProbeInfo
    {
        public TimeSpan Duration { get; init; } = TimeSpan.Zero;
        public int? Width { get; init; }
        public int? Height { get; init; }
        public double? Fps { get; init; }
        public int? VideoBitrateKbps { get; init; }
        public int? AudioBitrateKbps { get; init; }
        public int? ContainerBitrateKbps { get; init; }
        public int? RotationDeg { get; init; }
        public int? AudioChannels { get; init; }
        public int? AudioSampleRate { get; init; }
    }
}

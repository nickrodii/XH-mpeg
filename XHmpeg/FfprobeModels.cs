using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xhmpegApp
{
    public sealed class ProbeResult
    {
        public ProbeFormat? format { get; set; }
        public List<ProbeStream>? streams { get; set; }
    }

    public sealed class ProbeFormat
    {
        public string? duration { get; set; }   // seconds as string
        public string? bitrate { get; set; }   // bits per second as string
    }

    public sealed class ProbeStream
    {
        public string? codec_type { get; set; } // video or audio
        public int? width { get; set; }
        public int? height { get; set; }
        public string? r_frame_rate { get; set; }
        public string? avg_frame_rate { get; set; }
        public string? bitrate { get; set; }
        public string? sample_rate { get; set; } 
        public int? channels { get; set; }
        public Dictionary<string, string>? tags { get; set; }
        public List<SideData>? sidedata_list { get; set; }
    }

    public sealed class SideData
    {
        public string? sidedata_type { get; set; }
        public double? rotation { get; set; }
    }
}

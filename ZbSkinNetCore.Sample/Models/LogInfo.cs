using System;

namespace ZbSkinNetCore.Sample.Models
{
    internal sealed class LogInfo
    {
        public LogType LogType { get; set; }
        public DateTime AddTime { get; set; }
        public string Text { get; set; }
    }
}

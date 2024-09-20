using System;

namespace ZbSkinNetCore.Sample.Models
{
    public sealed class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        public string GenderString => Gender ? @"男" : @"女";
    }
}

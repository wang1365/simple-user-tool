using System;
using System.Collections.Generic;
using ZbSkin.Sample.Models;

namespace ZbSkin.Sample.MockData
{
    internal sealed class DataManager
    {
        public Dictionary<int, UserInfo> UserInfoDict { get; }
        public List<LogInfo> LogInfoList { get; }

        public void InitData()
        {
            UserInfoDict.Clear();

            var random = new Random(DateTime.Now.Millisecond);
            for (var i = 0; i < 20; i++)
            {
                var id = i + 1;
                UserInfoDict.Add(id, new UserInfo()
                {
                    Id = id,
                    Name = $@"用户{id}",
                    Age = random.Next(20, 50),
                    Gender = random.Next(100) % 2 == 0,
                    UpdateTime = DateTime.Now.AddHours(random.Next(1000))
                });
            }

            var count = random.Next(200, 300);
            for (var i = 0; i < count; i++)
            {
                LogInfoList.Add(new LogInfo()
                {
                    LogType = GetRandomLogType(random),
                    AddTime = DateTime.Now.AddMinutes(-random.Next(1000)),
                    Text = $@"This is system log {i + 1}."
                });
            }
        }

        private static LogType GetRandomLogType(Random random)
        {
            var number = random.Next(100);
            if (number >= 99)
            {
                //1%
                return LogType.Unknown;
            }

            if (number >= 95)
            {
                //4%
                return LogType.Error;
            }

            if (number >= 80)
            {
                //15%
                return LogType.Warning;
            }

            if (number >= 60)
            {
                //20%
                return LogType.Information;
            }

            //60%
            return LogType.Success;
        }

        #region Singleton Pattern

        private static DataManager _instance;
        private static readonly object InstanceLockHelper = new object();

        private DataManager()
        {
            UserInfoDict = new Dictionary<int, UserInfo>();
            LogInfoList = new List<LogInfo>();
        }

        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (InstanceLockHelper)
                    {
                        _instance = _instance ?? new DataManager();
                    }
                }

                return _instance;
            }
        }

        #endregion
    }
}

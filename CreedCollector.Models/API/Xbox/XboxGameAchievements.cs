﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.Models.API.Xbox
{
    // This class is used for Xbox 360 Achievements
    public class XboxOneAchievements
    {
        public int id { get; set; }
        public int titleId { get; set; }
        public string name { get; set; }
        public int sequence { get; set; }
        public int flags { get; set; }
        public bool unlockedOnline { get; set; }
        public bool unlocked { get; set; }
        public bool isSecret { get; set; }
        public int platform { get; set; }
        public int gamerscore { get; set; }
        public int imageId { get; set; }
        public string description { get; set; }
        public string lockedDescription { get; set; }
        public int type { get; set; }
        public bool isRevoked { get; set; }
        public string timeUnlocked { get; set; }
        public string imageUnlocked { get; set; }
    }
}

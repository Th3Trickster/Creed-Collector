using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreedCollector.Models.API.Xbox
{
    public class XboxOneAchievement
    {
        public int id { get; set; }
        public string serviceConfigId { get; set; }
        public string name { get; set; }
        public List<TitleAssociation> titleAssociations { get; set; }
        public string progressState { get; set; }
        public Progression progression { get; set; }
        public List<MediaAsset> mediaAssets { get; set; }
        public List<string> platforms { get; set; }
        public bool isSecret { get; set; }
        public string description { get; set; }
        public string lockedDescription { get; set; }
        public string productId { get; set; }
        public string achievementType { get; set; }
        public string participationType { get; set; }
        public object timeWindow { get; set; }
        public List<Reward> rewards { get; set; }
        public string estimatedTime { get; set; }
        public object deeplink { get; set; }
        public bool isRevoked { get; set; }
        public Rarity rarity { get; set; }
        public DateTime UnlockedXboxOneAchievements
        {
            get
            {
                if (progression == null)
                {
                    return DateTime.Today;
                }
                else
                {
                    return progression.timeUnlocked;
                }
            }
        }
    }
}

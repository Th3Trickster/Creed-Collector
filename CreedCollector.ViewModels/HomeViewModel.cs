using CreedCollector.Helpers;
using CreedCollector.Models.API.Xbox;
using CreedCollector.ViewModels.LoggedInProperties;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreedCollector.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<XboxOneAchievement> xboxOneGameAchievements;
        private ObservableCollection<string> unlockedXboxOneAchievements;
        private int totalXbox360Achievements;
        private int unlockedXbox360Achievements;

        #region Properties
        public int TotalXbox360Achievements
        {
            get { return totalXbox360Achievements; }
            set
            {
                totalXbox360Achievements = value;
                RaisePropertyChanged("TotalXbox360Achievements");
            }
        }

        public ObservableCollection<string> UnlockedXboxOneAchievements
        {
            get { return unlockedXboxOneAchievements; }
            set
            {
                unlockedXboxOneAchievements = value;
                RaisePropertyChanged("UnlockedXboxOneAchievements");
            }
        }

        public int UnlockedXbox360Achievements
        {
            get { return unlockedXbox360Achievements; }
            set
            {
                unlockedXbox360Achievements = value;
                RaisePropertyChanged("UnlockedXbox360Achievements");
            }
        }

        public ObservableCollection<XboxOneAchievement> XboxGameAchievements
        {
            get { return xboxOneGameAchievements; }
            set
            {
                xboxOneGameAchievements = value;
                RaisePropertyChanged("XboxGameAchievements");
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel()
        {
            GetUserXboxOneAchievements();
            XboxGameAchievements = new ObservableCollection<XboxOneAchievement>();
            UnlockedXboxOneAchievements = new ObservableCollection<string>();
        }

        private async void GetUserXboxOneAchievements()
        {
            if (UserInformation.Xuid != null)
            {
                var achievements = await XApiHelper.GetXboxOneAchievementsOfUser(UserInformation.Xuid);

                foreach (var achievement in achievements)
                {
                    XboxGameAchievements.Add(achievement);
                }
            }
            GetUnlockedAchievementsOfUser();
        }

        /* This method will get the unlocked time for each achievement. If the achievement has not been unlocked
         * it will use a static time which is defined in the Xbox api. The method will compare if the time does not match
         * and if it doesn't that means the achievement has been unlocked. Then the achievement will be added to the 
         * unlocked achievements list and used in overall count of the unlocked achievements. */
        private void GetUnlockedAchievementsOfUser()
        {
            foreach (var value in xboxOneGameAchievements)
            {
                string lockedAchievementTime = value.UnlockedXboxOneAchievements.ToString();
                if (lockedAchievementTime != "1/1/0001 8:00:00 AM")
                {
                    if (lockedAchievementTime == null)
                    {
                        Debug.Print("NULL");
                    }
                    else
                    {
                        unlockedXboxOneAchievements.Add(lockedAchievementTime);
                    }
                }
            }
        }

        /* Used for MVVM purposes */
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

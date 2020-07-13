using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreedCollector.UserControls
{
    /// <summary>
    /// Interaction logic for Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public string CardImageWidth
        {
            get { return (string)GetValue(CardImageWidthProperty); }
            set { SetValue(CardImageWidthProperty, value); }
        }

        public string CardUnlockedAchievement
        {
            get { return (string)GetValue(CardUnlockedAchievementProperty); }
            set { SetValue(CardUnlockedAchievementProperty, value); }
        }

        public string CardTotalAchievements
        {
            get { return (string)GetValue(CardTotalAchievementsProperty); }
            set { SetValue(CardTotalAchievementsProperty, value); }
        }

        public string CardImageHeight
        {
            get { return (string)GetValue(CardImageHeightProperty); }
            set { SetValue(CardImageHeightProperty, value); }
        }
        
        public string CardImage
        {
            get { return (string)GetValue(CardImageProperty); }
            set { SetValue(CardImageProperty, value); }
        }

        public string CardHeader
        {
            get { return (string)GetValue(CardHeaderProperty); }
            set { SetValue(CardHeaderProperty, value); }
        }

        public string CardLeadingTextIcon
        {
            get { return (string)GetValue(CardLeadingTextIconProperty); }
            set { SetValue(CardLeadingTextIconProperty, value); }
        }

        public string CardFooter
        {
            get { return (string)GetValue(CardFooterProperty); }
            set { SetValue(CardFooterProperty, value); }
        }

        public string CardButtonIcon
        {
            get { return (string)GetValue(CardButtonIconProperty); }
            set { SetValue(CardButtonIconProperty, value); }
        }

        public string CardImageBackground
        {
            get { return (string)GetValue(CardImageBackgroundProperty); }
            set { SetValue(CardImageBackgroundProperty, value); }
        }

        public Card()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty CardTotalAchievementsProperty =
            DependencyProperty.Register("CardTotalAchievements", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardUnlockedAchievementProperty =
            DependencyProperty.Register("CardUnlockedAchievement", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardImageHeightProperty =
            DependencyProperty.Register("CardImageHeight", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardImageWidthProperty =
            DependencyProperty.Register("CardImageWidth", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardImageProperty =
            DependencyProperty.Register("CardImage", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardHeaderProperty =
            DependencyProperty.Register("CardHeader", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardDescriptionProperty =
            DependencyProperty.Register("CardDescription", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardLeadingTextIconProperty =
            DependencyProperty.Register("CardLeadingTextIcon", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardFooterProperty =
            DependencyProperty.Register("CardFooter", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardButtonIconProperty =
            DependencyProperty.Register("CardButtonIcon", typeof(string), typeof(Card));

        public static readonly DependencyProperty CardImageBackgroundProperty =
            DependencyProperty.Register("CardImageBackground", typeof(string), typeof(Card));
    }
}

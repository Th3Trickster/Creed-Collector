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
    /// Interaction logic for GameCover.xaml
    /// </summary>
    public partial class GameCover : UserControl
    {
        public string CoverImage
        {
            get { return (string)GetValue(CoverImageProperty); }
            set { SetValue(CoverImageProperty, value); }
        }

        public string PlatformLogoOne
        {
            get { return (string)GetValue(PlatformLogoOneProperty); }
            set { SetValue(PlatformLogoOneProperty, value); }
        }

        public string PlatformLogoTwo
        {
            get { return (string)GetValue(PlatformLogoTwoProperty); }
            set { SetValue(PlatformLogoTwoProperty, value); }
        }

        public string PlatformLogoThree
        {
            get { return (string)GetValue(PlatformLogoThreeProperty); }
            set { SetValue(PlatformLogoThreeProperty, value); }
        }

        public string CardButtonIcon
        {
            get { return (string)GetValue(CardButtonIconProperty); }
            set { SetValue(CardButtonIconProperty, value); }
        }

        public string GameTitle
        {
            get { return (string)GetValue(GameTitleProperty); }
            set { SetValue(GameTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GameTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GameTitleProperty =
            DependencyProperty.Register("GameTitle", typeof(string), typeof(GameCover));

        // Using a DependencyProperty as the backing store for CardButtonIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardButtonIconProperty =
            DependencyProperty.Register("CardButtonIcon", typeof(string), typeof(GameCover));

        // Using a DependencyProperty as the backing store for PlatformLogoThree.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlatformLogoThreeProperty =
            DependencyProperty.Register("PlatformLogoThree", typeof(string), typeof(GameCover));

        // Using a DependencyProperty as the backing store for PlatformLogoTwo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlatformLogoTwoProperty =
            DependencyProperty.Register("PlatformLogoTwo", typeof(string), typeof(GameCover));

        // Using a DependencyProperty as the backing store for PlatformLogoOne.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlatformLogoOneProperty =
            DependencyProperty.Register("PlatformLogoOne", typeof(string), typeof(GameCover));

        // Using a DependencyProperty as the backing store for CoverImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CoverImageProperty =
            DependencyProperty.Register("CoverImage", typeof(string), typeof(GameCover));

        public GameCover()
        {
            InitializeComponent();
        }
    }
}

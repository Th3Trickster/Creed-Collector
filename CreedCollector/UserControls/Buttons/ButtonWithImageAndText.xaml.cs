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

namespace CreedCollector.UserControls.Buttons
{
    /// <summary>
    /// Interaction logic for ButtonWithImageAndText.xaml
    /// </summary>
    public partial class ButtonWithImageAndText : UserControl
    {
        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public string ButtonIcon
        {
            get { return (string)GetValue(ButtonIconProperty); }
            set { SetValue(ButtonIconProperty, value); }
        }

        public string ButtonIconWidth
        {
            get { return (string)GetValue(ButtonIconWidthProperty); }
            set { SetValue(ButtonIconWidthProperty, value); }
        }

        public string ButtonIconHeight
        {
            get { return (string)GetValue(ButtonIconHeightProperty); }
            set { SetValue(ButtonIconHeightProperty, value); }
        }

        public string ButtonWidth
        {
            get { return (string)GetValue(ButtonWidthProperty); }
            set { SetValue(ButtonWidthProperty, value); }
        }

        public string ButtonHeight
        {
            get { return (string)GetValue(ButtonHeightProperty); }
            set { SetValue(ButtonHeightProperty, value); }
        }

        public string ButtonTextColor
        {
            get { return (string)GetValue(ButtonTextColorProperty); }
            set { SetValue(ButtonTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonTextColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTextColorProperty =
            DependencyProperty.Register("ButtonTextColor", typeof(string), typeof(ButtonWithImageAndText));

        // Using a DependencyProperty as the backing store for ButtonHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonHeightProperty =
            DependencyProperty.Register("ButtonHeight", typeof(string), typeof(ButtonWithImageAndText));

        // Using a DependencyProperty as the backing store for ButtonWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonWidthProperty =
            DependencyProperty.Register("ButtonWidth", typeof(string), typeof(ButtonWithImageAndText));

        // Using a DependencyProperty as the backing store for ButtonIconHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonIconHeightProperty =
            DependencyProperty.Register("ButtonIconHeight", typeof(string), typeof(ButtonWithImageAndText));

        // Using a DependencyProperty as the backing store for ButtonIconWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonIconWidthProperty =
            DependencyProperty.Register("ButtonIconWidth", typeof(string), typeof(ButtonWithImageAndText));

        // Using a DependencyProperty as the backing store for ButtonIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonIconProperty =
            DependencyProperty.Register("ButtonIcon", typeof(string), typeof(ButtonWithImageAndText));

        // Using a DependencyProperty as the backing store for ButtonText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(string), typeof(ButtonWithImageAndText));


        public ButtonWithImageAndText()
        {
            InitializeComponent();
        }
    }
}

   M S B A M L   `   `   `  ����I  ECreedCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CreedCollectorCreedCollector  5   	   U/clr-namespace:CreedCollector.AttachedProperties!CreedCollector.AttachedProperties  5   	   T PCreedCollector.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhJclr-namespace:CreedCollector.ViewModels;assembly=CreedCollector.ViewModelsCreedCollector.ViewModels 5	   	   ,    &CreedCollector.CreateAccountWindowView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CreedCollector     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :prop/clr-namespace:CreedCollector.AttachedProperties  5   	   SvmJclr-namespace:CreedCollector.ViewModels;assembly=CreedCollector.ViewModels  5	   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Create an Account��5   	   $	��650��6#   $	��500��60    � 	Resources 5      <  6CreedCollector.ViewModels.CreateAccountWindowViewModel   vm��%   &	          5   
   6*   5      .��5      �  � DataContext# [  6   ��5   
   �� 5       �� ImageSource$&  Assets/LoginWindowBackground.jpg��6    �� Opacity$	 0.1Q�5       j� Stretch$ UniformToFill=�5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5!      $
��Auto �6   �� 5#      $
��Auto �6   �� 5%      $
��Auto �6   �� 5'      $
��Auto �6   �� 5)      $
��Auto �6   �� 5+      $
��Auto �6   .+�5/   
   ��  �� Orientation$ 
Horizontal=�6   .+�50      ��  . *MaterialDesignFloatingActionMiniDarkButton#��[ 51      	 � ToolTip$0	 *MaterialDesignFloatingActionMiniDarkButton��52      $��10 0 0 0q�53      {�50      �� *DataContext.ControlsEnabled+
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType$ WindowL���54      �� *ShowLoginWindowView+.��55      '  !MaterialDesignThemes.Wpf.PackIcon  $��32��6*   $��32��56   *      Kind$ 	ArrowBack=�57   *   58      59      �� 5<   
   $��Create an Account��6   $��22(�5=      $��DemiBold"�5>      $��Center=�5?      $��0 20 0 0q�5@      �� 5C   
   $��1��6   $	��300��5D      $��16(�5E      $��0 10 0 0q�5F       % !MaterialDesignFloatingHintTextBox#���  5G      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
First Name��5H      ��5I      �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5L   
   $��2��6   $	��300��5M      $��16(�5N      $��0 10 0 0q�5O      #���  5P      $ 	Last Name��5Q      ��5R      �� *
LastName+$ PropertyChanged=��� 5U   
   $��3��6   $	��300��5V      $��16(�5W      $��0 10 0 0q�5X      #���  5Y      $ Email��5Z      ��5[      �� *Email+$ PropertyChanged=��� 5^   
   $��4��6   $	��300��5_      $��16(�5`      $��0 10 0 0q�5a      #���  5b      $ Username��5c      ��5d      �� *
UserName+$ PropertyChanged=�G� 5g   
   -   5        $��5��5g      $	��300��5h      $��16(�5i      $��0 10 0 0q�5j       ) %MaterialDesignFloatingHintPasswordBox#���  5k      $ Password��5l      E   ?CreedCollector.AttachedProperties.PasswordBoxAttachedProperties   EncryptedPassword 5m      �� *PasswordSecureString+ �� Mode$ TwoWay=�$ PropertyChanged=�5n      �� 5q   
   $��6��6   $	��300��5r      $��16(�5s      $��0 10 0 0q�5t      #���  5u      $ Xbox Live Gamertag��5v      ��5w      �� *XboxLiveGamertag+$ PropertyChanged=��� 5z   
   $��7��6   $	��300��5{      $��16(�5|      $��0 10 0 0q�5}      #���  5~      $ Steam Username��5      ��5�      �� *SteamUsername+$ PropertyChanged=��� 5�   
   $��8��6   $	��300��5�      $��16(�5�      $��	0 10 0 15q�5�      #���  5�      $ PSN Name��5�      ��5�      �� *	PsnName+$ PropertyChanged=��� 5�   
   $��9��6   $��Create Account��5�      $	��300��5�      $��50��5�      $��16(�5�      ��5�      �� *CreateUserCommand+5�      5�      
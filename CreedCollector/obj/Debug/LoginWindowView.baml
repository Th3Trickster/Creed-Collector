   M S B A M L   `   `   `  ����I  ECreedCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CreedCollectorCreedCollector  5   	   T PCreedCollector.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhJclr-namespace:CreedCollector.ViewModels;assembly=CreedCollector.ViewModelsCreedCollector.ViewModels 5   	   U/clr-namespace:CreedCollector.AttachedProperties!CreedCollector.AttachedProperties  5   	   $    CreedCollector.LoginWindowView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CreedCollector     5   	   YvmJclr-namespace:CreedCollector.ViewModels;assembly=CreedCollector.ViewModels     5   	   @prop/clr-namespace:CreedCollector.AttachedProperties     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Login��5   	   $	��600��6   $	��500��6$    � 	Resources 5      4  .CreedCollector.ViewModels.LoginWindowViewModel   vm��%   &	          5   
   6"   5      .��5      �  � DataContext# [  6   ��5   
   �� 5       �� ImageSource$&  Assets/LoginWindowBackground.jpg��6    �� Opacity$	 0.1Q�5       j� Stretch$ UniformToFill=�5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5"      $
��Auto �6   �� 5$      $
��Auto �6   �� 5&      $
��Auto �6   �� 5(      $
��Auto �6   .+�5,   
   �� $%��Assets/DefaultUserLoginIcon.png��6   $	��150��5-      $	��150��5.      $��0��5/      $��	0 50 0 10q�50      �� 53   
   $��Login to Your Account��6   $��1��54      $��Center=�55      $��22(�56      $��DemiBold"�57      $��0 0 0 10q�58      �� 5;   
   $��2��6   $	��300��5<      $��16(�5=      $��0 0 0 20q�5>       % !MaterialDesignFloatingHintTextBox#���  5?      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5@      ��5A      �� *
UserName+	 �� UpdateSourceTrigger$	 PropertyChanged=�G� 5D   
   -   5        $��3��5D      $	��300��5E      $��16(�5F      $��0 0 0 15q�5G       ) %MaterialDesignFloatingHintPasswordBox#���  5H      $ Password��5I      E   ?CreedCollector.AttachedProperties.PasswordBoxAttachedProperties
   EncryptedPassword
 5J      �� *PasswordSecureString+ �� Mode$ TwoWay=�$	 PropertyChanged=�5K      � 5N   
   $��4��6   $	��300��5O       � ColumnDefinitions 5P      �� 5R      $��1* �6#   �� 5T      $��1* �6#   .+�5X      �� .��5Y      �� $��Remember me��6   $��14(�5Z      $��0 -4 0 0q�5[      5\      �� 5_      $��1��6   $��14(�5`      $��0 -2 0 0q�5a      $��Right=�5b      �� 5c      .�6   Forgot Password?5e      5f      5g      �� 5j   
   $��Login��6   $��5��5k      $	��300��5l      $��0 25 0 0q�5m      ��5n      �� *LoginCommand+�� 5q   
   $��Need an account?��6   $��6��5r      $��Center=�5s      $��16(�5t      $��0 15 0 0q�5u      �� 5x   
   $��16(�6   $��7��5y      $��Center=�5z      �� 5{       �� Command 6   �� *ShowCreateAccountWindowView+.�6H   
Create One5}      5~      5      5�      
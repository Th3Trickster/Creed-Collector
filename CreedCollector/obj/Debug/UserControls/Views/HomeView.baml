   M S B A M L   `   `   `  ����T  PCreedCollector.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullhJclr-namespace:CreedCollector.ViewModels;assembly=CreedCollector.ViewModelsCreedCollector.ViewModels  5      I ECreedCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:CreedCollector.UserControls.Views!CreedCollector.UserControls.Views 5      I)clr-namespace:CreedCollector.UserControlsCreedCollector.UserControls 5      0   *CreedCollector.UserControls.Views.HomeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      YvmJclr-namespace:CreedCollector.ViewModels;assembly=CreedCollector.ViewModels     5      Alocal/clr-namespace:CreedCollector.UserControls.Views     5      8uc)clr-namespace:CreedCollector.UserControls     5      
�������  � DataContext  5      -   'CreedCollector.ViewModels.HomeViewModel  5   
   .��5      �� $
��Auto=�6   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $	��150 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��1��5      ���#3938365      �� 5   
   $��1��6   $��1��5      ���#F4F7FA5       �� 5"   
    �� Orientation$ Vertical=�6   $��Center=�5#      .+�5$      �� $
��Home��6   $��24(�5%      
�������$��Center=�5'      �� 5(      $��Your stats at a glance��6   $��16(�5)      
�������$��Center=�5+      5,      � 5/   
   $��1��6    � ColumnDefinitions 50      �� 52      $��1* �6#   �� 54      $��1* �6#   �� 56      $��1* �6#   �� 58      $��1* �6#   �� 5:      $��1* �6#   .+�5=      �� $ Vertical=�6   .+�5>      �� $��Xbox One��6   $��Center=�5?      $��16(�5@      �� 5A      $��Achievements��6   $��Center=�5B      $��16(�5C      �� 5E      $ 
Horizontal=�6   $��Center=�5F      .+�5G      �� $��Center=�5H       $��22(�5I       $
��Bold"�5J       ��5G       �� *#!UnlockedXboxOneAchievements.Count+ �� UpdateSourceTrigger$ PropertyChanged=�5J       �� 5K      $��/��6    $��Center=�5L       $��22(�5M       $
��Bold"�5N       �� 5O      $��Center=�5P       $��22(�5Q       $
��Bold"�5R       ��5O       �� *XboxGameAchievements.Count+$ PropertyChanged=�5R       5S      5T      �� 5U      $��Playstation 4 Trophies��6   $��Center=�5V      $��1��5W      �� 5X      $��Steam Achievements��6   $��Center=�5Y      $��2��5Z      �� 5[      $��Xbox 360 Achievements��6   $��Center=�5\      $��3��5]      �� 5^      $��Playstation 3 Trophies��6   $��Center=�5_      $��4��5`      5a      � 5d   
   $��2��6    5e      �� 5f      $��1* �6#   �� 5g      $��1* �6#    5j      �� 5k      $
��Auto �6    �� 5l      $
��Auto �6    �� 5m      $
��Auto �6    �� 5n      $
��Auto �6    �� 5o      $
��Auto �6    �� 5p      $
��Auto �6    .+�5t      &   CreedCollector.UserControls.Card  $��0��6      
CardHeader$* $Assassin's Creed The Ezio Collection��5u         
CardFooter$ Xbox One��5v         	CardImage$  /Assets/EzioCollection.jpg��5w         CardImageWidth$ 86��5x      	   CardImageHeight$		 110��5y      
   CardButtonIcon$
 
ArrowRight��5z         CardImageBackground$ #107C10��5{         CardLeadingTextIcon$ /Assets/XboxLogo.png��5|      $��	25 15 0 0q�5}        5�      $��1��6   $% Assassin's Creed III Remastered��5�      $ Xbox One��5�      $- '/Assets/AssassinsCreedIIIRemastered.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	0 15 25 0q�5�        5�      $��0��6   $��1��5�      $% Assassin's Creed IV: Black Flag��5�      $ Xbox One��5�      $+ %/Assets/AssassinsCreedIVBlackFlag.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	25 15 0 0q�5�        5�      $��1��6   $��1��5�      $' !Assassin's Creed Rogue Remastered��5�      $ Xbox One��5�      $/ )/Assets/AssassinsCreedRogueRemastered.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	0 15 25 0q�5�        5�      $��0��6   $��2��5�      $ Assassin's Creed Unity��5�      $ Xbox One��5�      $% /Assets/AssassinsCreedUnity.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	25 15 0 0q�5�        5�      $��1��6   $��2��5�      $( "Assassin's Creed Chronicles: China��5�      $ Xbox One��5�      $/ )/Assets/AssassinsCreedChroniclesChina.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	0 15 25 0q�5�        5�      $��0��6   $��3��5�      $( "Assassin's Creed Chronicles: India��5�      $ Xbox One��5�      $/ )/Assets/AssassinsCreedChroniclesIndia.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	25 15 0 0q�5�        5�      $��1��6   $��3��5�      $) #Assassin's Creed Chronicles: Russia��5�      $ Xbox One��5�      $0 */Assets/AssassinsCreedChroniclesRussia.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	0 15 25 0q�5�        5�      $��0��6   $��4��5�      $  Assassin's Creed Syndicate��5�      $ Xbox One��5�      $) #/Assets/AssassinsCreedSyndicate.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	25 15 0 0q�5�        5�      $��1��6   $��4��5�      $ Assassin's Creed Origins��5�      $ Xbox One��5�      $' !/Assets/AssassinsCreedOrigins.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	0 15 25 0q�5�         CardUnlockedAchievement 5�      �� *#!UnlockedXboxOneAchievements.Count+$ PropertyChanged=�   CardTotalAchievements 5�      �� *XboxGameAchievements.Count+$ PropertyChanged=�5�        5�      $��0��6   $��5��5�      $ Assassin's Creed Odyssey��5�      $ Xbox One��5�      $' !/Assets/AssassinsCreedOdyssey.jpg��5�      $ 86��5�      $		 110��5�      $
 
ArrowRight��5�      $ #107C10��5�      $ /Assets/XboxLogo.png��5�      $��	25 15 0 0q�5      5     5     5     5     
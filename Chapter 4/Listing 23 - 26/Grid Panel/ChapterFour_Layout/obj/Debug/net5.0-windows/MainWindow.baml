   M S B A M L   `   `   `  ����M  IChapterFour_Layout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ChapterFour_LayoutChapterFour_Layout  5   	   #    ChapterFour_Layout.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ChapterFour_Layout     5   	     � Title$  
MainWindow��5   	   $	��150��6   $	��400��6)   .��5
      � -   5         �Name$ MainGrid��5
      
����İ� � ShowGridLines$
 True��5      $	��400��5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $��45 �6   �� 5      $��45 �6   .+�5   
   �� -   5         ��Name$ TextBlockHeaderOne��5      $��14(�5      $
��Bold"�5      
��� � �$��20��5      $��
Model Name��5      $	��Top=�5      �� 5!   
   -   5        $ TextBlockHeaderSecond��5!      $��14(�5"      $
��Bold"�5#      
��� � �$��20��5%      $��OS��5&      $	��Top=�5'      $��1��5(      �� 5*   
   -   5        $ TextBlockHeaderThird��5*      $��14(�5+      $
��Bold"�5,      
��� � �$��Company��5.      $��20��5/      $	��Top=�50      $��2��51      �� 53   
   -   5        $ TextBlockModelOne��53      $��12(�54      $��	iPhone 12��55      $��1��56      �� 58   
   -   5        $ TextBlockOSOne��58      $��12(�59      $��ios 14��5:      $��1��5;      $��1��5<      �� 5>   
   -   5        $ TextBlockCompanyOne��5>      $��12(�5?      $��Apple��5@      $��1��5A      $��2��5B      �� 5D   
   -   5        $ TextBlockModelTwo��5D      $��12(�5E      $��Note 20��5F      $��2��5G      �� 5I   
   -	   5        $ TextBlockMOSTwo��5I      $��12(�5J      $��Android��5K      $��1��5L      $��2��5M      �� 5O   
   -
   5        $ TextBlockCompanyTwo��5O      $��12(�5P      $��Samsung��5Q      $��2��5R      $��2��5S      5T      5V      
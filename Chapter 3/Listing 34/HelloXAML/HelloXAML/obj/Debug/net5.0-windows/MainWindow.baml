   M S B A M L   `   `   `  ����D  @HelloXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HelloXAML	HelloXAML  5   	       HelloXAML.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:HelloXAML     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��600��6)    � 	Resources 5	         GreenButtonStyle �� 
TargetType �� Property �� Value��%^  &	        �� 5   
   " ��6)   .�5      ��  � ��
 � d �6+   �� 5       � ��
 �   �6,   �� 5       � ��$ Verdana)�6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Normal"�6+   �� 5       � ��
 �����6+   �� 5       � ��$ 30��6'   �� 5       � ��$	 120��6&   5      5      .��5      � -   5        $��
RootLayout��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ TextBoxBrowse��5      $��30��5      $
��Left=�5      $��5q�5       $	��390��5!      $	��Top=�5"      �� 5$   
   -   5         ��Name$ ButtonBrowse��5$      #��[  5%      $��Browse��5&      $��Right=�5'      $��5q�5(      $	��Top=�5)      �� 5+   
   -   5         ��Name$ TextBlockDetails��5+      
�������$��Georgia)�5-      $��12(�6)   
��� ���$	��100��5/      $��5q�50      $��1��51      �� 53   
   -   5        $ ButtonSpellCheck��53      #��[  54      $��Spell Check��55      $��Right=�56      $��5q�57      $��Bottom=�58      $��2��59      �� 5;   
   -   5        $ ButtonSaveFile��5;      #��[  5<      $��	Save File��5=      $��Right=�5>      $��	0 0 150 5q�5?      $��Bottom=�5@      $��2��5A      5B      5E      
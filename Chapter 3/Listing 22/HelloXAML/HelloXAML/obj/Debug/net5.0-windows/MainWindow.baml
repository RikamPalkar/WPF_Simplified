   M S B A M L   `   `   `  ����D  @HelloXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HelloXAML	HelloXAML  5   	       HelloXAML.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:HelloXAML     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $��
RootLayout��5	       � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ StackPanelRadioButtons��5      ���	#FFF1EFEF$��43��5      $
��Left=�5      $��5q�5       �� Orientation$ 
Horizontal=�5      $	��Top=�5      $	��462��5      .+�5      	� -   5         	�Name$ RadioButtonRedBackground��5      $��Red Background��5      $��5q�5      $	��184��5      	� 5      -   5        $  RadioButtonGreenBackground��5      $��Green Background��5      $��5q�5      $	��207��5      5      �� 5!   
   -   5         ��Name$ ButtonLoadText��5!      $��	Load Text��5"      $��26��5#      $��Center=�5$      $��0 5 5 5q�5%      $	��Top=�5&      $	��131��5'      $��1��5(      �� 5*   
   -   5         ��Name$ TextBlockRedBackground��5*      ���	#FFEB4A4A���	#FFF5F3F3$��85��5-      $
��Left=�5.      $��5q�5/      $
��Wrap=�50      $	��Top=�51      $	��462��52      $��2��53      �� 54      ���	#FFEE3A3A$�	TextBlock��55      56      �� 57   
   -   5         ��Name$ LoadTextBox��57      $��29��58      $
��Left=�59      $��TextBox��5:       �� TextWrapping$
 Wrap=�5;      $��5q�5<      $	��Top=�5=      $	��317��5>      $��1��5?      5@      5B      
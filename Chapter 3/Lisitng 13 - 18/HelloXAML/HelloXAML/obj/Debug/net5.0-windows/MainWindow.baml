   M S B A M L   `   `   `  ����D  @HelloXAML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:HelloXAML	HelloXAML  5   	       HelloXAML.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:HelloXAML     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � -   5        $��
RootLayout��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ ButtonFirst��5      $��I am Content��5      $��0 5 0 0q�5      $��50��5      $	��200��5      �� 5   
   -   5        $ ButtonSecond��5      $��0 5 0 0q�5      $��80��5      $	��200��5      $��1��5      .��5      �� -   5         ��Name$ RectangleInner��5      
���z���$��40��5!      $	��100��5"      5#      �� 5&   
   -   5        $ ButtonThird��5&      $��0 5 0 0q�5'      $	��150��5(      $	��400��5)      $��2��5*      .��5+      �� -   5         ��Name$ StackPanelMain��5+      
�������$	��100��5-       �� Orientation$ 
Horizontal=�5.      $	��360��5/      .+�50      A� -   5         A�Name$ 
EllipseRed��50      
���  ��$��60��52      $��5 0 0 0q�53      $��60��54      �� 55      -   5         ��Name$ TextBlockFirst��55      $��
Red Circle��56       �� TextAlignment$ Center=�57      �� 58      $� Red Circle��6   59      �� 5:      -	   5        $ TextBlockBlankSpace��5:      $ Center=�5;      �� 5<      $�      ��6   5=      �� 5>      -
   5        $ RectangleGreen��5>      
��� � �$��60��5@      $	��120��5A      �� 5B      -   5        $ TextBlockLast��5B      $ Center=�5C      �� 5D      $� Green Rectangle��6   5E      5F      5G      5H      5I      
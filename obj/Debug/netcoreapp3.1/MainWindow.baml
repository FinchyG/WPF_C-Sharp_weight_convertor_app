   M S B A M L   `   `   `  ����K  GWeight Converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Weight_ConverterWeight_Converter  5   	   !    Weight_Converter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Weight_Converter     5   	     � Title$  
MainWindow��5   	   $	��275��6   $	��300��6)    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ Styles.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $	��100 �6   .+�5   
   � $��Center=�6   $��Center=�6/   .+�5      �� $��
Conversion��6   �� 5      -   5        $��unitsChoice��5      .@�5      ��  �� 
IsSelected$
 True��6   $��	KG to lbs��61   �� 5      $��	lbs to KG��6   �� 5      $��grams to ounces��6   �� 5      $��ounces to grams��6   5      �� 5      
�������$��2q�6-   ._�5      �� -   5        $��	fromInput��5      6+   5       5!      � 5"   
   $��1��6   $��Center=�6!   $��5q�6>   .+�5#      �� 
����� �$��2q�6/   ._�5$      �� -   5        $��
btnConvert��5$      .��6<   	Convert6E   5%      5&      � 5'   
   $��2��6   $��Center=�6!   $��Center=�6<   .+�5(      �� $��Result��6   �� 5)      
�������$��2q�6-   ._�5*      �� -   5        $��toOutput��5*      ��6,   �� *
userNumber+5+      5,      5-      5.      
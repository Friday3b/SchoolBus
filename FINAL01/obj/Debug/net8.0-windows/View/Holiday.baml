   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5          FINAL01.View.Holiday   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5        N� Title$  Holiday��5	       � 	Resources 5      &   System.Windows.Controls.Calendar �� 
TargetType �� Property �� Value �� 
TargetType � RowDefinitions � ColumnDefinitions �� Path	 �� RelativeSource
 �� StringFormat5  /System.Windows.Controls.Primitives.CalendarItem  Name��%�  '        �� 5   
   "  6   .�5      ��  � �� 5      �� 5      "  6&   .R�5      �  5      �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $��* �60   .+�5      �� 
�������$��1q�6=   
����ح�._�5   "   �  5   &   �� 5   *   $��30 �68   �� 5   *    5   &   �� 5   *   $��* �6;   �� 5   *   $
��Auto �6;   �� 5    *   $��* �6;   .+�5"   &   �� -   5        $
��Prev��5"   -   $��0��6<   $��0��6I   6Y   �� 5#   &   $��0��6�   $��1��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   ��60   �� $ DisplayDate�	 �� *TemplatedParent+$
 {0:MMMM yyyy}��6�   �� 5$   &   -   5        $
��Next��5$   -   $��0��6<   $��2��6I   6Y     5%   &   $ PART_CalendarItem��63   $��1��6N   $��3��6[   5&   #   5'      5(      5)      5+      5,      5-      .��5/      � 
������� 50   
   �� 51      $
��Auto �6   �� 52      $��* �6    55   
   �� 56      $��* �6   �� 57      $��* �6   .+�5:   
   �� $��0��6   $��0��6"   $��2��62   .+�5;      �� $��Holidays��6   $��24(�6(   $
��Bold"�66   $��10q�6H     5<      -   5        $��HolidayCalendar��5<         SelectionMode$ 
SingleDate=�6.      DisplayMode$ Month=�6I      DisplayDateStart 1/1/20246]      DisplayDateEnd 
12/31/20246y      IsTodayHighlighted$
 True��6�      BlackoutDates 5=      /  )System.Windows.Controls.CalendarDateRange  5?         Start$ 
01/01/2024��6(   
   End$ 
01/01/2024��6;     5A      $ 
04/23/2024��6(   $ 
04/23/2024��6;     5C      $ 
05/01/2024��6(   $ 
05/01/2024��6;     5E      $ 
05/19/2024��6(   $ 
05/19/2024��6;     5G      $ 
07/15/2024��6(   $ 
07/15/2024��6;     5I      $ 
08/30/2024��6(   $ 
08/30/2024��6;     5K      $ 
10/29/2024��6(   $ 
10/29/2024��6;     5M      $ 
04/08/2024��6(   $ 
04/11/2024��6;     5O      $ 
06/16/2024��6(   $ 
06/19/2024��6;   5R      �� 5S      $��10q�6^   ��6   ��  �� ElementName$ HolidayCalendar��$ SelectedDates�5T      5U      5V      5W      
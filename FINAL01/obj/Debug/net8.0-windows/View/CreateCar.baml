   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5          FINAL01.View.CreateCar   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5        N� Title$  	CreateCar��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��Bottom=�6"   .+�5      �� $��50��6   $��New Car��6%   $��40(�64   $��	ExtraBold"�6B   $	��300��6Y   
��� ��� �� TextAlignment$ Center=�6y   6�   5      �� 5   
   $��1��6   $
��Left=�6"   $	��100��6=   .+�5      �� -   5        $��name_of_car��5      $��50��6)   $	��700��65   $
��Name��6A   $��15(�6M   $��
ExtraBlack"�6[   $��10 10 10 10q�6s   
 � Tag$
 Name��6�   
�������.��6�   5      5       �� 5!   
   $��2��6   $
��Left=�6"   $	��100��6=   .+�5"      �� -   5        $��number_of_car��5"      $��50��6+   $	��700��67   $��Number��6C   $��15(�6Q   $��
ExtraBlack"�6_   $��10 10 10 10q�6w   $ Number��6�   
�������.��6�   5#      5$      �� 5&   
   $��3��6   $
��Left=�6"   $	��100��6=   .+�5'      �� -   5        $��seatcount_of_car��5'      $��50��6.   $	��700��6:   $��
Seat Count��6F   $��15(�6X   $��
ExtraBlack"�6f   $��10 10 10 10q�6~   $ 
Seat Count��6�   
�������.��6�   5(      5)      �� 5+   
   $��4��6   $��Right=�6"   $��Bottom=�6>   .+�5,      �� -   5        $��create_newcar��5,      $��CREATE��6*   $��	ExtraBold"�6;   $��25(�6R   
���������6z   �� *SaveCommand+5.      5/      52      53      
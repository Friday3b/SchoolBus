   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5          FINAL01.View.CreateDriver   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5        N� Title$  CreateDriver��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5   
   $��2* �6   6&   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   �� 5   
   $��* �6   6%   .+�5    
   �� $��0��6   $��Bottom=�6"   .+�5!      �� $��50��6   $��
New Driver��6%   $��40(�67   $��	ExtraBold"�6E   $	��300��6\   
��� ��� �� TextAlignment$ Center=�6|   6�   5"      �� 5#   
   $��1��6   $
��Left=�6"   $	��100��6=   .+�5$      �� -   5        $��firstname_of_driver��5$      $��50��61   $	��700��6=   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
 � Tag$ 	FirstName��6  
���������6I   �� *CurrentDriver.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�.��66  5%      5&      �� 5'   
   $��2��6   $
��Left=�6"   $	��100��6=   .+�5(      �� -   5        $��lastname_of_driver��5(      $��50��60   $	��700��6<   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
�������$ LastName��6%  ��6H   �� *CurrentDriver.LastName+$ PropertyChanged=�.��64  5)      5*      �� 5,   
   $��3��6   $
��Left=�6"   $	��100��6=   .+�5-      �� -   5        $��phone_of_driver��5-      $��50��6-   $	��700��69   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
�������$ Phone��6   ��6E   �� *CurrentDriver.Phone+$ PropertyChanged=�.��6,  5.      5/      �� 55   
   $��4��6   $
��Left=�6"   $	��100��6=   .+�56      �� -   5        $��username_of_driver��56      $��50��60   $	��700��6<   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
�������$ Username��6"  ��6H   �� *CurrentDriver.Username+$ PropertyChanged=�.��61  57      58      �� 5=   
   $��5��6   $
��Left=�6"   $	��100��6=   .+�5>      �� -   5        $��password_of_driver��5>      $��50��60   $	��700��6<   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
�������$ Password��6#  ��6H   �� *CurrentDriver.Password+$ PropertyChanged=�.��62  5?      5@      �� 5B   
   $��6��6   $
��Left=�6"   $	��100��6=   .+�5C      �� -   5        $��gender_of_driver��5C      $��50��60   $	��600��6<   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
���������6H   �� *CurrentDriver.Gender+$ PropertyChanged=�5D      5E      �� 5F   
   $��6��6   $��Right=�6"   $	��130��6?   
�������$��Bottom=�6b   .+�5G      	� -   5        $#��gender_radiobutton_man_driver��5G      $	��Man��6?    	� 	GroupName$ 
stepschool��6M   
�������$��
ExtraBlack"�6~   6�   	� 5H      -   5        $%��gender_radiobutton_woman_driver��5H      $��Woman��6A   $ 
stepschool��6Q   
�������$��
ExtraBlack"�6�   6�   5I      �� 5K   
   $��7��6   $
��Left=�6"   $	��100��6=   .+�5L      �� -	   5        $��homeaddress_of_driver��5L      $��50��63   $	��600��6?   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
���������6K   �� *CurrentDriver.HomeAddress+$ PropertyChanged=�.��6)  5M      5N      �� 5O   
   $��7��6   $��Right=�6"   $��70��6>   $��Bottom=�6I   .+�5P      �� -
   5        $��homeaddress_locate_button��5P      
��� ���$��20��6J   6Y   5Q      �� 5U   
   $��9��6   $��Right=�6"   $��Bottom=�6>   .+�5V      �� -   5        $ ��create_newparent_of_driver��5V      $��CREATE��67   $��	ExtraBold"�6H   $��25(�6_   
���������6�   �� *SaveCommand+5X      5Y      �� 5[   
   $��8��6   $
��Left=�6"   $	��100��6=   .+�5\      �� -   5        $��license_of_driver��5\      $��50��6/   $	��600��6;   $��15(�6�   $��
ExtraBlack"�6�   $��10 10 10 10q�6�   
���������6G   �� *CurrentDriver.License+$ PropertyChanged=�.��6!  5]      5^      5c      5d      
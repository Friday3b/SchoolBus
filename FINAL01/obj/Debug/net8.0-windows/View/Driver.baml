   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5          FINAL01.View.Driver   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5        N� Title$  Driver��5	      .��5G      � 
������� � RowDefinitions 5H   
   �� 5I      $��50 �6   �� 5J      $	��400 �6   �� 5K      $��* �6    � ColumnDefinitions 5M   
   �� 5N      �� 5O      �� 5P      �� 5Q      �� 5R      .+�5U   
   �� $��0��6   $��0��6"   .+�5V      �� -   5        $��create_button_parent��5V      $��30��61   $��50��6=   $
��Left=�6H   
��� ���$��10q�6w   $��Create��6�   $��	ExtraBold"�6�   6�   5W      �� 5X   
   $��0��6   $��1��6"   $��Center=�62   .+�5Y      �� -   5        $��searching_textbox_driver��5Y      $��30��66   $��10q�6B   $��
ExtraBlack"�6�   $��12(�6�   ��6N   �� *CurrentDriver.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5Z      �� 5[   
   $��0��6   $��2��6"   $��Center=�62   .+�5\      �� -   5        $��search_button_driver��5\      $��30��61   $��50��6=   $
��Left=�6H   
��� ���$��10q�6w   $��Search��6�   $��	ExtraBold"�6�   ��6�   �� *SearchCommand+5]      &   System.Windows.Controls.DataGrid  5_   
   $��1��6   $��5��6       AutoGenerateColumns$ False��6W   $��10q�6s   ��64   �� *
DriverList+   Columns 5`      0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5b      $ 
First Name��6%   $ 90 6W    69   �� *	FirstName+6W     5c      $ 	Last Name��6%   $ 90 6U    68   �� *
LastName+6U     5d      $ Username��6%   $ 90 6T    67   �� *
Username+6T     5e      $ Phone��6%   $ 90 6O    64   �� *Phone+6O     5f      $	 Car��6%   $ 90 6K    62   �� *Car+6K     5g      $ License��6%   $ 90 6S    66   �� *	License+6S     5i      $ Actions��6%   $ 90 6R    66   �� *	Actions+6R   5k      5l      5o      
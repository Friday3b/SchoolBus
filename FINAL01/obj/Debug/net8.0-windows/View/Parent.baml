   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5          FINAL01.View.Parent   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5        N� Title$  Parent��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��400 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6"   .+�5      �� -   5        $��create_button_parent��5      $��30��61   $��50��6=   $
��Left=�6H   
��� ���$��10q�6w   $��Create��6�   $��	ExtraBold"�6�   6�   5      �� 5   
   $��0��6   $��1��6"   $��Center=�62   .+�5      �� -   5        $��searching_textbox_parent��5      $��30��66   $��10q�6B   $��
ExtraBlack"�6�   $��12(�6�   ��6N   �� *CurrentParent.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5       �� 5!   
   $��0��6   $��2��6"   $��Center=�62   .+�5"      �� -   5        $��search_button_parent��5"      $��30��61   $��50��6=   $
��Left=�6H   
��� ���$��10q�6w   $��Search��6�   $��	ExtraBold"�6�   ��6�   �� *SearchCommand+5#      &   System.Windows.Controls.DataGrid  5%   
   $��1��6   $��5��6       AutoGenerateColumns$ False��6W   $��10q�6s   ��64   �� *
ParentList+   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5(      $ 
First Name��6%    69   �� *	FirstName+  5)      $ 	Last Name��6%    68   �� *
LastName+  5*      $ Username��6%    67   �� *
Username+  5+      $ Phone��6%    64   �� *Phone+  5,      $ Actions��6%    66   �� *	Actions+5.      5/      50      
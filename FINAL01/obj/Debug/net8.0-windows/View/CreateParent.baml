   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5          FINAL01.View.CreateParent   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5        N� Title$  CreateParent��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   $��Center=�68   .+�5      �� -   5        $��firstname_of_textbox��5   -   
�������$	��150��6I   $��5q�6U   
 � Tag$ 	FirstName��6�   ��6`   �� *CurrentParent.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      -   5        $��lastname_of_textbox��5   -   
�������$	��150��6H   $��5q�6T   $ LastName��6�   ��6_   �� *CurrentParent.LastName+$ PropertyChanged=�6�   �� 5      -   5        $��phone_of_textbox��5   -   
�������$	��150��6E   $��5q�6Q   $ Phone��6�   ��6\   �� *CurrentParent.Phone+$ PropertyChanged=�6�   �� 5      -   5        $��username_of_textbox��5   -   
�������$	��150��6H   $��5q�6T   $ Username��6�   ��6_   �� *CurrentParent.Username+$ PropertyChanged=�6�   �� 5      -   5        $��password_of_textbox��5   -   
�������$	��150��6H   $��5q�6T   $ Password��6�   ��6_   �� *CurrentParent.Password+$ PropertyChanged=�6�   �� 5      $��
SaveParent��6   $	��100��6*   $��5q�66   
��� �����6A   �� *SaveCommand+6a   5      5      5      
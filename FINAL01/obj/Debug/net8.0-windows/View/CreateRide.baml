   M S B A M L   `   `   `  ����B  >FINAL01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FINAL01.ViewFINAL01.View  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5          FINAL01.View.CreateRide   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:FINAL01.View     5      bmapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF     5        N� Title$  
CreateRide��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��6* �6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��2��6"   .+�5      �� $
��Left=�6   $��90��60   $��30��6;   $��10q�6G   $	��ADD��6S   $��	ExtraBold"�6a   
��� ���$��20(�6�   5      �� 5   
   $��0��6   $��0��6"   .+�5      �� $
��Left=�6   $��90��63   $��30��6>   $��WHERE :��6J   
��� ���$��	ExtraBold"�6m   $��10q�6�    �� TextAlignment$ Center=�6�   $��20(�6�   	� 5      $��to Home��6    	� 	GroupName$ 
stepschool��6,   $��10 0 0 0q�6C   
�������$��
ExtraBlack"�6n   	� 5       $��	to School��6   $ 
stepschool��6.   $��10 0 0 0q�6E   
�������$��
ExtraBlack"�6p   5!      �� 5$   
   $��1��6   $��0��6"   
��� ���$��10q�6F   .+�5%      �� $��DRIVER��6   
���   �$��15(�69   $��	ExtraBold"�6G   $��Center=�6^   5&      �� 5(   
   $��1��6   $��1��6"   
��� ���$��10q�6F   .+�5)      �� $��GROUPS��6   
���   �$��15(�69   $��	ExtraBold"�6G   $��Center=�6^   5*      �� 5,   
   $��1��6   $��2��6"   
��� ���$��10q�6F   .+�5-      �� $��	LOCATIONS��6   
���   �$��15(�6<   $��	ExtraBold"�6J   $��Center=�6a   5.      �� 51   
   $��2��6   $��0��6"    �� CanVerticallyScroll$
 True��62   .+�52      �� -   5        $��Driver_combobox��52       �� DisplayMemberPath$ 	FirstName��6Q   ��6.   �� *
DriverList+ �� SelectedItem 6o   �� *CurrentDriver+53      �� 56   
   $��2��6   $��1��6"   $
 True��62   .+�57      �� -   5        $��Student_combobox��57      $ 	Classname��6Q   ��6/   �� *	ClassList+ 6o   �� *CurrentClass+58      �� 5;   
   $��2��6   $��2��6"   $
 True��62   .+�5<      �� -   5        $$��Student_combobox_assemblypoint��5<      $ AssemblyPoint��6_   ��6=   �� *	ClassList+ 6�   �� *CurrentClass+5=      � 5@   
   $��2��6   $��3��6   $��10q�60   .+�5A      '  !Microsoft.Maps.MapControl.WPF.Map  -   5        $��mp��5A   �   +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$r lyBGOll6t4KlDDiucfEiS~ltnmWMT-VFLHA-q9PrFP2Q~AvEjOgKmb6a9PJ3X0My1yHbyTJ6kGkeqWQGy8C35YFXZA7exALq2JhvBDFm0R_Gx 6   $��	0,13,0,41q�6�   	 J� RenderTransformOrigin$	 0.5,0.5&�6�   z�5B      V� 5C      .~�5D      �� �� 5E      
 �� AngleX$
 1.008Q�6(   �� 5F      T� 5G       T� X$ -1.849Q�6-   5H         Children. 5K      +  %Microsoft.Maps.MapControl.WPF.Pushpin     Location<  6Microsoft.Maps.MapControl.WPF.Design.LocationConverter$ 40.403665, 49.807948 6   $��-11,-18,11,18q�6>   ��5L      �� 5M      .R�5N      A� $��9��6&   $��9��60   
���  ��6I   5O      5Q      5R      5S      �� 5U   
   $��2��6   $��2��6"   $��Bottom=�62   .+�5V      �� $��START��6   $
��Left=�6F   $��90��6a   $��30��6l   $��10q�6x   $��	ExtraBold"�6�   
��� ���$��20(�6�   ��6%   �� *StartCommand+6�   5W      5X      5Y      
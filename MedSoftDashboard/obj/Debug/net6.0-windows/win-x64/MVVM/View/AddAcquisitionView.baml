   M S B A M L   `   `   `  ����K  GMedSoftDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MedSoftDashboard.MVVM.ViewMedSoftDashboard.MVVM.View  5      3    -MedSoftDashboard.MVVM.View.AddAcquisitionView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:MedSoftDashboard.MVVM.View     5      .��5	      �    DefaultFont#��[  6     � IsSharedSizeScope$
  True��6?   $��15(�6]   $��50, 0, 30, 30q�6u    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Adauga achizitie��5      $��28(�5      $
��Bold"�5      $��
0 20 20 20q�5      � 5   
   $��1��6   $��
0 10 20 20q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5!      �� 5"      $
��auto �6#    z� SharedSizeGroup$ FirstCol��60   �� 5#      $
��auto �6#   $ 	SecondCol��60   .+�5&      �� $��0��6   $��0��6%   $��Client��65   �� 5'      $��1��6   $��0��5(      $	��250��5+      $
��Left=�5,       �� SelectedValue 5)      �� *SelectedClient+ �� UpdateSourceTrigger$ PropertyChanged=���5*      �� *	Clients+��5-      �� 5.      .R�5/      �� ��6$   �� *DisplayName+50      52      �� 53      $��2��6   $��0��6%   $��0 5 0 0q�65   $�� ��6F   
���  ��6N   �� 55      $��0��6   $��1��6%   $��Proiect��65   $��20 0 0 0q�6D   �� 56      $��1��6   $��1��57      $	��250��5:      $
��Left=�5;      $��20 0 0 0q�5<       58      �� *SelectedProject+$ PropertyChanged=���59      �� *
Projects+��5=      �� 5>      .R�5?      �� ��6$   �� *DisplayName+5@      5B      �� 5C      $��2��6   $��1��6%   $��0 5 0 0q�65   $�� ��6F   
���  ��6N   5D      � 5F   
   $��2��6   $��
0 10 20 10q�6    5G      �� 5H      $
��auto �6    �� 5I      $
��auto �6    �� 5J      $
��auto �6     5M      �� 5N      $
��auto �6#   $ FirstCol��60   �� 5O      $
��auto �6#   $ 	SecondCol��60   .+�5R      �� $��0��6   $��0��6%   $
��Pret��65   �� 5S      $��1��6   $��0��6#   ��63   �� *Pret+$ PropertyChanged=��� 5T      $��2��6   $��0��6%   $��0 5 0 0q�65   
���  ����6F   �� *PropertyNamesToErrors[Pret]+6s   �� 5V      $��0��6   $��1��6%   $��Moneda��65   $��20 0 0 0q�6C   �� 5W      $��1��6   $��1��6$   $��20 0 0 0q�6L    �� Text 64   �� *Moneda+.@�5X      �� $	��RON��6   �� 5Y      $	��EUR��6   �� 5Z      $	��USD��6   5[      �� 5\      $��2��6   $��1��6%   $��0 5 0 0q�65   $�� ��6F   
���  ��6N   5]      � 5_   
   $��3��6   $��
0 10 20 20q�6    5`      �� 5a      $
��auto �6    �� 5b      $
��auto �6    �� 5c      $
��auto �6    .+�5f      �� $��0��6   $��DataAchizitie��6%   (  "System.Windows.Controls.DatePicker  5g      $��1��6   $	��250��6r   $
��Left=�6~      SelectedDate 6&   �� *DataAchizitie+$ PropertyChanged=�6~   �� 5h      $��2��6   $��0 5 0 0q�6%   
���  ����66   �� *&$PropertyNamesToErrors[DataAchizitie]+6l   5i      �� 5k   
   $��4��6    �� Orientation$ 
Horizontal=�6"   .+�5l      �� $��0 0 0 20q�6   	 �� CornerRadius$	 10��6'   $��0q�69   
�������._�5m      �� $��Adauga��6   $	��0 5q�5n      ���#2A93D5  AddButtonTheme#��[ 5q      ��5p      �� *SubmitCommand+5q      5r      �� 5s      $��	20 0 0 20q�6   $	 10��6(   $��0q�6:   
�������._�5t      �� $��Anuleaza��6   $
��10 5q�5u      
���  ��  DeleteButtonTheme#��[ 5x      ��5w      �� *CancelCommand+5x      5y      5z      5{      5|      
   M S B A M L   `   `   `  ����K  GMedSoftDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MedSoftDashboard.MVVM.ViewMedSoftDashboard.MVVM.View  5      4    .MedSoftDashboard.MVVM.View.EditAcquisitionView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:MedSoftDashboard.MVVM.View     5      .��5	      �    DefaultFont#��[  6     � IsSharedSizeScope$
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
   �� $��0��6   $��Editeaza achizitia��5      $��28(�5      $
��Bold"�5      $��
0 20 20 20q�5      � 5   
   $��1��6   $��
0 10 20 20q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5!      �� 5"      $
��auto �6#    z� SharedSizeGroup$ FirstCol��60   �� 5#      $
��auto �6#   $ 	SecondCol��60   .+�5&      �� $��0��6   $��0��6%   $��Client��65   �� 5'      $��1��6   $��0��5(      $	��250��5+      $
��Left=�5,       �� SelectedIndex$ 0��5-       �� SelectedValue 5)      �� *SelectedClient+ �� UpdateSourceTrigger$ PropertyChanged=���5*      �� *	Clients+��5.      �� 5/      .R�50      �� ��6$   �� *DisplayName+51      53      �� 54      $��2��6   $��0��6%   $��0 5 0 0q�65   $�� ��6F   
���  ��6N   �� 56      $��0��6   $��1��6%   $��	Achizitie��65   $��20 0 0 0q�6F   �� 57      $��1��6   $��1��58      $	��250��5;      $
��Left=�5<      $��20 0 0 0q�5=      $ 0��5>       59      �� *SelectedProject+$ PropertyChanged=���5:      �� *
Projects+��5?      �� 5@      .R�5A      �� ��6$   �� *DisplayName+5B      5D      �� 5E      $��2��6   $��1��6%   $��0 5 0 0q�65   $�� ��6F   
���  ��6N   5F      � 5H   
   $��2��6   $��
0 10 20 10q�6    5I      �� 5J      $
��auto �6    �� 5K      $
��auto �6    �� 5L      $
��auto �6     5O      �� 5P      $
��auto �6#   $ FirstCol��60   �� 5Q      $
��auto �6#   $ 	SecondCol��60   .+�5T      �� $��0��6   $��0��6%   $
��Pret��65   �� 5U      $��1��6   $��0��6#   ��63   �� *Pret+$ PropertyChanged=��� 5V      $��2��6   $��0��6%   $��0 5 0 0q�65   
���  ����6F   �� *PropertyNamesToErrors[Pret]+6s   �� 5X      $��0��6   $��1��6%   $��Moneda��65   $��20 0 0 0q�6C   �� 5Y      $��1��6   $��1��6$   $��20 0 0 0q�6q    �� Text 64   �� *Moneda+$ PropertyChanged=�.@�5Z      �� $	��RON��6   �� 5[      $	��EUR��6   �� 5\      $	��USD��6   5]      �� 5^      $��2��6   $��1��6%   $��0 5 0 0q�65   $�� ��6F   
���  ��6N   5_      � 5a   
   $��3��6   $��
0 10 20 20q�6    5b      �� 5c      $
��auto �6    �� 5d      $
��auto �6    �� 5e      $
��auto �6    .+�5h      �� $��0��6   $��Versiune��6%   (  "System.Windows.Controls.DatePicker  5i      $��1��6   $	��250��6r   $
��Left=�6~      SelectedDate 6&   �� *DataAchizitie+$ PropertyChanged=�6~   �� 5j      $��2��6   $��0 5 0 0q�6%   
���  ����66   �� *&$PropertyNamesToErrors[DataAchizitie]+6l   5k      �� 5m   
   $��4��6   	 �� Orientation$	 
Horizontal=�6"   .+�5n      �� $��0 0 0 20q�6   
 �� CornerRadius$
 10��6'   $��0q�69   
�������._�5o      �� $��Salveaza��6   $	��0 5q�5p      ���#2A93D5  AddButtonTheme#��[ 5s      ��5r      �� *SubmitCommand+5s      5t      �� 5u      $��	20 0 0 20q�6   $
 10��6(   $��0q�6:   
�������._�5v      �� $��Anuleaza��6   $
��10 5q�5w      
���  ��  DeleteButtonTheme#��[ 5z      ��5y      �� *CancelCommand+5z      5{      5|      5}      5~      
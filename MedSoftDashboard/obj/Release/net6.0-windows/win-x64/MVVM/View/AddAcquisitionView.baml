   M S B A M L   `   `   `  ���� K  GMedSoftDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MedSoftDashboard.MVVM.ViewMedSoftDashboard.MVVM.View  3    -MedSoftDashboard.MVVM.View.AddAcquisitionView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:MedSoftDashboard.MVVM.View     .���    DefaultFont#��[    � IsSharedSizeScope$
  True��$��15(�$��50, 0, 30, 30q� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��Adauga achizitie��$��28(�$
��Bold"�$��
0 20 20 20q�� $��1��$��
0 10 20 20q� �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto � z� SharedSizeGroup$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$��Client���� $��1��$��0��$	��250��$
��Left=� �� SelectedValue �� *SelectedClient+ �� UpdateSourceTrigger$ PropertyChanged=����� *	Clients+���� .R��� ���� *DisplayName+�� $��2��$��0��$��0 5 0 0q�$�� ��
���  ���� $��0��$��1��$��Proiect��$��20 0 0 0q��� $��1��$��1��$	��250��$
��Left=�$��20 0 0 0q� �� *SelectedProject+$ PropertyChanged=����� *
Projects+���� .R��� ���� *DisplayName+�� $��2��$��1��$��0 5 0 0q�$�� ��
���  ��� $��2��$��
0 10 20 10q� �� $
��auto ��� $
��auto ��� $
��auto � �� $
��auto �$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$
��Pret���� $��1��$��0������ *Pret+$ PropertyChanged=��� $��2��$��0��$��0 5 0 0q�
���  ������ *PropertyNamesToErrors[Pret]+�� $��0��$��1��$��Moneda��$��20 0 0 0q��� $��1��$��1��$��20 0 0 0q� �� Text �� *Moneda+.@��� $	��RON���� $	��EUR���� $	��USD���� $��2��$��1��$��0 5 0 0q�$�� ��
���  ��� $��3��$��
0 10 20 20q� �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��DataAchizitie��(  "System.Windows.Controls.DatePicker  $��1��$	��250��$
��Left=�   SelectedDate �� *DataAchizitie+$ PropertyChanged=��� $��2��$��0 5 0 0q�
���  ������ *&$PropertyNamesToErrors[DataAchizitie]+�� $��4�� �� Orientation$ 
Horizontal=�.+��� $��0 0 0 20q�	 �� CornerRadius$	 10��$��0q�
�������._��� $��Adauga��$	��0 5q����#2A93D5  AddButtonTheme#��[ ���� *SubmitCommand+�� $��	20 0 0 20q�$	 10��$��0q�
�������._��� $��Anuleaza��$
��10 5q�
���  ��  DeleteButtonTheme#��[ ���� *CancelCommand+
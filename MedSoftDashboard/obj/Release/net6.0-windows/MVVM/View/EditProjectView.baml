   M S B A M L   `   `   `  ���� K  GMedSoftDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MedSoftDashboard.MVVM.ViewMedSoftDashboard.MVVM.View  0    *MedSoftDashboard.MVVM.View.EditProjectView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:MedSoftDashboard.MVVM.View     .���    DefaultFont#��[    � IsSharedSizeScope$
  True��$��50, 0, 30, 30q�$��15(� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��Editeaza proiect��$��28(�$
��Bold"�$��0 0 0 20q�� $��1��$��	0 10 20 0q� �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto � z� SharedSizeGroup$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$��Id���� $��1��$��0��$	��250��$
��Left=� �� 
IsReadOnly$
 True��$��0 5 0 0q�$��20������ *Id+�� $��2��$��0��$��0 5 0 0q�
���  ������ *PropertyNamesToErrors[Id]+�� $��0��$��1��$
��Nume��$��20 0 0 0q��� $��1��$��1��$��20 5 0 0q�$	��250��$
��Left=����� *Nume+ �� UpdateSourceTrigger$ PropertyChanged=��� $��2��$��1��$��20 5 0 0q�
���  ������ *PropertyNamesToErrors[Nume]+� $��2��$��	0 10 20 0q� �� $
��auto ��� $
��auto ��� $
��auto � �� $
��auto �$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$	��Tip���� $��1��$��0��$��0 5 0 0q� �� Text �� *Tip+$ PropertyChanged=�.@��� $��HW���� $��SW���� $��HW & SW���� $��2��$��0��$��0 5 0 0q�
���  ������ *PropertyNamesToErrors[Tip]+�� $��0��$��1��$��	Descriere��$��20 0 0 0q��� $��1��$��1��$��20 5 0 0q����� *	Descriere+$ PropertyChanged=��� $��2��$��1��$��20 5 0 0q�
���  ������ *" PropertyNamesToErrors[Descriere]+� $��3��$��
0 10 20 10q� �� $
��auto ��� $
��auto ��� $
��auto � �� $
��auto �$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$��Data finalizare��(  "System.Windows.Controls.DatePicker  $��1��$��0��   SelectedDate �� *DataFinalizare+$ PropertyChanged=��� $��2��$��0��$��0 5 0 0q�
���  ������ *'%PropertyNamesToErrors[DataFinalizare]+�� $��0��$��1��$��Data actualizare��$��20 0 0 0q�  $��1��$��1��$��20 0 0 0q� �� *DataActualizare+$ PropertyChanged=��� $��2��$��1��$��20 5 0 0q�
���  ������ *(&PropertyNamesToErrors[DataActualizare]+� $��4��$��
0 10 20 10q� �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��Versiune���� $��1��$	��250��$
��Left=����� *
Versiune+$ PropertyChanged=��� $��2��$��0 5 0 0q�
���  ������ *!PropertyNamesToErrors[Versiune]+�� $��6�� �� Orientation$ 
Horizontal=�.+��� $��	20 0 0 20q�	 �� CornerRadius$	 10��$��0q�
�������._��� $��Salveaza��$
��10 5q����#2A93D5  AddButtonTheme#��[ ���� *SubmitCommand+�� $��	20 0 0 20q�$	 10��$��0q�
�������._��� $��Anuleaza��$
��10 5q�
���  ��  DeleteButtonTheme#��[ ���� *CancelCommand+
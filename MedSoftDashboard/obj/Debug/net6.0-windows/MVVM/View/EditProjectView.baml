   M S B A M L   `   `   `  ����K  GMedSoftDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MedSoftDashboard.MVVM.ViewMedSoftDashboard.MVVM.View  5      0    *MedSoftDashboard.MVVM.View.EditProjectView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:MedSoftDashboard.MVVM.View     5      .��5	      �    DefaultFont#��[  6     � IsSharedSizeScope$
  True��6?   $��50, 0, 30, 30q�6]   $��15(�6t    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Editeaza proiect��5      $��28(�5      $
��Bold"�5      $��0 0 0 20q�5      � 5   
   $��1��6   $��	0 10 20 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5!      �� 5"      $
��auto �6#    z� SharedSizeGroup$ FirstCol��60   �� 5#      $
��auto �6#   $ 	SecondCol��60   .+�5&      �� $��0��6   $��0��6%   $��Id��65   �� 5'      $��1��6   $��0��6#   $	��250��6G   $
��Left=�6S    �� 
IsReadOnly$
 True��6n   $��0 5 0 0q�6�   $��20��6�   ��63   �� *Id+6�   �� 5(      $��2��6   $��0��6%   $��0 5 0 0q�65   
���  ����6F   �� *PropertyNamesToErrors[Id]+6q   �� 5*      $��0��6   $��1��6%   $
��Nume��65   $��20 0 0 0q�6A   �� 5+      $��1��6   $��1��6#   $��20 5 0 0q�63   $	��250��6�   $
��Left=�6�   ��6E   �� *Nume+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5,      $��2��6   $��1��6%   $��20 5 0 0q�65   
���  ����6G   �� *PropertyNamesToErrors[Nume]+6t   5-      � 5/   
   $��2��6   $��	0 10 20 0q�6    50      �� 51      $
��auto �6    �� 52      $
��auto �6    �� 53      $
��auto �6     56      �� 57      $
��auto �6#   $ FirstCol��60   �� 58      $
��auto �6#   $ 	SecondCol��60   .+�5;      �� $��0��6   $��0��6%   $	��Tip��65   �� 5<      $��1��6   $��0��6$   $��0 5 0 0q�6n    �� Text 64   �� *Tip+$ PropertyChanged=�.@�5=      �� $��HW��6   �� 5>      $��SW��6   �� 5?      $��HW & SW��6   5@      �� 5A      $��2��6   $��0��6%   $��0 5 0 0q�65   
���  ����6F   �� *PropertyNamesToErrors[Tip]+6r   �� 5C      $��0��6   $��1��6%   $��	Descriere��65   $��20 0 0 0q�6F   �� 5D      $��1��6   $��1��6#   $��20 5 0 0q�63   ��6E   �� *	Descriere+$ PropertyChanged=��� 5E      $��2��6   $��1��6%   $��20 5 0 0q�65   
���  ����6G   �� *" PropertyNamesToErrors[Descriere]+6y   5F      � 5H   
   $��3��6   $��
0 10 20 10q�6    5I      �� 5J      $
��auto �6    �� 5K      $
��auto �6    �� 5L      $
��auto �6     5O      �� 5P      $
��auto �6#   $ FirstCol��60   �� 5Q      $
��auto �6#   $ 	SecondCol��60   .+�5T      �� $��0��6   $��0��6%   $��Data finalizare��65   (  "System.Windows.Controls.DatePicker  5U      $��1��6   $��0��6&      SelectedDate 66   �� *DataFinalizare+$ PropertyChanged=��� 5V      $��2��6   $��0��6%   $��0 5 0 0q�65   
���  ����6F   �� *'%PropertyNamesToErrors[DataFinalizare]+6}   �� 5X      $��0��6   $��1��6%   $��Data actualizare��65   $��20 0 0 0q�6M     5Y      $��1��6   $��1��6&   $��20 0 0 0q�6�    66   �� *DataActualizare+$ PropertyChanged=�6�   �� 5Z      $��2��6   $��1��6%   $��20 5 0 0q�65   
���  ����6G   �� *(&PropertyNamesToErrors[DataActualizare]+6   5[      � 5]   
   $��4��6   $��
0 10 20 10q�6    5^      �� 5_      $
��auto �6    �� 5`      $
��auto �6    �� 5a      $
��auto �6    .+�5d      �� $��0��6   $��Versiune��6%   �� 5e      $��1��6   $	��250��6b   $
��Left=�6n   ��6#   �� *
Versiune+$ PropertyChanged=�6n   �� 5f      $��2��6   $��0 5 0 0q�6%   
���  ����66   �� *!PropertyNamesToErrors[Versiune]+6g   5g      �� 5i   
   $��6��6    �� Orientation$ 
Horizontal=�6"   .+�5j      �� $��	20 0 0 20q�6   	 �� CornerRadius$	 10��6(   $��0q�6:   
�������._�5k      �� $��Salveaza��6   $
��10 5q�5l      ���#2A93D5  AddButtonTheme#��[ 5o      ��5n      �� *SubmitCommand+5o      5p      �� 5q      $��	20 0 0 20q�6   $	 10��6(   $��0q�6:   
�������._�5r      �� $��Anuleaza��6   $
��10 5q�5s      
���  ��  DeleteButtonTheme#��[ 5v      ��5u      �� *CancelCommand+5v      5w      5x      5y      5z      
   M S B A M L   `   `   `  ���� K  GMedSoftDashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:MedSoftDashboard.MVVM.ViewMedSoftDashboard.MVVM.View  .    (MedSoftDashboard.MVVM.View.AddClientView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     :local(clr-namespace:MedSoftDashboard.MVVM.View       � 	Resources   �� 
TargetType �� Property �� Value��%H   '��       �� " ��.���  �@��TextWrapping$ WrapWithOverflow=�.���    DefaultFont#��[   � IsSharedSizeScope$
 True��$��50, 0, 30, 30q�$��15(� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��Adauga client��$��28(�$��	0 0 20 10q�$
��Bold"�� $��1��$��
0 10 20 10q� �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$
��Nume���� $��1��$��0 5 0 0q�$	��300��$
��Left=����� *Nume+ �� UpdateSourceTrigger$ PropertyChanged=��� $��2��$��0 5 0 0q�
���  ������ *PropertyNamesToErrors[Nume]+� $��2��$��	0 0 20 10q� �� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto � z� SharedSizeGroup$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$��Nume Reprezentant���� $��1��$��0��$��0 5 0 0q�	 �� TextWrapping$	 WrapWithOverflow=����� *NumeReprezentant+$ PropertyChanged=��� $��2��$��0��$��0 5 0 0q�
���  ������ *)'PropertyNamesToErrors[NumeReprezentant]+�� $��0��$��1��$��Prenume Reprezentant��$��20 0 0 0q��� $��1��$��1��$��20 5 0 0q����� *PrenumeReprezentant+$ PropertyChanged=��� $��2��$��1��$��20 5 0 0q�
���  ������ *,*PropertyNamesToErrors[PrenumeReprezentant]+� $��3��$��	0 0 20 10q� �� $
��auto ��� $
��auto ��� $
��auto � �� $
��auto �$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$
��Tara���� $��1��$��0��$��0 5 0 0q����� *Tara+$ PropertyChanged=��� $��2��$��0��$��0 5 0 0q�
���  ������ *PropertyNamesToErrors[Tara]+�� $��0��$��1��$��Regiune��$��20 0 0 0q��� $��1��$��1��$��20 5 0 0q����� *	Regiune+$ PropertyChanged=��� $��2��$��1��$��20 5 0 0q�
���  ������ * PropertyNamesToErrors[Regiune]+� $��4��$��	0 0 20 10q� �� $
��auto ��� $
��auto ��� $
��auto � �� $
��auto �$ FirstCol���� $
��auto �$ 	SecondCol��.+��� $��0��$��0��$
��Oras���� $��1��$��0��$��0 5 0 0q����� *Oras+$ PropertyChanged=��� $��2��$��0��$��0 5 0 0q�
���  ������ *PropertyNamesToErrors[Oras]+�� $��0��$��1��$��Adresa��$��20 0 0 0q��� $��1��$��1��$��20 5 0 0q����� *Adresa+$ PropertyChanged=��� $��2��$��1��$��20 5 0 0q�
���  ������ *PropertyNamesToErrors[Adresa]+� $��5��$��0 0 20 0q� �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��Telefon���� $��1��$��0 5 0 0q�$	��300��$
��Left=����� *	Telefon+$ PropertyChanged=��� $��2��$��1��$��0 5 0 0q�
���  ������ * PropertyNamesToErrors[Telefon]+�� $��6��
 �� Orientation$
 
Horizontal=�.+��� $��0 0 0 20q� �� CornerRadius$ 10��$��0q�
�������._��� $��Adauga�����#2A93D5  AddButtonTheme#��[ ���� *SubmitCommand+�� $��	20 0 0 20q�$ 10��$��0q�
�������._��� $��Anuleaza��$
��10 5q�
���  ��  DeleteButtonTheme#��[ ���� *CancelCommand+
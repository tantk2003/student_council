   M S B A M L   `   `   `  ����J  Fstudent_council, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:student_council.Viewsstudent_council.Views  5   	   ,    &student_council.Views.RehearsalsWindow   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:student_council.Views     5   	   X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6;     � Title$#  Мои мероприятия��5   	   $	��750��6!   $
��1000��6.   $
��1000��6;   $	��750��6K   $	��800��6[   $	��600��6k    � WindowStartupLocation$ CenterScreen=�6z   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��64* �6   �� 5      $
��303* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $	��128��6a   $
��1000��6n   ���#1C1594.+�5      �� $��..\Resources\logo.png��6   $��30 0 0 0q�63   6G   5      �� 5   
   -   5         ��Name$ 
btn_cansel��5   !   $��
Назад��6    �� IsCancel .    button_exit#��[  6^   6�   ]� 5   
   $��2��6   .+�5      �� $"��Дата репетиции:��6     	textblock#��[ 6/   $��30��6R   $	��200��6^   $
��Left=�6j   $	��Top=�6�   $��	60 80 0 0q�6�   &   Xceed.Wpf.Toolkit.DateTimePicker  5      -   5          Name$ dpicker_date��5   "   $��30��68   $	��300��6D   $
��Left=�6P   $	��Top=�6k   $��-200 110 0 0q�6�   6�   5      �� 5   
   $ Vertical=�6   $��1��6,   $��Right=�69   $��Center=�6U   $��0 -100 30 0 q�6p   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridUsers��5        	data_grid#��[ 6+      SelectionMode$ Extended=�6N   	   
IsReadOnly	 . 
   AutoGenerateColumns
 .  $	��500��6�   $	��270��6�   $��0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	surname+6V     5      $ Имя��6)   $	 100 6O    66   �� *name+6O     5      $ Отчество��6)   $	 120 6Z    6;   �� *
patronymic+6Z   5      �� 5      -   5        $ btn_create_record��5   2   $)��#Добавить репетицию��6    �� 	IsDefault . $
��Left=�6_   $	��230��6�   $��40��6�   $��0 30 0 0q�6�    
 button#��[ 6�   5      5       5!      5"      
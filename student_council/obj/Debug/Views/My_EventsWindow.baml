   M S B A M L   `   `   `  ����J  Fstudent_council, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:student_council.Viewsstudent_council.Views  5   	   +    %student_council.Views.My_EventsWindow   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:student_council.Views     5   	     � Title$#  Мои мероприятия��5   	   $	��750��6!   $
��1000��6.   $
��1000��6;   $	��750��6K   $	��800��6[   $	��600��6k    � WindowStartupLocation$ CenterScreen=�6z   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��64* �6   �� 5      $
��303* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $	��128��6a   $
��1000��6n   ���#1C1594.+�5      �� $��..\Resources\logo.png��6   $��30 0 0 0q�63   6G   5      �� 5   
   -   5         ��Name$ btn_exit��5   !   $��
Назад��6    �� IsCancel .    button_exit#��[  6Z   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridMyEvents��5      $��1��6*     	data_grid#��[ 67      AutoGenerateColumns .     
IsReadOnly . $��	0,100,0,0q�6�   $
��auto��6�   	 � 	Resources	 5        wordWrapStyle
 �� 
TargetType �� Property �� Value��%y   &	       �� 5      "
 ��6.   .�5      ��  � ��$
 Wrap=�65   �� 5       � ��$	 200��61   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   -   5        column_name��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   L   �� *Expr1+6h     5      $# Дата проведения��6%   -   5        column_date�� 5   S   �� *date+ �� StringFormat$ dd.MM.yyyy HH:mm��6�     5      $ Статус��6%   -   5        column_status�� 5   L   �� *name_status+6n   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5       �� $ btn_cancel_record��6%   -   5          btn_grid#��[ 5    b   $��Отмена записи��6�   	 5!   "   ��%c   '��       �� 5"   &   "
 ��6,   .�5#   *   ��  �@��CornerRadius$ 5��6I   6U   5$   '   5%   #   5&      5'      5)      5+      5,      5-      
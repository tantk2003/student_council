   M S B A M L   `   `   `  ����J  Fstudent_council, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:student_council.Viewsstudent_council.Views  5   	   /    )student_council.Views.Enter_HistoryWindow   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:student_council.Views     5   	     � Title$  История входа��5   	   $	��750��6   $
��1000��6,   $
��1000��69   $	��750��6I   $	��800��6Y   $	��600��6i    � WindowStartupLocation$ CenterScreen=�6x   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��64* �6   �� 5      $
��303* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $	��128��6a   $
��1000��6n   ���#1C1594.+�5      �� $��..\Resources\logo.png��6   $��30 0 0 0q�63   6G   5      �� 5   
   -   5         ��Name$ btn_back��5   !   $��
Назад��6    �� IsCancel .    button_exit#��[  6Z   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DGridEnter��5      $��1��6'     	data_grid#��[ 64      AutoGenerateColumns .     
IsReadOnly . $	��427��6�   $	��408��6�   $��	0,120,0,0q�6�   	 � 	Resources	 5        wordWrapStyle
 �� 
TargetType �� Property �� Value��%y   &	       �� 5      "
 ��6.   .�5      ��  � ��$
 Wrap=�65   �� 5       � ��$	 200��61   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   -   5        column_surname��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   N   �� *login+6j     5      $ Отчество��6%   -   5        column_enter_date�� 5   R   �� *
enter_date+ �� StringFormat$ {0:dd/MM/yyyy hh:mm:ss}��6�     5      $ Номер группы��6%   -   5        column_name_status�� 5   W   �� *name_status+6y   5      5      5       
   M S B A M L   `   `   `  ����J  Fstudent_council, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:student_council.Viewsstudent_council.Views  5   	   '    !student_council.Views.PostsWindow   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:student_council.Views     5   	     � Title$  Должности��5   
   $	��750��6   $
��1000��6)   $
��1000��66   $	��750��6F   $	��800��6V   $	��600��6f    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $	��64* �6   �� 5      $
��303* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $	��128��6a   $
��1000��6n   ���#1C1594.+�5      �� $��..\Resources\logo.png��6   $��30 0 0 0q�63   6G   5      �� 5   
   -   5         ��Name$ btn_exit��5   !   $��
Назад��6    �� IsCancel .    button_exit#��[  6Z   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DGridPosts��5      $��1��6'     	data_grid#��[ 64      AutoGenerateColumns .     
IsReadOnly . $��0,50,0,0q�6�   $
��auto��6�   $y�Visible=�6�   	 � 	Resources	 5        wordWrapStyle
 �� 
TargetType �� Property �� Value��%y   &	       �� 5      "
 ��6.   .�5      ��  � ��$
 Wrap=�65   �� 5       � ��$	 200��61   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   -   5        column_surname��1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   N   �� *	surname+6l     5      $ Имя��6%   -   5        column_name�� 5   G   �� *name+6b     5      $ Отчество��6%   -   5        column_patronimic�� 5   R   �� *
patronymic+6s     5      $ Должность��6%   -   5        column_post�� 5   M   �� *	name_post+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5         Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6)      CellTemplate 5       �� 5!      .R�5"      �� $ btn_add_post��6%   -   5          btn_grid#��[ 5"   W   $)��#Добавить должность��6y   {�. 	 5#   "   ��%c   '��       �� 5$   &   "
 ��6,   .�5%   *   ��  �@��CornerRadius$ 5��6I   6U   5&   '   5'   #   5(      5)      5+        5,      $
 auto 6)    5-      �� 5.      .R�5/      �� $ btn_delete_post��6%   -   5        #��[ 5/   ]   $%��Убрать должность��6   {�. 	 50   "   ��%c   '��       �� 51   &   "
 ��6,   .�52   *   ��  �@��CornerRadius$ 5��6I   6U   53   '   54   #   55      56      58      5:      �� 5;   
   -	   5         ��Name$ spanel_post��5;      $��1��6*   $	��450��67   $	��400��6C   $y�Hidden=�6P   .+�5<      ��   textblock_header#��[ 6   $��40��6B   $-��'Добавление должности��6N   $	��350��6j   6x   �� 5=      -
   5         ��Name$ tblock_surname��5=      #��[ 60   $��40��6Z   $��
-60 10 0 0q�6f   $	��350��6z   6�   �� 5>      -   5        $ tblock_name��5>      #��[ 6-   $��40��6W   $��
-60 10 0 0q�6c   $	��350��6w   6�   �� 5?      -   5        $ tblock_patronymic��5?      #��[ 63   $��40��6]   $��
-60 10 0 0q�6i   $	��350��6}   6�   �� 5@      -   5         ��Name$ cbox_free_post��5@        cbox_direct#��[ 6/    �� DisplayMemberPath$ 	name_post��6T   $��0 10 0 0q�6r   $	��390��6�   $��40��6�   6�   �� 5A      -   5        $ btn_add_post_user��5A   4   $	��171��6   $��Добавить��6!    
 button#��[ 6o   $��50��6�   $��0 40 0 0q�6�   6�   5B      5C      5D      
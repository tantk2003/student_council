   M S B A M L   `   `   `  ����J  Fstudent_council, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:student_council.Viewsstudent_council.Views  5   	   .    (student_council.Views.Create_EventWindow   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:student_council.Views     5   	   X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6;     � Title$  Create_EventWindow��5   	   $	��750��6$   $
��1000��61   $
��1000��6>   $	��750��6N   $	��800��6^   $	��600��6n    � WindowStartupLocation$ CenterScreen=�6}   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��64* �6   �� 5      $
��303* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $	��128��6a   $
��1000��6n   ���#1C1594.+�5      �� $��..\Resources\logo.png��6   $��30 0 0 0q�63   6G   5      �� 5   
   -   5         ��Name$ btn_back��5   !   $��
Назад��6    �� IsCancel .    button_exit#��[  6Z   6�   �� 5   
   $��1��6   $ Vertical=�6"   $��250,49,240,10q�69   .+�5      �� $��35��6   $.��(Выберите направление:��6$     textblock_event#��[ 6A   6l   �� 5      -   5         ��Name$ cbox_direction��5      $	��500��6/     cbox_direct#��[ 6;    �� DisplayMemberPath$
 name��6`   6|   �� 5      $��35��6   $6��0Наименование мероприятия:��6$   #��[ 6E   6p   �� 5      -   5         ��Name$ 	tbox_name��5   "   $��40��6     textbox_event#��[ 65   6�   �� 5      $��Описание:��6   #��[ 6)   6T   �� 5      -   5        $ tbox_description��5   "   $��90��6   	 �� TextWrapping$
	 Wrap=�6<   #��[ 6�   �� 5      $$��Дата проведения:��6   #��[ 60   6[   &   Xceed.Wpf.Toolkit.DateTimePicker  5      -   5        
  Name$
 dpicker_date��5   "   $	��500��68   6G   �� 5      $��Для кого:��6   #��[ 6)   6T   �� 5      -   5        $ cbox_destiny��5      $	��500��6-   #��[ 69   $ name_distiny��6^   6�   �� 5      $$��Количество мест:��6   #��[ 60   6[   �� 5      -   5        $ tbox_num_place��5   "   $��30��6   #��[ 6:   $	��500��6�   6�   �� 5      -   5        $ btn_add_event��5   4   $	��171��6   $��Добавить��6!    �� 	IsDefault .  
 button#��[ 6x   $��41��6�   $��0 15 0 0q�6�    � 	Resources 5        �� 
TargetType �� Property �� Value��%c   '��       �� 5!      " ��6   .�5"      ��  �@��CornerRadius$ 5��69   6E   5#      5$      5%      5&      5'      5(      
   M S B A M L   `   `   `  ����J  Fstudent_council, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:student_council.Viewsstudent_council.Views  5   	   /    )student_council.Views.Registration_Window   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:student_council.Views     5   	     � Title$  Регистрация��5   	   $	��800��6   $	��600��6*   $	��800��66   $	��600��6F   $	��800��6U   $	��600��6e    � WindowStartupLocation$ CenterScreen=�6t   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��101* �6   �� 5      $
��291* �6   .+�5   
   �� $��0��6   $��../Resources/header.png��6   $��0,-2,0,2q�6>   6R   �� 5   
   $��1��6   $	��370��6"   $	��520��6.   $
��Left=�6;   $	��Top=�6V   $��
110 20 0 0q�6n   .+�5      �� $��Регистрация��6      textblock_header#��[  6+   6W   �� 5      $��Имя:��6     textblock_all#��[ 6$   6M   �� 5      -   5         ��Name$ name_reg��5        textbox#��[ 6(   6I   �� 5      $��Фамилия:��6   #��[ 6(   6Q   �� 5      -   5        $ surname_reg��5      #��[ 6+   6L   �� 5      $��Отчество:��6   #��[ 6)   6R   �� 5      -   5        $ patronmic_reg��5      #��[ 6-   6N   �� 5      $��Факультет:��6   #��[ 6*   6S   �� 5      -   5         ��Name$ faculty_reg��5        cbox_faculty#��[ 6,    �� DisplayMemberPath$ name_faculty��6R   6u   �� 5      $��Группа:��6   #��[ 6'   6P   �� 5      -   5        $ numgroup_reg��5      #��[ 6,   6M   �� 5       $��Email:��6   #��[ 6&   6O   �� 5!      -   5        $ 	email_reg��5!      #��[ 6)   6J   �� 5#      $��Логин:��6   #��[ 6&   $
��Left=�6M   $��	20 10 0 0q�6h   6}   �� 5$      -   5        $ 	login_reg��5$      #��[ 6)   6J   �� 5&      $��Пароль:��6   #��[ 6'   $
��Left=�6N   $��	20 10 0 0q�6i   6~   �� 5'      -   5        $ password_reg��5'      #��[ 6,   6M   �� 5)      -	   5         ��Name$ 
btn_signup��5)   J   $	��200��6   $��35��6!   $*��$Зарегистрироваться��6-    �� 	IsDefault . $��-130 15 0 0q�6�    
 button#��[ 6�    � 	Resources 5*      	 �� 
TargetType
 �� Property �� Value��%c   '��       �� 5+      "	 ��6   .�5,      �� 
 �@��CornerRadius$ 5��69   6E   5-      5.      5/      �� 50      -
   5        $ btn_back��50   =   $	��100��6   $��35��6!   $��
Назад��6-    �� IsCancel . $��200 -35 0 0q�6v   #��[ 6�    51      ��%c   '��       �� 52      "	 ��6   .�53      �� 
 �@��CornerRadius$ 5��69   6E   54      55      56      57      58      59      
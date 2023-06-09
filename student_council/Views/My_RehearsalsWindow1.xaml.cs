﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace student_council.Views
{
    /// <summary>
    /// Логика взаимодействия для My_RehearsalsWindow1.xaml
    /// </summary>
    public partial class My_RehearsalsWindow1 : Window
    {
        public My_RehearsalsWindow1(users user)
        {
            InitializeComponent();
            DGridMyRehearsals.ItemsSource = student_council_kitEntities.GetContext().creater_rehearsal_View.Where(x => (x.id_user == user.id_user)).ToList();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow (AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }
        
        private void DGridDirections_AutoGeneratedColumns(object sender, EventArgs e)
        {
            foreach (DataGridColumn column in DGridMyRehearsals.Columns)
            {
                if (column is DataGridTextColumn)
                {
                    DataGridTextColumn textColumn = column as DataGridTextColumn;
                    Style style = DGridMyRehearsals.Resources["wordWrapStyle"] as Style;
                }
            }
        }
    }
}
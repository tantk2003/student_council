﻿using student_council.Controllers;
using System;
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
    /// Логика взаимодействия для Direction_RecordWindow.xaml
    /// </summary>
    public partial class Direction_RecordWindow : Window
    {
        public Direction_RecordWindow(users user)
        {
            InitializeComponent();
            DGridDirections.ItemsSource = student_council_kitEntities.GetContext().directions.ToList();
        }

        private void btn_direct_record_Click(object sender, RoutedEventArgs e)
        {
            var selectedDirection = DGridDirections.SelectedItems.Cast<directions>().ToList();
            if (Manipulation_BD.AddDirectionParticipant(selectedDirection, AutorizationWindow.user))
            {
                MessageBox.Show("Вы успешно записаны");
            }
            else
            {
                MessageBox.Show("Вы уже записаны в данное направление!");
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Personal_AccountWindow personal_AccountWindow = new Personal_AccountWindow(AutorizationWindow.user);
            Hide();
            personal_AccountWindow.Show();
        }

        private void DGridDirections_AutoGeneratedColumns(object sender, EventArgs e)
        {
            foreach (DataGridColumn column in DGridDirections.Columns)
            {
                if (column is DataGridTextColumn)
                {
                    DataGridTextColumn textColumn = column as DataGridTextColumn;
                    Style style = DGridDirections.Resources["wordWrapStyle"] as Style;
                }
            }
        }
    }
}
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YchPr_KornilovaVaravra320.DB;

namespace YchPr_KornilovaVaravra320.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Employee> employee { get; set; }
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void discipl_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DisciplinesPages());
        }

        private void login_Btn_Click(object sender, RoutedEventArgs e)
        {
            //string login = Convert.ToString();
            //string password;
        }
    }
}
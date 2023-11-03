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

namespace YchPr_KornilovaVaravra320.Windows
{
    /// <summary>
    /// Логика взаимодействия для DeliteStudentWindow.xaml
    /// </summary>
    public partial class DeliteStudentWindow : Window
    {
        public DeliteStudentWindow()
        {
            InitializeComponent();
        }

        private void net_btn_Click(object sender, RoutedEventArgs e)
        {
            DeliteStudentWindow deliteStudentWindow = new DeliteStudentWindow();
            this.Close();


        }
    }
}

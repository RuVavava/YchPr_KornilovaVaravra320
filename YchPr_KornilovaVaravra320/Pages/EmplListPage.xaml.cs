using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для EmplListPage.xaml
    /// </summary>
    public partial class EmplListPage : Page
    {
        public static List<Employee> employee { get; set; }

        public EmplListPage()
        {            
            InitializeComponent();
            oobzor_empl_list.ItemsSource = DbConnection.YchebnPraktika_Kornilova320Entities.Employee.ToList();
            TB_Name_Eng.Text = DbConnection.loginpassUser.FIO;

            this.DataContext = this;
        }
    }
}

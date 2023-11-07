using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
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
    /// Логика взаимодействия для DepartmentListPage.xaml
    /// </summary>
    public partial class DepartmentListPage : Page
    {
        public static List<Department> DepartmentList = new List<Department>();
        public static List<Employee> employees { get; set; }
        public DepartmentListPage()
        {
            InitializeComponent();
            oobzor_department_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Department.Where(i => i.Cipher == DB.DbConnection.loginpassUser.Cipher).ToList();
            TB_Name_ZavDep.Text = DB.DbConnection.loginpassUser.FIO;
            this.DataContext = this;
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e) //Кнопка назад
        {
            NavigationService.Navigate(new Pages.AuthorizationPage());
        }

        private void oobzor_department_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (oobzor_department_list.SelectedItem is Department department)
            {
                oobzor_department_list.SelectedItem = null;
                NavigationService.Navigate(new AddDisciplineDep(department));
            }
        }
    }
}

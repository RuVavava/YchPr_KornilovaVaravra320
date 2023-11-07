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
            int login = Convert.ToInt32(login_Tb.Text.Trim());
            string password = Convert.ToString(password_Tb.Password.Trim());

            var employee = DbConnection.YchebnPraktika_Kornilova320Entities.Employee.ToList();
            var curretempl = employee.FirstOrDefault(i => i.Num_emp == login && i.Password == password);
            DbConnection.loginpassUser = curretempl;
            
            if (curretempl != null && curretempl.Post == "преподаватель")
                NavigationService.Navigate(new ExamlistPages());
            else if (curretempl != null && curretempl.Post == "зав. кафедрой")
                NavigationService.Navigate(new DepartmentListPage());
            else if (curretempl != null && curretempl.Post == "инженер")
                NavigationService.Navigate(new EmplListPage());
            else
                MessageBox.Show("Введенные данные некорректны!");
        }
    }
}

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

        private void Refresh() //Обновление листа
        {
            oobzor_empl_list.ItemsSource = DbConnection.YchebnPraktika_Kornilova320Entities.Employee.ToList();
        }

        private void delite_Empl_btn_Click(object sender, RoutedEventArgs e) //Удаление сотрудника
        {
            if (oobzor_empl_list.SelectedItem is Employee employee)
            {
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Employee.Remove(employee);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
                Refresh();
            }
        }

        private void oobzor_empl_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Empl_btn_Click(object sender, RoutedEventArgs e) //Добавление сотрудника, переход на другую страницу
        {
            NavigationService.Navigate(new Pages.AddEmplPagexaml());
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AuthorizationPage());
        }

        private void Edd_Empl_btn_Click(object sender, RoutedEventArgs e)
        {
            if (oobzor_empl_list.SelectedItem is Employee employee)
            {
                oobzor_empl_list.SelectedItem = null;
                NavigationService.Navigate(new EddEmplPage(employee));
                Refresh();
            }

        }
    }
}

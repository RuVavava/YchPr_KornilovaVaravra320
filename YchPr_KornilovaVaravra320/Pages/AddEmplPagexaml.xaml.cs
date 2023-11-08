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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YchPr_KornilovaVaravra320.DB;

namespace YchPr_KornilovaVaravra320.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEmplPagexaml.xaml
    /// </summary>
    public partial class AddEmplPagexaml : Page
    {
        public static List<Employee> employees { get; set; }
        public static List<Department> departments { get; set; }
        public AddEmplPagexaml()
        {
            departments = new List<Department>(DB.DbConnection.YchebnPraktika_Kornilova320Entities.Department.ToList());
            InitializeComponent();
            this.DataContext = this;
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.EmplListPage());
        }

        private void Save_Empl_btn_Click(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee();

            if(emp != null)
            {
                string postt = " ";
                var TBpost = Cb_Post.SelectedValue as TextBlock;
                if (TBpost != null)
                    postt = TBpost.Text;

                var dep = Cb_depa_Empl.SelectedItem as Department;
                var post = Cb_Post.SelectedItem;
                emp.Num_emp = Convert.ToInt16(TB_login.Text);
                emp.Cipher = dep.Cipher;
                emp.FIO = TB_FIO.Text;
                emp.Post = Convert.ToString(postt);
                emp.Salary = decimal.Parse(TB_Salary.Text);
                emp.Chief = Convert.ToInt16(TB_Cipher.Text);
                emp.Password = TB_password.Text;
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Employee.Add(emp);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
                NavigationService.Navigate(new Pages.EmplListPage());
            }

        }
    }
}

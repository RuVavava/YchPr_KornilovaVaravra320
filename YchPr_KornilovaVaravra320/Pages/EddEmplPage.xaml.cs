using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Логика взаимодействия для EddEmplPage.xaml
    /// </summary>
    public partial class EddEmplPage : Page
    {
        public static List<Employee> employees { get; set; }
        public static List<Department> departments { get; set; }
        public static Employee emp_edd { get; set; }
        Employee context_emp;
        public EddEmplPage(Employee employee)
        {
            InitializeComponent();
            departments = new List<Department>(DB.DbConnection.YchebnPraktika_Kornilova320Entities.Department.ToList());
            context_emp = employee;
            emp_edd = employee;
            Cb_depa_Empl_edd.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Department.ToList();
            employees = new List<Employee>
                (DB.DbConnection.YchebnPraktika_Kornilova320Entities.Employee.ToList());
            this.DataContext = this;
        }

        private void Save_Empl_btn_edd_Click(object sender, RoutedEventArgs e)
        {
            var error = string.Empty;
            var validationContext = new ValidationContext(context_emp);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

            if (Validator.TryValidateObject(context_emp, validationContext, results, true))
            {
                foreach (var result in results)
                {
                    error += $"{result.ErrorMessage}\n";
                }
            }
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }

            if (context_emp.Num_emp == 0)
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Employee.Add(context_emp);
            DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
            NavigationService.GoBack();
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

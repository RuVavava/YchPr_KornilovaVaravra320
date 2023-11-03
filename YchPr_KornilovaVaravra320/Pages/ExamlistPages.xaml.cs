using System;
using YchPr_KornilovaVaravra320.DB;
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
using System.Data.Common;

namespace YchPr_KornilovaVaravra320.Pages
{
    /// <summary>
    /// Логика взаимодействия для ExamlistPages.xaml
    /// </summary>
    public partial class ExamlistPages : Page
    {
        public static List<Exam> exam { get; set; }
        public static List<Discipline> disciplines { get; set; }
        public ExamlistPages()
        {
            InitializeComponent();
            TB_User.Text = DB.DbConnection.loginpassUser.FIO;
            oobzor_exam_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Exam.
                Where(i => i.Num_emp == DB.DbConnection.loginpassUser.Num_emp).ToList();
            this.DataContext = this;
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AuthorizationPage());
        }

        private void oobzor_exam_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (oobzor_exam_list.SelectedItem is Exam exam)
            {
                oobzor_exam_list.SelectedItem = null;
                NavigationService.Navigate(new ExamListAddStudentPage(exam));
            }
        }
    }
}

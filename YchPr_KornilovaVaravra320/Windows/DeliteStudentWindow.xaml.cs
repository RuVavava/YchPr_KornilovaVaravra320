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
using YchPr_KornilovaVaravra320.Pages;

namespace YchPr_KornilovaVaravra320.Windows
{
    /// <summary>
    /// Логика взаимодействия для DeliteStudentWindow.xaml
    /// </summary>
    /// 
    public partial class DeliteStudentWindow : Window
    {
        public static List<Exam> exam { get; set; }
        public static List<Discipline> disciplines { get; set; }
        public static List<Student> students { get; set; }
        public DeliteStudentWindow()
        {
            InitializeComponent();
        }

        private void net_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void da_btn_Click(object sender, RoutedEventArgs e)
        {
            ////var st = DbConnection.YchebnPraktika_Kornilova320Entities.
            //Exam exam = DbConnection.YchebnPraktika_Kornilova320Entities.Exam.Where(i => i.ID_d).FirstOrDefault();
            //DbConnection.YchebnPraktika_Kornilova320Entities.Exam.Remove(exam);
            //DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
            //this.Close();
        }
    }
}

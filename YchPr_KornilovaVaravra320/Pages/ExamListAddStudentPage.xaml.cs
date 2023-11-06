using System;
using System.Collections.Generic;
using System.Data.Common;
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
using YchPr_KornilovaVaravra320.Windows;

namespace YchPr_KornilovaVaravra320.Pages
{
    /// <summary>
    /// Логика взаимодействия для ExamListAddStudentPage.xaml
    /// </summary>
    public partial class ExamListAddStudentPage : Page
    {
        public static List<Exam> exam { get; set; }
        public static List<Student> students { get; set; }
        public static List<Discipline> disciplines { get; set; }
        Exam contextExam;
        
        private Window currentDialog = null;
        public ExamListAddStudentPage(Exam exam)
        {
            InitializeComponent();
            contextExam = exam;
            oobzor_student_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Exam.
                Where(i => i.Date_e == contextExam.Date_e && i.ID_d == contextExam.ID_d).ToList();
            TB_DateE.Text = Convert.ToString(contextExam.Date_e);
            TB_NameE.Text = Convert.ToString(contextExam.Discipline.Name_disc);
            InitializeDataInPage();
            students = new List<Student>
                (DB.DbConnection.YchebnPraktika_Kornilova320Entities.Student.ToList());
            this.DataContext = this;
        }

        private void InitializeDataInPage()
        {
            Cb_students.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Student.ToList();
            students = new List<Student>
                (DB.DbConnection.YchebnPraktika_Kornilova320Entities.Student.ToList());
            exam = new List<Exam>(DB.DbConnection.YchebnPraktika_Kornilova320Entities.Exam.
                Where(i => i.Date_e == contextExam.Date_e && i.ID_d == contextExam.ID_d).ToList());
        }


        private void back_authpage_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.ExamlistPages());
        }

        private void Refresh()
        {
            oobzor_student_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Exam.
                Where(i => i.Date_e == contextExam.Date_e && i.ID_d == contextExam.ID_d).ToList();
        }

        private void delite_btn_Click(object sender, RoutedEventArgs e) //Кнопка удаления студента
        {
            if (oobzor_student_list.SelectedItem is Exam exam)
            {
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Exam.Remove(exam);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
                Refresh();
            }
        }

        private void Btn_AddStudent_Click(object sender, RoutedEventArgs e)
        {
            string grate = "2";
            var TBmark = Cb_Mark.SelectedValue as TextBlock;
            if (TBmark != null)
                grate = TBmark.Text;
            if (Cb_students.SelectedItem is Student student)
            {
                var exams = contextExam;
                exams.Student = student;
                exams.Grade = int.Parse(grate);
                var oobzor_student_list = exam.FirstOrDefault(x => x.Reg_num == student.Reg_num);
                if (oobzor_student_list != null)
                {
                    MessageBox.Show("Такой студент уже есть в экзамене");
                    return;
                }
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Exam.Add(exams);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
                Refresh();
            }
        }
    }
}

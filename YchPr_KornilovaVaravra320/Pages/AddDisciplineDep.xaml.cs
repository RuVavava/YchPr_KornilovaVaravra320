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
    /// Логика взаимодействия для AddDisciplineDep.xaml
    /// </summary>
    public partial class AddDisciplineDep : Page
    {
        public static List<Discipline> disciplines { get; set; }
        public static List<Department> department { get; set; }
        Department contectdep;
        public AddDisciplineDep(Department department)
        {
            contectdep = department;
            InitializeComponent();
            InitializeDataInPage();
            this.DataContext = this;
        }

        private void InitializeDataInPage()
        {
            department = new List<Department>(DB.DbConnection.YchebnPraktika_Kornilova320Entities.Department.
                Where(i => i.Name_dep == contectdep.Name_dep).ToList());
            oobzor_disc_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.
                Where(i => i.Cipher == contectdep.Cipher).ToList();
            TB_Name_Depart.Text = Convert.ToString(contectdep.Name_dep);
            disciplines = new List<Discipline>
                (DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.ToList());
        }
        private void Refresh() //Обновление листа
        {
            oobzor_disc_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.
                            Where(i => i.Cipher == contectdep.Cipher).ToList();
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e) //Кнопка назад
        {
            NavigationService.Navigate(new Pages.DepartmentListPage());
        }


        private void Btn_Add_disc_Click(object sender, RoutedEventArgs e)
        {
            Discipline disc = new Discipline();

            if(Cb_disc.SelectedItem is Discipline disciplines)
            {
                var d = Cb_disc.SelectedItem as Discipline;
                disc.Name_disc = d.Name_disc;
                disc.Size = Convert.ToInt32(TB_Size.Text);
                disc.Cipher = contectdep.Cipher;
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.Add(disc);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
                Refresh();
                InitializeDataInPage();

            }
        }



        private void delite_disc_btn_Click(object sender, RoutedEventArgs e)
        {
            if (oobzor_disc_list.SelectedItem is Discipline discipline)
            {
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.Remove(discipline);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
                InitializeDataInPage();
                Refresh();
            }
        }

        private void oobzor_disc_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void edd_disc_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.DisciplineEdd());
        }
    }
}

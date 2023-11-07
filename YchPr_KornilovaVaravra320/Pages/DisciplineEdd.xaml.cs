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
    /// Логика взаимодействия для DisciplineEdd.xaml
    /// </summary>
    public partial class DisciplineEdd : Page
    {
        public static List<Discipline> disciplines { get; set; }
        public static List<Department> department { get; set; }
        Discipline contextdisc;
        public DisciplineEdd()
        {
            InitializeComponent();
            disciplines = new List<Discipline>
                (DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.ToList());
            this.DataContext = this;
        }

        private void Otmena_disc_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Btn_Save_disc_Click(object sender, RoutedEventArgs e)
        {

            int ymolch_size = 60;

            if (Cb_edd_disc.SelectedItem is Discipline disciplines)
            {
                var d = contextdisc;
                var vib = Cb_edd_disc.Text;
                d.Name_disc = vib;
                d.Size = ymolch_size;
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();

            }
        }
    }
}

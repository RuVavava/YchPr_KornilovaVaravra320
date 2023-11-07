using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace YchPr_KornilovaVaravra320.Pages
{
    /// <summary>
    /// Логика взаимодействия для DisciplineEdd.xaml
    /// </summary>
    public partial class DisciplineEdd : Page
    {
        public static List<Discipline> disciplines { get; set; }
        public static List<Department> department { get; set; }
        public static Discipline disc { get; set; }
        Discipline contextdisc;
        public DisciplineEdd(Discipline discipline)
        {
            InitializeComponent();
            contextdisc = discipline;
            disc = discipline;
            Cb_edd_disc.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.ToList();
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

            var error = string.Empty;
            var validationContext = new ValidationContext(contextdisc);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();

            if (Validator.TryValidateObject(contextdisc, validationContext, results, true))
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

            if (contextdisc.ID_d == 0)
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.Add(contextdisc);
                DB.DbConnection.YchebnPraktika_Kornilova320Entities.SaveChanges();
            NavigationService.GoBack();

        }
    }
}

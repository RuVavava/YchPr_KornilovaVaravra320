using System;
using YchPr_KornilovaVaravra320.DB;
using System.Collections.Generic;
using System.Linq;
using System.Data.Common;
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

namespace YchPr_KornilovaVaravra320.Pages
{
    /// <summary>
    /// Логика взаимодействия для DisciplinesPages.xaml
    /// </summary>
    public partial class DisciplinesPages : Page
    {
        public static List<Discipline> disciplines { get; set; }
        public DisciplinesPages()
        {
            InitializeComponent();
            oobzor_discipl_list.ItemsSource = DB.DbConnection.YchebnPraktika_Kornilova320Entities.Discipline.ToList();
            this.DataContext = this;
        }

        private void back_authpage_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AuthorizationPage());
        }
    }
}

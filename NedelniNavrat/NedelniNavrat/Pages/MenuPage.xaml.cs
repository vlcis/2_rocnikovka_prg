using NedelniNavrat.messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace NedelniNavrat.Pages
{
    /// <summary>
    /// Interakční logika pro MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();


        }
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LivingRoom());
        }

        private void PripravujemeProVas(object sender, RoutedEventArgs e)
        {
            new PripravujemeProVas().ShowDialog();
            //MessageBox.Show("Tato funkce je připravována pro vás, zůstaňte naladěni!");
        }
    }
}

using NedelniNavrat.messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interakční logika pro hall.xaml
    /// </summary>
    public partial class hall : Page
    {
        public hall()
        {
            InitializeComponent();
        }

        private void DvereObyvak(object sender, EventArgs e)
        {
            NavigationService.Navigate(new LivingRoom());
        }

        private void DvereKuchyn(object sender, RoutedEventArgs e)
        {
            if (Inventory.klicKuchyn == true)
            {
                NavigationService.Navigate(new kitchen());
            }
            else
            {
                new Zamceno().ShowDialog();
            }
        }

        private void Zamceno(object sender, RoutedEventArgs e)
        {
            new Zamceno().ShowDialog();
        }

        private void DvereVchod(object sender, RoutedEventArgs e)
        {
            DvereVchod karel = new DvereVchod();
            karel.ShowDialog() ;
            if(karel.isValid == true)
            {
                NavigationService.Navigate(new Vitezstvi());
            }
        }

        private void Ridicak(object sender, RoutedEventArgs e) {
            
            new Ridicak().ShowDialog();
        }

        private void KliceKuchyn(object sender, RoutedEventArgs e)
        {
            if (Inventory.klicKuchyn == false)
            {
                Inventory.klicKuchyn = true;
                new Nasel_klic_kuchyn().ShowDialog();
            }
            else
            {
                new Tady_nic().ShowDialog();
            }
        }

        private void ZatimNic(object sender, RoutedEventArgs e)
        {
            new Tady_nic().ShowDialog();
        }
    }
}

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
using System.Windows.Shapes;

namespace NedelniNavrat.messages
{
    /// <summary>
    /// Interakční logika pro Skrinka6.xaml
    /// </summary>
    public partial class Skrinka6 : Window
    {
        public Skrinka6()
        {
            InitializeComponent();
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

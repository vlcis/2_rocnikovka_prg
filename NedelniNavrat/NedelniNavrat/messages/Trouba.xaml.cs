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
    /// Interakční logika pro trouba.xaml
    /// </summary>
    public partial class Trouba : Window
    {
        public Trouba()
        {
            InitializeComponent();
        }

        private void Ne(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ano(object sender, EventArgs e)
        {
            new VzkazTrouba().ShowDialog();
            this.Close();
        }
    }
}

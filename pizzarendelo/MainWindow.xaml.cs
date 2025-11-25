using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pizzarendelo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void btnRendeles_Click(object sender, RoutedEventArgs e)
		{
			string teszta = (lstTesztak.SelectedItem as ListBoxItem)?.Content.ToString() ?? "nincs kiválasztva";
			string meret = (cmbMeret.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "nincs kiválasztva";
			string feltetek = "";

			if (chkSajt.IsChecked == true) feltetek += "Sajt, ";
			if (chkSonka.IsChecked == true) feltetek += "Sonka, ";
			if (chkGomba.IsChecked == true) feltetek += "Gomba, ";
			if (chkOliva.IsChecked == true) feltetek += "Olívabogyó, ";
			if (chkKukorica.IsChecked == true) feltetek += "Kukorica, ";
			if (feltetek.EndsWith(", ")) feltetek = feltetek.Substring(0, feltetek.Length - 2);
			if (string.IsNullOrEmpty(feltetek)) feltetek = "nincs feltét";
		}
	}
}
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

namespace helloWorld
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			label.Content = "Hello World";
			label.Background = Brushes.LightBlue;
            label.Background = Brushes.Red;
	    label.Visibility = Visibility.Visible;
	    //Kommentar
        //kommentar Nr21
	
	//MEINE ÄNDERUNG
	//Server
		}
	}
}

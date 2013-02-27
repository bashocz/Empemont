using System;
using System.Collections.Generic;
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

namespace Empemont
{
	/// <summary>
	/// Interaction logic for AddPage1.xaml
	/// </summary>
	public partial class WindowPageMicrophone : UserControl
	{
        bool isStart = false;

		public WindowPageMicrophone()
		{
			this.InitializeComponent();

            ButtonStart.Click += new RoutedEventHandler(ButtonStart_Click);
		}

        private void ButtonStart_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            if (isStart)
            {
                ButtonStart.Foreground = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
                ButtonStart.Content = "START";
            }
            else
            {
                ButtonStart.Foreground = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
                ButtonStart.Content = "STOP";
            }
            isStart = !isStart;
        }
	}
}
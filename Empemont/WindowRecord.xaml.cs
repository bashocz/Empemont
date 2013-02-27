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
using System.Windows.Shapes;

namespace Empemont
{
	/// <summary>
	/// Interaction logic for AddWindow.xaml
	/// </summary>
	public partial class WindowRecord : Window
	{
        bool isStart = false;

		public WindowRecord()
		{
			this.InitializeComponent();

            ButtonStart.Click += new RoutedEventHandler(ButtonStart_Click);
            ButtonClose.Click += new RoutedEventHandler(ButtonClose_Click);
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

        private void ButtonClose_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }
    }
}
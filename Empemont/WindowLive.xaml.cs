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
	public partial class WindowLive : Window
	{
        private enum ActivePage
        {
            Speakers = 0,
            Microphone,
        }

        private ActivePage pageNo;

		public WindowLive()
		{
			this.InitializeComponent();

            Loaded += Dialog_Loaded;

            ButtonPrev.Click += new RoutedEventHandler(ButtonPrev_Click);
            ButtonNext.Click += new RoutedEventHandler(ButtonNext_Click);
            ButtonCancel.Click += new RoutedEventHandler(ButtonCancel_Click);
		}

        private void ShowPage()
        {
            GridPage.Children.Clear();

            UserControl page = null;

            switch (pageNo)
            {
                case ActivePage.Speakers:
                    page = new PageSpeakersControl();
                    break;
                case ActivePage.Microphone:
                    page = new WindowPageMicrophone();
                    break;
            }

            GridPage.Children.Add(page);
        }

        private void ButtonNext_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (pageNo < ActivePage.Microphone)
                pageNo++;
            ShowPage();
        }

        private void ButtonPrev_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (pageNo > 0)
                pageNo--;
            ShowPage();
        }

        private void ButtonCancel_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Close();
		}

        private void Dialog_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            pageNo = 0;
            ShowPage();
        }
	}
}
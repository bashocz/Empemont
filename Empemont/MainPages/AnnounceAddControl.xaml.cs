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
	/// Interaction logic for AnnounceAddControl.xaml
	/// </summary>
	public partial class AnnounceAddControl : UserControl
	{
        private enum ActivePage
        {
            Scheduler = 0,
            Composer,
            Speakers,
        }

        private ActivePage pageNo;

        private Announcement announcement;

        public event RoutedEventHandler PageClosed; 

        public AnnounceAddControl()
		{
			this.InitializeComponent();
		}

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            GetAnnouncement();
            pageNo = 0;
            ShowPage();
        }

        private void GetAnnouncement()
        {
            announcement = new Announcement();
        }

        private void btnNext_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (pageNo < ActivePage.Speakers)
                pageNo++;
            ShowPage();
        }

        private void btnPrev_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (pageNo > 0)
                pageNo--;
            ShowPage();
        }

        private void btnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Close();
        }

        private void Close()
        {
            if (PageClosed != null)
            {
                PageClosed(this, new RoutedEventArgs());
            }
        }

        private void ShowPage()
        {
            GridPage.Children.Clear();

            UserControl page = null;
            switch (pageNo)
            {
                case ActivePage.Scheduler:
                    page = new PageUnderConstructionControl();
                    break;
                case ActivePage.Composer:
                    page = new PageComposerControl();
                    break;
                case ActivePage.Speakers:
                    page = new PageUnderConstructionControl();
                    break;
            }
            page.DataContext = announcement;
            GridPage.Children.Add(page);
        }
    }
}
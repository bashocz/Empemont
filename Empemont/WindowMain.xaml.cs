using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        private enum EmpePage
        {
            NoPage,
            Calendar,
            AnnouncementAdd,
            AnnouncementLive
        }

        private EmpePage actualPage;

        private bool announcementAddOpened;

        public WindowMain()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ShowCalendar();
        }

        private void btnCalendar_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShowCalendar();
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShowAnnouncementAdd();
        }

        private void btnLive_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WindowLive dlg = new WindowLive();
            dlg.Owner = this;
            dlg.ShowDialog();
        }

        private bool CanSwitchPage(EmpePage newPage)
        {
            if (announcementAddOpened)
                return false;
            return true;
        }

        private void CloseActualPage()
        {
            grMainPage.Children.Clear();
            actualPage = EmpePage.NoPage;
        }

        private void ShowCalendar()
        {
            if (CanSwitchPage(EmpePage.Calendar))
                ShowPage(EmpePage.Calendar);
        }

        private void ShowAnnouncementAdd()
        {
            if (CanSwitchPage(EmpePage.AnnouncementAdd))
                ShowPage(EmpePage.AnnouncementAdd);
        }

        private void CloseAnnouncementAdd(object sender, RoutedEventArgs e)
        {
            announcementAddOpened = false;
            ShowCalendar();
        }

        private void ShowPage(EmpePage newPage)
        {
            CloseActualPage();
            switch (newPage)
            {
                case EmpePage.Calendar:
                    CalendarControl cc = new CalendarControl();
                    grMainPage.Children.Add(cc);
                    break;
                case EmpePage.AnnouncementAdd:
                    AnnounceAddControl ac = new AnnounceAddControl();
                    ac.PageClosed += new RoutedEventHandler(CloseAnnouncementAdd);
                    grMainPage.Children.Add(ac);
                    announcementAddOpened = true;
                    break;
                case EmpePage.AnnouncementLive:
                    break;
            }
            actualPage = newPage;
            EnableButtons();
        }

        private void EnableButtons()
        {
            bool enabled = actualPage == EmpePage.NoPage;
            enabled |= actualPage == EmpePage.Calendar;

            btnCalendar.IsEnabled = enabled;
            btnAdd.IsEnabled = enabled;
            btnLive.IsEnabled = enabled;
        }
    }
}

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
	/// Interaction logic for Calendar.xaml
	/// </summary>
	public partial class Scheduler : UserControl
	{
        private SchedulerData calendar;

		public Scheduler()
		{
			this.InitializeComponent();

            Loaded += new RoutedEventHandler(Calendar_Loaded);
		}

        private void Calendar_Loaded(object sender, RoutedEventArgs e)
        {
            calendar = new SchedulerData(DateTime.Now);
            calendar.AddAnnouncement(new Announcement { Start = new DateTime(2010, 4, 4, 15, 30, 0), Header = "AAA" });
            calendar.AddAnnouncement(new Announcement { Start = new DateTime(2010, 4, 4, 10, 15, 0), Header = "BBB" });

            LayoutRoot.DataContext = calendar;

            for (int j = 0; j < 5; j++) // week of month
                for (int i = 0; i < 7; i++) // day of week
                {
                    SchedulerItem ci = new SchedulerItem();
                    LayoutRoot.Children.Add(ci);
                    Grid.SetColumn(ci, i + 1);
                    Grid.SetRow(ci, j + 1);
                    ci.DataContext = calendar.Days[i, j];
                }
        }

        public DateTime SelectedDate
        {
            get { return calendar.SelectedDate; }
            set { calendar.SelectedDate = value; }
        }
    }
}
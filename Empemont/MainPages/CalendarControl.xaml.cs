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
	/// Interaction logic for CalendarControl.xaml
	/// </summary>
	public partial class CalendarControl : UserControl
	{
		public CalendarControl()
		{
			this.InitializeComponent();
		}

        private void Calendar_SelectedDatesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            scheduler.SelectedDate = (DateTime)wpfCalendar.SelectedDate;
        }
    }
}
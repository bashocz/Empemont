using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Empemont
{
    public class SchedulerDayData : INotifyPropertyChanged
    {
        private DateTime date;
        private bool actualMonth;
        private ObservableCollection<Announcement> announcementList;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public SchedulerDayData()
        {
            announcementList = new ObservableCollection<Announcement>();
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value != date)
                {
                    date = value;
                    NotifyPropertyChanged("Date");
                }
            }
        }

        public bool ActualMonth
        {
            get { return actualMonth; }
            set
            {
                if (value != actualMonth)
                {
                    actualMonth = value;
                    NotifyPropertyChanged("ActualMonth");
                }
            }
        }

        public ObservableCollection<Announcement> AnnouncementList
        {
            get { return announcementList; }
        }
    }
}

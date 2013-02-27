using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;
using System.Collections.ObjectModel;

namespace Empemont
{
    public class SchedulerData : INotifyPropertyChanged
    {
        private CultureInfo csCZ;

        private DateTime firstDate;
        private DateTime lastDate;

        private DateTime todayDate;
        private DateTime selectedDate;
        private SchedulerDayData[,] days;
        private string[] weekOfYear;

        private ObservableCollection<Announcement> announcementList;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public SchedulerData()
            : this(DateTime.Now) { }

        public SchedulerData(DateTime todayDate)
        {
            this.todayDate = todayDate;
            announcementList = new ObservableCollection<Announcement>();

            csCZ = new CultureInfo("cs-CZ");

            days = new SchedulerDayData[7, 5];
            for (int j = 0; j < 5; j++) // week of month
                for (int i = 0; i < 7; i++) // day of week
                    days[i, j] = new SchedulerDayData();
            weekOfYear = new string[5];

            DisplayedDate(todayDate);
        }

        private SchedulerDayData GetSchedulerDay(DateTime date)
        {
            foreach (SchedulerDayData day in days)
                if ((day.Date.Year == date.Year) &&
                    (day.Date.Month == date.Month) &&
                    (day.Date.Day == date.Day))
                    return day;
            return null;
        }

        private void GetAnnouncement(DateTime date)
        {
            SchedulerDayData day = GetSchedulerDay(date);
            if (day != null)
            {
                day.AnnouncementList.Clear();

                List<Announcement> announcements = new List<Announcement>();

                foreach (Announcement announcement in announcementList)
                    if ((announcement.Start.Year == date.Year) &&
                        (announcement.Start.Month == date.Month) &&
                        (announcement.Start.Day == date.Day))
                        announcements.Add(announcement);

                if (announcements.Count > 0)
                    announcements.Sort();

                for (int idx = 0; idx < announcements.Count; idx++)
                    day.AnnouncementList.Add(announcements[idx]);
            }
        }

        private void DisplayedDate(DateTime displayedDate)
        {
            if ((displayedDate.Year != selectedDate.Year) ||
                (displayedDate.Month != selectedDate.Month))
            {
                DateTime date = new DateTime(displayedDate.Year, displayedDate.Month, 1);
                while (date.DayOfWeek != DayOfWeek.Monday)
                    date = date.AddDays(-1);
                firstDate = date;
                for (int j = 0; j < 5; j++) // week of month
                {                    
                    weekOfYear[j] = "Týden " + csCZ.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString();
                    for (int i = 0; i < 7; i++) // day of week
                    {
                        days[i, j].Date = date;
                        days[i, j].ActualMonth = date.Month == displayedDate.Month;
                        GetAnnouncement(date);
                        date = date.AddDays(1);
                    }
                }
                lastDate = date;
                NotifyPropertyChanged("WeekOfYear");
            }
            selectedDate = displayedDate;
        }

        public void AddAnnouncement(Announcement announcement)
        {
            announcementList.Add(announcement);
            if ((announcement.Start >= firstDate) && (announcement.Start < lastDate))
            {
                GetAnnouncement(announcement.Start);
            }
        }

        public DateTime TodayDate
        {
            get { return todayDate; }
            set
            {
                if (value != todayDate)
                {
                    todayDate = value;
                    NotifyPropertyChanged("HighlightedDate");
                }
            }
        }

        public DateTime SelectedDate
        {
            get { return selectedDate; }
            set
            {
                if (value != selectedDate)
                {
                    DisplayedDate(value);
                    NotifyPropertyChanged("SelectedDate");
                }
            }
        }

        public SchedulerDayData[,] Days
        {
            get { return days; }
        }

        public string[] WeekOfYear
        {
            get { return weekOfYear; }
        }

        public ObservableCollection<Announcement> AnnouncementList
        {
            get { return announcementList; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Media;
using System.Threading;

namespace Empemont
{
    public class Announcement : IComparable, INotifyPropertyChanged
    {
        private DateTime start;
        private string header;
        private TimeSpan duration;
        private ObservableCollection<AudioPart> audioPartList;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public Announcement()
        {
            audioPartList = new ObservableCollection<AudioPart>();
            audioPartList.CollectionChanged += new NotifyCollectionChangedEventHandler(AudioPartList_CollectionChanged);
        }

        private void AudioPartList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            MediaPlayer mp = new MediaPlayer();
            duration = new TimeSpan();
            foreach (AudioPart audio in audioPartList)
            {
                if (audio.Duration.TotalMilliseconds <= 0)
                {
                    mp.Open(audio.AudioUri);
                    int cnt = 0;
                    while ((!mp.NaturalDuration.HasTimeSpan) && (cnt < 10000))
                        Thread.Sleep(10);
                    if (mp.NaturalDuration.HasTimeSpan)
                        audio.Duration = mp.NaturalDuration.TimeSpan;
                }
                duration += audio.Duration;
            }
            NotifyPropertyChanged("Duration");
        }

        public int CompareTo(object obj)
        {
            return this.start.CompareTo((obj as Announcement).start);
        }

        public DateTime Start
        {
            get { return start; }
            set
            {
                if (value != start)
                {
                    start = value;
                    NotifyPropertyChanged("Start");
                }
            }
        }

        public string Header
        {
            get { return header; }
            set
            {
                if (value != header)
                {
                    header = value;
                    NotifyPropertyChanged("Header");
                }
            }
        }

        public TimeSpan Duration
        {
            get { return duration; }
            set
            {
                if (value != duration)
                {
                    duration = value;
                    NotifyPropertyChanged("Duration");
                }
            }
        }

        public ObservableCollection<AudioPart> AudioPartList
        {
            get { return audioPartList; }
        }
    }
}

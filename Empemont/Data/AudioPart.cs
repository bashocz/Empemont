using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Empemont
{
    public class AudioPart : INotifyPropertyChanged
    {
        private string iconPath;
        private string audioPath;
        private string header;
        private TimeSpan duration;
        private AudioType audioType;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public string IconPath
        {
            get { return iconPath; }
            set
            {
                if (value != iconPath)
                {
                    iconPath = value;
                    NotifyPropertyChanged("IconPath");
                    NotifyPropertyChanged("IconUri");
                }
            }
        }

        public Uri IconUri
        {
            get { return new Uri(iconPath); }
        }

        public string AudioPath
        {
            get { return audioPath; }
            set
            {
                if (value != audioPath)
                {
                    audioPath = value;
                    NotifyPropertyChanged("AudioPath");
                    NotifyPropertyChanged("AudioUri");
                }
            }
        }

        public Uri AudioUri
        {
            get { return new Uri(audioPath); }
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

        public AudioType AudioType
        {
            get { return audioType; }
            set
            {
                if (value != audioType)
                {
                    audioType = value;
                    NotifyPropertyChanged("AudioType");
                }
            }
        }
    }
}

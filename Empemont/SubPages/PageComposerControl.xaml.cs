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
using System.Threading;
using System.IO;

namespace Empemont
{
	/// <summary>
	/// Interaction logic for AddPage1.xaml
	/// </summary>
	public partial class PageComposerControl : UserControl
	{
        private int audioIndex;
        private MediaPlayer player;

		public PageComposerControl()
		{
			this.InitializeComponent();
		}

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            GetAnnounceList();

            audioIndex = -1;
            player = new MediaPlayer();
            slVolume.DataContext = player;
        }

        private void btnCustomAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Announcement announcement = (Announcement)this.DataContext;
            AudioPart audio = (AudioPart)(sender as Button).DataContext;
            announcement.AudioPartList.Add(new AudioPart
            {
                AudioType = audio.AudioType,
                Header = audio.Header,
                IconPath = audio.IconPath,
                AudioPath = audio.AudioPath
            });
        }

        private void btnAudioDir_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Title = "Vyber adresář s audio soubory";
            dlg.CheckFileExists = false;
            dlg.ValidateNames = false;
            dlg.InitialDirectory = Configuration.AudioDir;
            dlg.Filter = "Audio files (.mp3)|*.mp3";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                Configuration.AudioDir = System.IO.Path.GetDirectoryName(dlg.FileName);
                GetCustomList();
            }

        }

		private void btnBroadcastUp_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Announcement announcement = (Announcement)this.DataContext;
            AudioPart audio = (AudioPart)(sender as Button).DataContext;

            int index = announcement.AudioPartList.IndexOf(audio);
            if (index > 0)
                announcement.AudioPartList.Move(index, index - 1);
		}

		private void btnBroadcastDown_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Announcement announcement = (Announcement)this.DataContext;
            AudioPart audio = (AudioPart)(sender as Button).DataContext;

            int index = announcement.AudioPartList.IndexOf(audio);
            if (index < (announcement.AudioPartList.Count - 1))
                announcement.AudioPartList.Move(index, index + 1);
        }

		private void btnBroadcastDelete_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Announcement announcement = (Announcement)this.DataContext;
            AudioPart audio = (AudioPart)(sender as Button).DataContext;

            announcement.AudioPartList.Remove(audio);
        }

        private void btnPlay_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (audioIndex < 0)
            {
                Announcement announcement = (Announcement)this.DataContext;
                if (announcement.AudioPartList.Count > 0)
                {
                    audioIndex = 0;
                    player.MediaEnded += new EventHandler(Player_MediaEnded);
                    PlayAudio(announcement.AudioPartList[audioIndex].AudioUri);
                }
            }
            else
                StopAudio();
        }

        private void Player_MediaEnded(object sender, EventArgs e)
        {
            Announcement announcement = (Announcement)this.DataContext;
            if (audioIndex < (announcement.AudioPartList.Count - 1))
            {
                audioIndex++;
                PlayAudio(announcement.AudioPartList[audioIndex].AudioUri);
            }
            else
                StopAudio();
        }

        private void PlayAudio(Uri file)
        {
            player.Open(file);
            player.Play();
            btnPlayText.Text = "Zastavit";
        }

        private void StopAudio()
        {
            player.Stop();
            player.Close();
            audioIndex = -1;
            btnPlayText.Text = "Přehrát";
        }

        private void GetAnnounceList()
        {
            List<AudioPart> announces = new List<AudioPart>();
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Signál - požární poplach",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Error-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "pozarni_poplach.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Signál - všeobecná výstraha",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Critical-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "vseobecna_vystraha.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Signál - zkouška sirén",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Forbidden-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "zkouska_siren.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - chemická havárie",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_chemicka_havarie.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - konec poplachu",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_konec_poplachu.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - požární poplach",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_pozarni_poplach.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - radiační havárie",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_radiacni_havarie.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - všeobecná výstraha",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_vseobecna_vystraha.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - zátopová vlna",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_zatopova_vlna.mp3")
            });
            announces.Add(new AudioPart
            {
                AudioType = AudioType.Announce,
                Header = "Verbální - zkouška sirén",
                IconPath = System.IO.Path.Combine(Configuration.IconDir, "Symbols-Warning-icon.png"),
                AudioPath = System.IO.Path.Combine(Configuration.AnnounceDir, "verbalni_zkouska_siren.mp3")
            });            
            lbAnnounce.ItemsSource = announces;

            Thread thread = new Thread(new ParameterizedThreadStart(GetDurations));
            thread.Start(announces);
        }

        private void GetCustomList()
        {
            List<AudioPart> audios = new List<AudioPart>();

            List<string> fileList = new List<string>();
            fileList.AddRange(Directory.GetFiles(Configuration.AudioDir, "*.mp3"));
            fileList.AddRange(Directory.GetFiles(Configuration.AudioDir, "*.wma"));
            fileList.AddRange(Directory.GetFiles(Configuration.AudioDir, "*.wav"));
            fileList.Sort();
            foreach (string file in fileList)
            {
                audios.Add(new AudioPart
                {
                    AudioType = AudioType.Custom,
                    Header = System.IO.Path.GetFileName(file),
                    IconPath = System.IO.Path.Combine(Configuration.IconDir, "Music-icon.png"),
                    AudioPath = file
                });
            }

            lbCustom.ItemsSource = audios;

            Thread thread = new Thread(new ParameterizedThreadStart(GetDurations));
            thread.Start(audios);
        }

        private void GetDurations(object param)
        {
            List<AudioPart> audioList = (List<AudioPart>)param;
            MediaPlayer mp = new MediaPlayer();
            foreach (AudioPart audio in audioList)
            {
                mp.Open(audio.AudioUri);
                int cnt = 0;
                while ((!mp.NaturalDuration.HasTimeSpan) && (cnt < 10000))
                    Thread.Sleep(10);
                if (mp.NaturalDuration.HasTimeSpan)
                    audio.Duration = mp.NaturalDuration.TimeSpan;
            }
        }
    }
}
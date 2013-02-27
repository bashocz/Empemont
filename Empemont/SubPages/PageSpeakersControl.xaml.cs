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
	/// Interaction logic for AddPage1.xaml
	/// </summary>
	public partial class PageSpeakersControl : UserControl
	{
        private bool firstClick = false;

		public PageSpeakersControl()
		{
			this.InitializeComponent();

            SpeakersMesto.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);
            SpeakersKrasno.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);
            SpeakersJurinka.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);
            SpeakersPolicna.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);
            SpeakersPodlesi.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);
            SpeakersHrachovec.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);
            SpeakersKrhova.MouseDown += new MouseButtonEventHandler(Speakers_MouseDown);

            SpeakersMesto2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            MestoNamesti11.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            MestoNamesti21.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            MestoNemocnice1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            MestoVyhlidka1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            MestoStepanov1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            SpeakersKrasno2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            KrasnoKrizna1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            KrasnoNadrazi1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            KrasnoAutobus1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            KrasnoSklarny1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            SpeakersJurinka2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            JurinkaHriste1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            JurinkaTocna1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            SpeakersPolicna2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PolicnaSkola1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PolicnaTocna1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PolicnaKotlina1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PolicnaRevir1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            SpeakersPodlesi2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PodlesiRybnik1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PodlesiZbrojnice1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            PodlesiPodhaji1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            SpeakersHrachovec2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            HrachovecHriste1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            HrachovecTocna1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            SpeakersKrhova2.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            KrhovaKulturak1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);
            KrhovaJehlicna1.MouseDown += new MouseButtonEventHandler(Speakers2_MouseDown);

            Mesto.Click +=new RoutedEventHandler(Speakers2_Click);
            MestoNamesti1.Click += new RoutedEventHandler(Speakers2_Click);
            MestoNamesti2.Click += new RoutedEventHandler(Speakers2_Click);
            MestoNemocnice.Click += new RoutedEventHandler(Speakers2_Click);
            MestoVyhlidka.Click += new RoutedEventHandler(Speakers2_Click);
            MestoStepanov.Click += new RoutedEventHandler(Speakers2_Click);
            Krasno.Click += new RoutedEventHandler(Speakers2_Click);
            KrasnoKrizna.Click += new RoutedEventHandler(Speakers2_Click);
            KrasnoNadrazi.Click += new RoutedEventHandler(Speakers2_Click);
            KrasnoAutobus.Click += new RoutedEventHandler(Speakers2_Click);
            KrasnoSklarny.Click += new RoutedEventHandler(Speakers2_Click);
            Jurinka.Click += new RoutedEventHandler(Speakers2_Click);
            JurinkaHriste.Click += new RoutedEventHandler(Speakers2_Click);
            JurinkaTocna.Click += new RoutedEventHandler(Speakers2_Click);
            Policna.Click += new RoutedEventHandler(Speakers2_Click);
            PolicnaSkola.Click += new RoutedEventHandler(Speakers2_Click);
            PolicnaTocna.Click += new RoutedEventHandler(Speakers2_Click);
            PolicnaKotlina.Click += new RoutedEventHandler(Speakers2_Click);
            PolicnaRevir.Click += new RoutedEventHandler(Speakers2_Click);
            Podlesi.Click += new RoutedEventHandler(Speakers2_Click);
            PodlesiRybnik.Click += new RoutedEventHandler(Speakers2_Click);
            PodlesiZbrojnice.Click += new RoutedEventHandler(Speakers2_Click);
            PodlesiPodhaji.Click += new RoutedEventHandler(Speakers2_Click);
            Hrachovec.Click += new RoutedEventHandler(Speakers2_Click);
            HrachovecHriste.Click += new RoutedEventHandler(Speakers2_Click);
            HrachovecTocna.Click += new RoutedEventHandler(Speakers2_Click);
            Krhova.Click += new RoutedEventHandler(Speakers2_Click);
            KrhovaKulturak.Click += new RoutedEventHandler(Speakers2_Click);
            KrhovaJehlicna.Click += new RoutedEventHandler(Speakers2_Click);
        }

		private void Speakers_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
            if ((e.LeftButton == MouseButtonState.Pressed) && (sender is Rectangle))
            {
                Rectangle rect = sender as Rectangle;
                if (rect.StrokeThickness > 1)
                {
                    rect.StrokeThickness = 1;
                    rect.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                    rect.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
                }
                else
                {
                    rect.StrokeThickness = 2;
                    rect.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                    rect.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
                }
            }
		}

        private void ShowSpeakers()
        {
            // mesto
            if ((Mesto.IsChecked == true) && (SpeakersMesto2.StrokeThickness != 2))
            {
                SpeakersMesto2.StrokeThickness = 2;
                SpeakersMesto2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersMesto2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Mesto.IsChecked == false) && (SpeakersMesto2.StrokeThickness > 1))
            {
                SpeakersMesto2.StrokeThickness = 1;
                SpeakersMesto2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersMesto2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Mesto.IsChecked == null) && (SpeakersMesto2.StrokeThickness < 3))
            {
                SpeakersMesto2.StrokeThickness = 3;
                SpeakersMesto2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersMesto2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((MestoNamesti1.IsChecked == true) && (MestoNamesti11.StrokeThickness < 2))
            {
                MestoNamesti11.StrokeThickness = 2;
                MestoNamesti11.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((MestoNamesti1.IsChecked == false) && (MestoNamesti11.StrokeThickness > 1))
            {
                MestoNamesti11.StrokeThickness = 1;
                MestoNamesti11.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((MestoNamesti2.IsChecked == true) && (MestoNamesti21.StrokeThickness < 2))
            {
                MestoNamesti21.StrokeThickness = 2;
                MestoNamesti21.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((MestoNamesti2.IsChecked == false) && (MestoNamesti21.StrokeThickness > 1))
            {
                MestoNamesti21.StrokeThickness = 1;
                MestoNamesti21.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((MestoNemocnice.IsChecked == true) && (MestoNemocnice1.StrokeThickness < 2))
            {
                MestoNemocnice1.StrokeThickness = 2;
                MestoNemocnice1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((MestoNemocnice.IsChecked == false) && (MestoNemocnice1.StrokeThickness > 1))
            {
                MestoNemocnice1.StrokeThickness = 1;
                MestoNemocnice1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((MestoVyhlidka.IsChecked == true) && (MestoVyhlidka1.StrokeThickness < 2))
            {
                MestoVyhlidka1.StrokeThickness = 2;
                MestoVyhlidka1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((MestoVyhlidka.IsChecked == false) && (MestoVyhlidka1.StrokeThickness > 1))
            {
                MestoVyhlidka1.StrokeThickness = 1;
                MestoVyhlidka1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((MestoStepanov.IsChecked == true) && (MestoStepanov1.StrokeThickness < 2))
            {
                MestoStepanov1.StrokeThickness = 2;
                MestoStepanov1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((MestoStepanov.IsChecked == false) && (MestoStepanov1.StrokeThickness > 1))
            {
                MestoStepanov1.StrokeThickness = 1;
                MestoStepanov1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            // krasno
            if ((Krasno.IsChecked == true) && (SpeakersKrasno2.StrokeThickness != 2))
            {
                SpeakersKrasno2.StrokeThickness = 2;
                SpeakersKrasno2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersKrasno2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Krasno.IsChecked == false) && (SpeakersKrasno2.StrokeThickness > 1))
            {
                SpeakersKrasno2.StrokeThickness = 1;
                SpeakersKrasno2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersKrasno2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Krasno.IsChecked == null) && (SpeakersKrasno2.StrokeThickness < 3))
            {
                SpeakersKrasno2.StrokeThickness = 3;
                SpeakersKrasno2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersKrasno2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((KrasnoKrizna.IsChecked == true) && (KrasnoKrizna1.StrokeThickness < 2))
            {
                KrasnoKrizna1.StrokeThickness = 2;
                KrasnoKrizna1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((KrasnoKrizna.IsChecked == false) && (KrasnoKrizna1.StrokeThickness > 1))
            {
                KrasnoKrizna1.StrokeThickness = 1;
                KrasnoKrizna1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((KrasnoNadrazi.IsChecked == true) && (KrasnoNadrazi1.StrokeThickness < 2))
            {
                KrasnoNadrazi1.StrokeThickness = 2;
                KrasnoNadrazi1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((KrasnoNadrazi.IsChecked == false) && (KrasnoNadrazi1.StrokeThickness > 1))
            {
                KrasnoNadrazi1.StrokeThickness = 1;
                KrasnoNadrazi1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((KrasnoAutobus.IsChecked == true) && (KrasnoAutobus1.StrokeThickness < 2))
            {
                KrasnoAutobus1.StrokeThickness = 2;
                KrasnoAutobus1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((KrasnoAutobus.IsChecked == false) && (KrasnoAutobus1.StrokeThickness > 1))
            {
                KrasnoAutobus1.StrokeThickness = 1;
                KrasnoAutobus1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((KrasnoSklarny.IsChecked == true) && (KrasnoSklarny1.StrokeThickness < 2))
            {
                KrasnoSklarny1.StrokeThickness = 2;
                KrasnoSklarny1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((KrasnoSklarny.IsChecked == false) && (KrasnoSklarny1.StrokeThickness > 1))
            {
                KrasnoSklarny1.StrokeThickness = 1;
                KrasnoSklarny1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            // jurinka
            if ((Jurinka.IsChecked == true) && (SpeakersJurinka2.StrokeThickness != 2))
            {
                SpeakersJurinka2.StrokeThickness = 2;
                SpeakersJurinka2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersJurinka2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Jurinka.IsChecked == false) && (SpeakersJurinka2.StrokeThickness > 1))
            {
                SpeakersJurinka2.StrokeThickness = 1;
                SpeakersJurinka2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersJurinka2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Jurinka.IsChecked == null) && (SpeakersJurinka2.StrokeThickness < 3))
            {
                SpeakersJurinka2.StrokeThickness = 3;
                SpeakersJurinka2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersJurinka2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((JurinkaHriste.IsChecked == true) && (JurinkaHriste1.StrokeThickness < 2))
            {
                JurinkaHriste1.StrokeThickness = 2;
                JurinkaHriste1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((JurinkaHriste.IsChecked == false) && (JurinkaHriste1.StrokeThickness > 1))
            {
                JurinkaHriste1.StrokeThickness = 1;
                JurinkaHriste1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((JurinkaTocna.IsChecked == true) && (JurinkaTocna1.StrokeThickness < 2))
            {
                JurinkaTocna1.StrokeThickness = 2;
                JurinkaTocna1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((JurinkaTocna.IsChecked == false) && (JurinkaTocna1.StrokeThickness > 1))
            {
                JurinkaTocna1.StrokeThickness = 1;
                JurinkaTocna1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            // policna
            if ((Policna.IsChecked == true) && (SpeakersPolicna2.StrokeThickness != 2))
            {
                SpeakersPolicna2.StrokeThickness = 2;
                SpeakersPolicna2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersPolicna2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Policna.IsChecked == false) && (SpeakersPolicna2.StrokeThickness > 1))
            {
                SpeakersPolicna2.StrokeThickness = 1;
                SpeakersPolicna2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersPolicna2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Policna.IsChecked == null) && (SpeakersPolicna2.StrokeThickness < 3))
            {
                SpeakersPolicna2.StrokeThickness = 3;
                SpeakersPolicna2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersPolicna2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PolicnaSkola.IsChecked == true) && (PolicnaSkola1.StrokeThickness < 2))
            {
                PolicnaSkola1.StrokeThickness = 2;
                PolicnaSkola1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PolicnaSkola.IsChecked == false) && (PolicnaSkola1.StrokeThickness > 1))
            {
                PolicnaSkola1.StrokeThickness = 1;
                PolicnaSkola1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PolicnaTocna.IsChecked == true) && (PolicnaTocna1.StrokeThickness < 2))
            {
                PolicnaTocna1.StrokeThickness = 2;
                PolicnaTocna1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PolicnaTocna.IsChecked == false) && (PolicnaTocna1.StrokeThickness > 1))
            {
                PolicnaTocna1.StrokeThickness = 1;
                PolicnaTocna1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PolicnaKotlina.IsChecked == true) && (PolicnaKotlina1.StrokeThickness < 2))
            {
                PolicnaKotlina1.StrokeThickness = 2;
                PolicnaKotlina1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PolicnaKotlina.IsChecked == false) && (PolicnaKotlina1.StrokeThickness > 1))
            {
                PolicnaKotlina1.StrokeThickness = 1;
                PolicnaKotlina1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PolicnaRevir.IsChecked == true) && (PolicnaRevir1.StrokeThickness < 2))
            {
                PolicnaRevir1.StrokeThickness = 2;
                PolicnaRevir1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PolicnaRevir.IsChecked == false) && (PolicnaRevir1.StrokeThickness > 1))
            {
                PolicnaRevir1.StrokeThickness = 1;
                PolicnaRevir1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            // podlesi
            if ((Podlesi.IsChecked == true) && (SpeakersPodlesi2.StrokeThickness != 2))
            {
                SpeakersPodlesi2.StrokeThickness = 2;
                SpeakersPodlesi2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersPodlesi2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Podlesi.IsChecked == false) && (SpeakersPodlesi2.StrokeThickness > 1))
            {
                SpeakersPodlesi2.StrokeThickness = 1;
                SpeakersPodlesi2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersPodlesi2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Podlesi.IsChecked == null) && (SpeakersPodlesi2.StrokeThickness < 3))
            {
                SpeakersPodlesi2.StrokeThickness = 3;
                SpeakersPodlesi2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersPodlesi2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PodlesiRybnik.IsChecked == true) && (PodlesiRybnik1.StrokeThickness < 2))
            {
                PodlesiRybnik1.StrokeThickness = 2;
                PodlesiRybnik1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PodlesiRybnik.IsChecked == false) && (PodlesiRybnik1.StrokeThickness > 1))
            {
                PodlesiRybnik1.StrokeThickness = 1;
                PodlesiRybnik1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PodlesiZbrojnice.IsChecked == true) && (PodlesiZbrojnice1.StrokeThickness < 2))
            {
                PodlesiZbrojnice1.StrokeThickness = 2;
                PodlesiZbrojnice1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PodlesiZbrojnice.IsChecked == false) && (PodlesiZbrojnice1.StrokeThickness > 1))
            {
                PodlesiZbrojnice1.StrokeThickness = 1;
                PodlesiZbrojnice1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((PodlesiPodhaji.IsChecked == true) && (PodlesiPodhaji1.StrokeThickness < 2))
            {
                PodlesiPodhaji1.StrokeThickness = 2;
                PodlesiPodhaji1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((PodlesiPodhaji.IsChecked == false) && (PodlesiPodhaji1.StrokeThickness > 1))
            {
                PodlesiPodhaji1.StrokeThickness = 1;
                PodlesiPodhaji1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            // hrachovec
            if ((Hrachovec.IsChecked == true) && (SpeakersHrachovec2.StrokeThickness != 2))
            {
                SpeakersHrachovec2.StrokeThickness = 2;
                SpeakersHrachovec2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersHrachovec2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Hrachovec.IsChecked == false) && (SpeakersHrachovec2.StrokeThickness > 1))
            {
                SpeakersHrachovec2.StrokeThickness = 1;
                SpeakersHrachovec2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersHrachovec2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Hrachovec.IsChecked == null) && (SpeakersHrachovec2.StrokeThickness < 3))
            {
                SpeakersHrachovec2.StrokeThickness = 3;
                SpeakersHrachovec2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersHrachovec2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((HrachovecHriste.IsChecked == true) && (HrachovecHriste1.StrokeThickness < 2))
            {
                HrachovecHriste1.StrokeThickness = 2;
                HrachovecHriste1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((HrachovecHriste.IsChecked == false) && (HrachovecHriste1.StrokeThickness > 1))
            {
                HrachovecHriste1.StrokeThickness = 1;
                HrachovecHriste1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((HrachovecTocna.IsChecked == true) && (HrachovecTocna1.StrokeThickness < 2))
            {
                HrachovecTocna1.StrokeThickness = 2;
                HrachovecTocna1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((HrachovecTocna.IsChecked == false) && (HrachovecTocna1.StrokeThickness > 1))
            {
                HrachovecTocna1.StrokeThickness = 1;
                HrachovecTocna1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            // krhova
            if ((Krhova.IsChecked == true) && (SpeakersKrhova2.StrokeThickness != 2))
            {
                SpeakersKrhova2.StrokeThickness = 2;
                SpeakersKrhova2.Fill = App.Current.Resources["SelectedSpeakersArea"] as Brush;
                SpeakersKrhova2.Stroke = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Krhova.IsChecked == false) && (SpeakersKrhova2.StrokeThickness > 1))
            {
                SpeakersKrhova2.StrokeThickness = 1;
                SpeakersKrhova2.Fill = App.Current.Resources["DeselectedSpeakersArea"] as Brush;
                SpeakersKrhova2.Stroke = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
            else if ((Krhova.IsChecked == null) && (SpeakersKrhova2.StrokeThickness < 3))
            {
                SpeakersKrhova2.StrokeThickness = 3;
                SpeakersKrhova2.Fill = App.Current.Resources["UnselectedSpeakersArea"] as Brush;
                SpeakersKrhova2.Stroke = App.Current.Resources["UnselectedSpeakersAreaBorder"] as Brush;
            }

            if ((KrhovaKulturak.IsChecked == true) && (KrhovaKulturak1.StrokeThickness < 2))
            {
                KrhovaKulturak1.StrokeThickness = 2;
                KrhovaKulturak1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((KrhovaKulturak.IsChecked == false) && (KrhovaKulturak1.StrokeThickness > 1))
            {
                KrhovaKulturak1.StrokeThickness = 1;
                KrhovaKulturak1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }

            if ((KrhovaJehlicna.IsChecked == true) && (KrhovaJehlicna1.StrokeThickness < 2))
            {
                KrhovaJehlicna1.StrokeThickness = 2;
                KrhovaJehlicna1.Fill = App.Current.Resources["SelectedSpeakersAreaBorder"] as Brush;
            }
            else if ((KrhovaJehlicna.IsChecked == false) && (KrhovaJehlicna1.StrokeThickness > 1))
            {
                KrhovaJehlicna1.StrokeThickness = 1;
                KrhovaJehlicna1.Fill = App.Current.Resources["DeselectedSpeakersAreaBorder"] as Brush;
            }
        }

        private void EnableSpeakers(int tag)
        {
            switch (tag)
            {
                case 10:
                    bool check = true;
                    if (Mesto.IsChecked == true)
                        check = false;
                    Mesto.IsChecked = check;
                    MestoNamesti1.IsChecked = check;
                    MestoNamesti2.IsChecked = check;
                    MestoNemocnice.IsChecked = check;
                    MestoVyhlidka.IsChecked = check;
                    MestoStepanov.IsChecked = check;
                    break;
                case 11:
                    MestoNamesti1.IsChecked = !MestoNamesti1.IsChecked;
                    if ((MestoNamesti1.IsChecked == true) && (MestoNamesti2.IsChecked == true) &&
                        (MestoNemocnice.IsChecked == true) && (MestoVyhlidka.IsChecked == true) &&
                        (MestoStepanov.IsChecked == true))
                        Mesto.IsChecked = true;
                    else if ((MestoNamesti1.IsChecked == false) && (MestoNamesti2.IsChecked == false) &&
                        (MestoNemocnice.IsChecked == false) && (MestoVyhlidka.IsChecked == false) &&
                        (MestoStepanov.IsChecked == false))
                        Mesto.IsChecked = false;
                    else
                        Mesto.IsChecked = null;
                    break;
                case 12:
                    MestoNamesti2.IsChecked = !MestoNamesti2.IsChecked;
                    if ((MestoNamesti1.IsChecked == true) && (MestoNamesti2.IsChecked == true) &&
                        (MestoNemocnice.IsChecked == true) && (MestoVyhlidka.IsChecked == true) &&
                        (MestoStepanov.IsChecked == true))
                        Mesto.IsChecked = true;
                    else if ((MestoNamesti1.IsChecked == false) && (MestoNamesti2.IsChecked == false) &&
                        (MestoNemocnice.IsChecked == false) && (MestoVyhlidka.IsChecked == false) &&
                        (MestoStepanov.IsChecked == false))
                        Mesto.IsChecked = false;
                    else
                        Mesto.IsChecked = null;
                    break;
                case 13:
                    MestoNemocnice.IsChecked = !MestoNemocnice.IsChecked;
                    if ((MestoNamesti1.IsChecked == true) && (MestoNamesti2.IsChecked == true) &&
                        (MestoNemocnice.IsChecked == true) && (MestoVyhlidka.IsChecked == true) &&
                        (MestoStepanov.IsChecked == true))
                        Mesto.IsChecked = true;
                    else if ((MestoNamesti1.IsChecked == false) && (MestoNamesti2.IsChecked == false) &&
                        (MestoNemocnice.IsChecked == false) && (MestoVyhlidka.IsChecked == false) &&
                        (MestoStepanov.IsChecked == false))
                        Mesto.IsChecked = false;
                    else
                        Mesto.IsChecked = null;
                    break;
                case 14:
                    MestoVyhlidka.IsChecked = !MestoVyhlidka.IsChecked;
                    if ((MestoNamesti1.IsChecked == true) && (MestoNamesti2.IsChecked == true) &&
                        (MestoNemocnice.IsChecked == true) && (MestoVyhlidka.IsChecked == true) &&
                        (MestoStepanov.IsChecked == true))
                        Mesto.IsChecked = true;
                    else if ((MestoNamesti1.IsChecked == false) && (MestoNamesti2.IsChecked == false) &&
                        (MestoNemocnice.IsChecked == false) && (MestoVyhlidka.IsChecked == false) &&
                        (MestoStepanov.IsChecked == false))
                        Mesto.IsChecked = false;
                    else
                        Mesto.IsChecked = null;
                    break;
                case 15:
                    MestoStepanov.IsChecked = !MestoStepanov.IsChecked;
                    if ((MestoNamesti1.IsChecked == true) && (MestoNamesti2.IsChecked == true) &&
                        (MestoNemocnice.IsChecked == true) && (MestoVyhlidka.IsChecked == true) &&
                        (MestoStepanov.IsChecked == true))
                        Mesto.IsChecked = true;
                    else if ((MestoNamesti1.IsChecked == false) && (MestoNamesti2.IsChecked == false) &&
                        (MestoNemocnice.IsChecked == false) && (MestoVyhlidka.IsChecked == false) &&
                        (MestoStepanov.IsChecked == false))
                        Mesto.IsChecked = false;
                    else
                        Mesto.IsChecked = null;
                    break;
                case 20:
                    check = true;
                    if (Krasno.IsChecked == true)
                        check = false;
                    Krasno.IsChecked = check;
                    KrasnoKrizna.IsChecked = check;
                    KrasnoNadrazi.IsChecked = check;
                    KrasnoAutobus.IsChecked = check;
                    KrasnoSklarny.IsChecked = check;
                    break;
                case 21:
                    KrasnoKrizna.IsChecked = !KrasnoKrizna.IsChecked;
                    if ((KrasnoKrizna.IsChecked == true) && (KrasnoNadrazi.IsChecked == true) &&
                        (KrasnoAutobus.IsChecked == true) && (KrasnoSklarny.IsChecked == true))
                        Krasno.IsChecked = true;
                    else if ((KrasnoKrizna.IsChecked == false) && (KrasnoNadrazi.IsChecked == false) &&
                        (KrasnoAutobus.IsChecked == false) && (KrasnoSklarny.IsChecked == false))
                        Krasno.IsChecked = false;
                    else
                        Krasno.IsChecked = null;
                    break;
                case 22:
                    KrasnoNadrazi.IsChecked = !KrasnoNadrazi.IsChecked;
                    if ((KrasnoKrizna.IsChecked == true) && (KrasnoNadrazi.IsChecked == true) &&
                        (KrasnoAutobus.IsChecked == true) && (KrasnoSklarny.IsChecked == true))
                        Krasno.IsChecked = true;
                    else if ((KrasnoKrizna.IsChecked == false) && (KrasnoNadrazi.IsChecked == false) &&
                        (KrasnoAutobus.IsChecked == false) && (KrasnoSklarny.IsChecked == false))
                        Krasno.IsChecked = false;
                    else
                        Krasno.IsChecked = null;
                    break;
                case 23:
                    KrasnoAutobus.IsChecked = !KrasnoAutobus.IsChecked;
                    if ((KrasnoKrizna.IsChecked == true) && (KrasnoNadrazi.IsChecked == true) &&
                        (KrasnoAutobus.IsChecked == true) && (KrasnoSklarny.IsChecked == true))
                        Krasno.IsChecked = true;
                    else if ((KrasnoKrizna.IsChecked == false) && (KrasnoNadrazi.IsChecked == false) &&
                        (KrasnoAutobus.IsChecked == false) && (KrasnoSklarny.IsChecked == false))
                        Krasno.IsChecked = false;
                    else
                        Krasno.IsChecked = null;
                    break;
                case 24:
                    KrasnoSklarny.IsChecked = !KrasnoSklarny.IsChecked;
                    if ((KrasnoKrizna.IsChecked == true) && (KrasnoNadrazi.IsChecked == true) &&
                        (KrasnoAutobus.IsChecked == true) && (KrasnoSklarny.IsChecked == true))
                        Krasno.IsChecked = true;
                    else if ((KrasnoKrizna.IsChecked == false) && (KrasnoNadrazi.IsChecked == false) &&
                        (KrasnoAutobus.IsChecked == false) && (KrasnoSklarny.IsChecked == false))
                        Krasno.IsChecked = false;
                    else
                        Krasno.IsChecked = null;
                    break;
                case 30:
                    check = true;
                    if (Jurinka.IsChecked == true)
                        check = false;
                    Jurinka.IsChecked = check;
                    JurinkaHriste.IsChecked = check;
                    JurinkaTocna.IsChecked = check;
                    break;
                case 31:
                    JurinkaHriste.IsChecked = !JurinkaHriste.IsChecked;
                    if ((JurinkaHriste.IsChecked == true) && (JurinkaTocna.IsChecked == true))
                        Jurinka.IsChecked = true;
                    else if ((JurinkaHriste.IsChecked == false) && (JurinkaTocna.IsChecked == false))
                        Jurinka.IsChecked = false;
                    else
                        Jurinka.IsChecked = null;
                    break;
                case 32:
                    JurinkaTocna.IsChecked = !JurinkaTocna.IsChecked;
                    if ((JurinkaHriste.IsChecked == true) && (JurinkaTocna.IsChecked == true))
                        Jurinka.IsChecked = true;
                    else if ((JurinkaHriste.IsChecked == false) && (JurinkaTocna.IsChecked == false))
                        Jurinka.IsChecked = false;
                    else
                        Jurinka.IsChecked = null;
                    break;
                case 40:
                    check = true;
                    if (Policna.IsChecked == true)
                        check = false;
                    Policna.IsChecked = check;
                    PolicnaSkola.IsChecked = check;
                    PolicnaTocna.IsChecked = check;
                    PolicnaKotlina.IsChecked = check;
                    PolicnaRevir.IsChecked = check;
                    break;
                case 41:
                    PolicnaSkola.IsChecked = !PolicnaSkola.IsChecked;
                    if ((PolicnaSkola.IsChecked == true) && (PolicnaTocna.IsChecked == true) &&
                        (PolicnaKotlina.IsChecked == true) && (PolicnaRevir.IsChecked == true))
                        Policna.IsChecked = true;
                    else if ((PolicnaSkola.IsChecked == false) && (PolicnaTocna.IsChecked == false) &&
                        (PolicnaKotlina.IsChecked == false) && (PolicnaRevir.IsChecked == false))
                        Policna.IsChecked = false;
                    else
                        Policna.IsChecked = null;
                    break;
                case 42:
                    PolicnaTocna.IsChecked = !PolicnaTocna.IsChecked;
                    if ((PolicnaSkola.IsChecked == true) && (PolicnaTocna.IsChecked == true) &&
                        (PolicnaKotlina.IsChecked == true) && (PolicnaRevir.IsChecked == true))
                        Policna.IsChecked = true;
                    else if ((PolicnaSkola.IsChecked == false) && (PolicnaTocna.IsChecked == false) &&
                        (PolicnaKotlina.IsChecked == false) && (PolicnaRevir.IsChecked == false))
                        Policna.IsChecked = false;
                    else
                        Policna.IsChecked = null;
                    break;
                case 43:
                    PolicnaKotlina.IsChecked = !PolicnaKotlina.IsChecked;
                    if ((PolicnaSkola.IsChecked == true) && (PolicnaTocna.IsChecked == true) &&
                        (PolicnaKotlina.IsChecked == true) && (PolicnaRevir.IsChecked == true))
                        Policna.IsChecked = true;
                    else if ((PolicnaSkola.IsChecked == false) && (PolicnaTocna.IsChecked == false) &&
                        (PolicnaKotlina.IsChecked == false) && (PolicnaRevir.IsChecked == false))
                        Policna.IsChecked = false;
                    else
                        Policna.IsChecked = null;
                    break;
                case 44:
                    PolicnaRevir.IsChecked = !PolicnaRevir.IsChecked;
                    if ((PolicnaSkola.IsChecked == true) && (PolicnaTocna.IsChecked == true) &&
                        (PolicnaKotlina.IsChecked == true) && (PolicnaRevir.IsChecked == true))
                        Policna.IsChecked = true;
                    else if ((PolicnaSkola.IsChecked == false) && (PolicnaTocna.IsChecked == false) &&
                        (PolicnaKotlina.IsChecked == false) && (PolicnaRevir.IsChecked == false))
                        Policna.IsChecked = false;
                    else
                        Policna.IsChecked = null;
                    break;
                case 50:
                    check = true;
                    if (Podlesi.IsChecked == true)
                        check = false;
                    Podlesi.IsChecked = check;
                    PodlesiRybnik.IsChecked = check;
                    PodlesiZbrojnice.IsChecked = check;
                    PodlesiPodhaji.IsChecked = check;
                    break;
                case 51:
                    PodlesiRybnik.IsChecked = !PodlesiRybnik.IsChecked;
                    if ((PodlesiRybnik.IsChecked == true) && (PodlesiZbrojnice.IsChecked == true) &&
                        (PodlesiPodhaji.IsChecked == true))
                        Podlesi.IsChecked = true;
                    else if ((PodlesiRybnik.IsChecked == false) && (PodlesiZbrojnice.IsChecked == false) &&
                        (PodlesiPodhaji.IsChecked == false))
                        Podlesi.IsChecked = false;
                    else
                        Podlesi.IsChecked = null;
                    break;
                case 52:
                    PodlesiZbrojnice.IsChecked = !PodlesiZbrojnice.IsChecked;
                    if ((PodlesiRybnik.IsChecked == true) && (PodlesiZbrojnice.IsChecked == true) &&
                        (PodlesiPodhaji.IsChecked == true))
                        Podlesi.IsChecked = true;
                    else if ((PodlesiRybnik.IsChecked == false) && (PodlesiZbrojnice.IsChecked == false) &&
                        (PodlesiPodhaji.IsChecked == false))
                        Podlesi.IsChecked = false;
                    else
                        Podlesi.IsChecked = null;
                    break;
                case 53:
                    PodlesiPodhaji.IsChecked = !PodlesiPodhaji.IsChecked;
                    if ((PodlesiRybnik.IsChecked == true) && (PodlesiZbrojnice.IsChecked == true) &&
                        (PodlesiPodhaji.IsChecked == true))
                        Podlesi.IsChecked = true;
                    else if ((PodlesiRybnik.IsChecked == false) && (PodlesiZbrojnice.IsChecked == false) &&
                        (PodlesiPodhaji.IsChecked == false))
                        Podlesi.IsChecked = false;
                    else
                        Podlesi.IsChecked = null;
                    break;
                case 60:
                    check = true;
                    if (Hrachovec.IsChecked == true)
                        check = false;
                    Hrachovec.IsChecked = check;
                    HrachovecHriste.IsChecked = check;
                    HrachovecTocna.IsChecked = check;
                    break;
                case 61:
                    HrachovecHriste.IsChecked = !HrachovecHriste.IsChecked;
                    if ((HrachovecHriste.IsChecked == true) && (HrachovecTocna.IsChecked == true))
                        Hrachovec.IsChecked = true;
                    else if ((HrachovecHriste.IsChecked == false) && (HrachovecTocna.IsChecked == false))
                        Hrachovec.IsChecked = false;
                    else
                        Hrachovec.IsChecked = null;
                    break;
                case 62:
                    HrachovecTocna.IsChecked = !HrachovecTocna.IsChecked;
                    if ((HrachovecHriste.IsChecked == true) && (HrachovecTocna.IsChecked == true))
                        Hrachovec.IsChecked = true;
                    else if ((HrachovecHriste.IsChecked == false) && (HrachovecTocna.IsChecked == false))
                        Hrachovec.IsChecked = false;
                    else
                        Hrachovec.IsChecked = null;
                    break;
                case 70:
                    check = true;
                    if (Krhova.IsChecked == true)
                        check = false;
                    Krhova.IsChecked = check;
                    KrhovaKulturak.IsChecked = check;
                    KrhovaJehlicna.IsChecked = check;
                    break;
                case 71:
                    KrhovaKulturak.IsChecked = !KrhovaKulturak.IsChecked;
                    if ((KrhovaKulturak.IsChecked == true) && (KrhovaJehlicna.IsChecked == true))
                        Krhova.IsChecked = true;
                    else if ((KrhovaKulturak.IsChecked == false) && (KrhovaJehlicna.IsChecked == false))
                        Krhova.IsChecked = false;
                    else
                        Krhova.IsChecked = null;
                    break;
                case 72:
                    KrhovaJehlicna.IsChecked = !KrhovaJehlicna.IsChecked;
                    if ((KrhovaKulturak.IsChecked == true) && (KrhovaJehlicna.IsChecked == true))
                        Krhova.IsChecked = true;
                    else if ((KrhovaKulturak.IsChecked == false) && (KrhovaJehlicna.IsChecked == false))
                        Krhova.IsChecked = false;
                    else
                        Krhova.IsChecked = null;
                    break;
            }
        }

        private void Speakers2_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if ((e.LeftButton == MouseButtonState.Pressed) && (!firstClick))
            {
                firstClick = true;
                EnableSpeakers(Convert.ToInt32((sender as FrameworkElement).Tag));
                ShowSpeakers();
                firstClick = false;
            }
        }

        private void Speakers2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!firstClick)
            {
                firstClick = true;
                EnableSpeakers(Convert.ToInt32((sender as FrameworkElement).Tag));
                ShowSpeakers();
                firstClick = false;
            }
        }

        
	}
}
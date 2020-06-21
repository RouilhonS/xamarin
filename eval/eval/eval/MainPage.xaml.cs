using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace eval
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Accelerometer.ShakeDetected  += Accelerometer_ShakeDetected ;
        }

         void Accelerometer_ShakeDetected (object sender, EventArgs e)
        {
            await Audio.Manager.PlaySound("Voice01_01.mp3");
        }

         public void ToggleAccelerometer()
        {
            try
            {
                if (Accelerometer.IsMonitoring)
                  Accelerometer.Stop();
                else
                  Accelerometer.Start(speed);
            }
            catch (Exception ex)
            {
                
            }
        }

        protected override async void OnAppearing()
        {
            await Audio.Manager.PlayBackgroundMusic("Voice01_01.mp3");

            EnableBackgroundMusic.IsToggled = Audio.Manager.MusicOn;
            BackGroundVolume.Value = Audio.Manager.BackgroundMusicVolume;

            EnableEffects.IsToggled = Audio.Manager.EffectsOn;
            EffectsVolume.Value = Audio.Manager.EffectsVolume;
        }

        private void EnableBackgroundMusic_OnToggled(object sender, ToggledEventArgs e)
        {
            Audio.Manager.MusicOn = e.Value;
        }

        private void BackGroundVolume_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Audio.Manager.BackgroundMusicVolume = (float) e.NewValue;
        }

        private void EnableEffects_OnToggled(object sender, ToggledEventArgs e)
        {
            Audio.Manager.EffectsOn = e.Value;
        }

        private void EffectsVolume_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            Audio.Manager.EffectsVolume = (float)e.NewValue;
        }

        private async void Voice01_OnClicked(object sender, EventArgs e)
        {
            await Audio.Manager.PlaySound("Voice01_02.mp3");
        }

        private async void Voice02_OnClicked(object sender, EventArgs e)
        {
            await Audio.Manager.PlaySound("Voice02_01.mp3");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Metro_Media_Streamer
{
    public sealed partial class Media : Metro_Media_Streamer.Common.LayoutAwarePage
    {
        public Media()
        {
            this.InitializeComponent();
        }
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
       

        private void vol1_Click(object sender, RoutedEventArgs e)
        {
            if (b2.IsMuted)
            {
                b2.IsMuted = false;
            }
           if(b2.Volume < 1)
                b2.Volume += 0.1;         
        }

        

        private void play1_Click(object sender, RoutedEventArgs e)
        {

            b2.Play();


        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            /*if (b2.IsMuted)
            {
                b2.IsMuted = false;
            }*/

            if (b2.Volume > 0)
            {
                b2.Volume = b2.Volume - 0.1;
            }

        }

        private void pause1_Click(object sender, RoutedEventArgs e)
        {
            b2.Stop();
        }

        async private void b1_Click(object sender, RoutedEventArgs e)
        {

            Windows.Storage.Pickers.FileOpenPicker picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.FileTypeFilter.Add(".avi");
            picker.FileTypeFilter.Add(".mp3");
            picker.FileTypeFilter.Add(".mp4");

            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.ComputerFolder;
            var file = await picker.PickSingleFileAsync();
            MediaElement element = new MediaElement();
            b2 = element;
            if (file.FileType.Equals(".mp3"))
                element.SetSource(await file.OpenAsync(Windows.Storage.FileAccessMode.Read), "mp3");
        }

    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace Metro_Media_Streamer
{
    public sealed partial class Auto_Viewer : Metro_Media_Streamer.Common.LayoutAwarePage
    {
         public Auto_Viewer()
        {
            this.InitializeComponent();
           
            }
       
        private async void b11_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            var files = await KnownFolders.PicturesLibrary.GetFilesAsync();
            int i = r.Next(files.Count);
            int j = 0;
            foreach (var file in files)
            {
                if (i == j)
                {
                    var stream = await file.OpenAsync(FileAccessMode.Read);
                    BitmapImage img = new BitmapImage();
                    img.SetSource(stream as IRandomAccessStream);
                    image11.Source = img;
                    image22.Source = img;
                    
                }
                j++;
            }
        }

        private void b22_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(reg));
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }







        
    }
}

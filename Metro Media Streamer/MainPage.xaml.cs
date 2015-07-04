using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Storage.Streams;
namespace Metro_Media_Streamer
{
    public sealed partial class MainPage : Page
    {
        static int y;
        DispatcherTimer t = new DispatcherTimer();
        public MainPage()
        {
            this.InitializeComponent();
            backgrnd();
            t.Interval = new TimeSpan(0,0,1);
            t.Tick+=t_Tick;
            t.Start();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        async void t_Tick(object sender, object e)
        {
            y++;
            if (y == 10)
            {
                Frame.Navigate(typeof(reg));
            }
            Random r = new Random();
            var files = await KnownFolders.PicturesLibrary.GetFilesAsync();
            int i = r.Next(files.Count);
            int j = 0;
            foreach (var file in files)
            {
                if (i == j)
                {
                    var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                    BitmapImage img = new BitmapImage();
                    img.SetSource(stream as IRandomAccessStream);
                    image1.Source = img;
                    image2.Source = img;
                    image3.Source = img;
                    image4.Source = img;
                }
                j++;
            }
        }

        private async void backgrnd()
        {
            var files = await KnownFolders.MusicLibrary.GetFilesAsync();
            List<StorageFile> fileList = files.ToList();
            Random rnd = new Random();
            int index = rnd.Next(fileList.Count);
            ansh.Volume = 100;
            ansh.SetSource(await fileList.ElementAt(index).OpenAsync(FileAccessMode.Read), fileList.ElementAt(index).ContentType);
            ansh.Play();
        }

        private void SKIP_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(reg));
        }
    }
}

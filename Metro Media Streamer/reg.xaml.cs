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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Metro_Media_Streamer
{
   
    public sealed partial class reg : Page
    {
        public reg()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Auto_Viewer));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Self_Viewer));
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Media));
        }
    }
}

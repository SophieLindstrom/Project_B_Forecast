using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Weather.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            skyscraper.Source = $"https://loveincorporated.blob.core.windows.net/contentimages/main/15a71425-4380-45df-8d05-65c74e40b07a-new-york-best-views.jpg";
           // sunnyGif.Source = $"https://media0.giphy.com/media/vNg01outFUVhyKGiB2/giphy.gif";
        }
    }
}

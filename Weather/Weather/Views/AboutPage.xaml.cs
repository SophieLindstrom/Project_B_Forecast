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
            skyscraper.Source = $"https://static.wixstatic.com/media/3790d1_bf0a8f60b72a4a63af87655cc8c46186~mv2.jpg/v1/fit/w_1000%2Ch_1000%2Cal_c%2Cq_80/file.jpg";
           // sunnyGif.Source = $"https://media0.giphy.com/media/vNg01outFUVhyKGiB2/giphy.gif";
        }
    }
}

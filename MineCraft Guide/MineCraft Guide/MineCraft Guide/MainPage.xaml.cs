using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MineCraft_Guide
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        public void clickHandle(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}

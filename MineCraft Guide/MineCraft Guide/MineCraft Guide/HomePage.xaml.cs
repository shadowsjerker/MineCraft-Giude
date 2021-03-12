using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MineCraft_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            
        }

        

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
            
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());

        }

        
    }
}

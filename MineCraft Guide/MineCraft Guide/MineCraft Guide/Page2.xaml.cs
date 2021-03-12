using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MineCraft_Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

            foreach (string line in readText1)
            {
                name.Add(line);
            }

            foreach (string line in readText2)
            {
                detail.Add(line);
            }

            foreach (string line in readText3)
            {
                imageSource.Add(line);
            }

            for (int i = 0; i < name.Count; i++)
            {
                models.Add(new model(name[i], detail[i], imageSource[i]));
            }
            sList.ItemsSource = models;

            
        }

        
      
        

        public class model
        {
            public string name { get; set; }
            public string detail { get; set; }
            public string imageSource { get; set; }

            public model(string name, string detail, string imageSource)
            {
                this.name = name;
                this.detail = detail;
                this.imageSource = imageSource;
            }

            string getName()
            {
                return this.name;
            }
        }

        List<model> models = new List<model>() { };

        List<string> readText1 = new List<string>(File.ReadAllLines("filename1.txt"));
        List<string> readText2 = new List<string>(File.ReadAllLines("filename2.txt"));
        List<string> readText3 = new List<string>(File.ReadAllLines("filename3.txt"));
        List<string> name = new List<string>();
        List<string> detail = new List<string>();
        List<string> imageSource = new List<string>();

        private void userGet_TextChanged(object sender, TextChangedEventArgs e)
        {

            List<model> searchFounds = new List<model>();
            string userSearch = userGet.Text;
            string userSearchUp;
            string modelUp;
            string modelDetailUp;
            List<model> a = new List<model>();
            a.Add(new model("Nothing Here!!", "Nothing here, Search for something else", "https://shadowsjerker.github.io/imageSource/searchError.png"));



            for (int i = 0; i < models.Count; i++)
            {
                userSearchUp = userSearch.ToUpper();
                modelUp = models[i].name.ToUpper();
                modelDetailUp = models[i].detail.ToUpper();

                if(modelUp.Contains(userSearchUp))
                {
                    searchFounds.Add(models[i]);
                    continue;
                }
                else if(modelDetailUp.Contains(userSearchUp))
                {
                    searchFounds.Add(models[i]);
                }
                

            }

            if (searchFounds.Count > 0)
            {
                sList.ItemsSource = searchFounds;
            }
            else
            {
                sList.ItemsSource = a;
            }
        }
    }
}

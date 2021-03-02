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
        }

        
      
        //public void testButtonClicked(object sender, EventArgs e)
        //{
        //    sList.IsVisible = true;
        //    string[] tools = { "Planks", "stick", "torch", "workbench", "chest", "furnace", "ladder", "fence", "boat", "wooden slabs", "stone slabs", "sign", "doors", "painting", "bed", "wood", "pickaxes", "shovels", "axe", "hoes", "fishing rod", "flint and steel", "shears", "bucket", "clock", "compass", "map", "shulker box", "paper", "book", "book and quill", "iron bars", " nether brick fence", "gold ingot", "eye of ender", "enchantment table", "fire charge", "ender chest", "beacon", "anvil", " flower pot", "item frame", "carrot on a stick", "warped fungus on a stick", "fire work rocket", " fire work star", "lead", "carpets", "glass panes", "lead her", "banner", "armor stand", "end rod", "end crystal", "iron nugget", "concrete powder", "campfire", "soul campfire", "scaffolding", "barrel", "blast furnace", "smoker", "cartography table", "composter", "fletching table", "smithing table", "stonecutter", "grindstone", "lanterns", "lectern", "loom", "beehive", "chain", "netherite ingot", "soul torch", "respawn anchors", "loadstone", "helmets", "chestplates", "leggings", "boots", "swords", "bow", "crossbow", "arrow", "horse armor", "shield", "spectral arrow", "tipped arrow", "conduit", "turtle shell", "glass bottle", "cauldron", "brewing stand", " glistering melon", "blaze powder", "fermented spider eye", "magma cream", "pressure plates", "weighted pressure plates", "lever", "buttons", "trapdoor", "piston", "sticky piston", "fence gate", "Redstone repeater", "dispenser", "jukebox", "minecart", "powered minecart", "minecart with TNT", "storage minecart", " track", "powered rail", "detector rail", "activator rail", "Redstone torch", "Redstone lamp", "tripwire hook", "daylight sensor", "dropper", "hopper", "Redstone comparator", "trapped chest", "iron trapdoor", "observer", "target", "glow stone", " snow block", "stone brick", "brick", "sandstone", "smooth sandstone", "decorative sandstone", "gold block", "diamond block", "iron block", "lapis lazuli block", "emerald block", "coal block", "wool block", "bookshelf", "note block", "clay block", "jack lantern", "TNT", "wooden stairs", "stone stairs", "cobblestone walls", "block of Redstone", "nether brick", "red nether brick", "chiseled nether brick", "nether wart block", "block of quartz", "chiseled quarts block", "pillar quarts block", "quartz brick", "hay bale", "stained clay", "stained glass", "granite", "andesite", "diorite", "polished granite", "polished andesite", "polished diorite", "prismarine", "prismarine bricks", "dark prismarine", "sea lantern", "coarse dirt", "slime block", "moss stone", "mossy stone brick", "chiseled stone brick", "red sandstone", "smooth red sandstone", "chiseled red sand", "purpur block", "purpur pillar", "magma block", "bone block", "dried kelp block", "packed ice", "blue ice", "honey block", "Honeycomb block", "stripped wood", "polished basait", "polished black stone", "chiseled polished black stone", "polished black stone brick", "block of netherite", "cake", "bread", "cookie", "bowl", "mushroom stew", "golden apple", "golden carrot", "Pumkin seeds", "melon seeds", "melon block", "sugar", "pumkin pie", "rabbit stew", "suspicious stew", "تخته چوب", "چوب", " کبریت", "میز کار", "صندوق", "کوره", "نردبان", "حصار", "قایق", "اسلب چوبی", "اسلب سنگی", "تابلو", "در", "نقاشی", "تخت خواب", "چوبی", "کلنگ ها", "بیل ها", "تبر ها", "شخم زن", "قلاب ماهی گیری", "سنگ چخماق و استیل", "قیچی", "سطل", "ساعت", "قطب نما", "نقشه", "شالکر باکس", "کاغذ", "کتاب", "کتاب و جوهر", "میله آهنی", "حصار سنگی جهنم", "شمش طلا", "چشم اندر", "میز جادو", "سنگ آتش", "صندوق آخرت", "بیکنی", "انویل", "گلدان", "قالب آیتم", "هویج روی قلاب", "قارچ ناب خورده روی قلاب", "فشفشه", "فشفشه ستاره ای", "طناب", "کف پوش", "صفحه شیشه ای", "طناب. ", "پرچم", "استند زره", "میله اند ", "اند کریستال", "تکه های آهن", "ریل قدرتی", "آتش اردوگاه", "روح آتش اردوگاه", "داربست", "بشکه", "کوره ذوب آهن", "باربیکیو", "میز نقشه برداری", "کامپاستر", "میز فلتچین", "اسمیتینگ تیبل", "برش دهنده سنگ", "سنگ خرد کن", "فانوس", "میز سخنرانی", "میز بافندگی", "کندوی عسل", "زنجیر", "شمش ندرایت", "مشعل روح", "احیا کننده", "سنگ راهنما", "کلاه خودها", "زره ها", "شلوار ها", "چکمه ها", "شمشیر ها", "کمان", "کراس بو", "تیر", "زره اسب", "سپهر", "تیر نشانگر", "تیر جادویی", "مجرا", "پوسته اعتماد", "بطری شیشه ای", "دیگ", "استند دم کردن", "هندوانه طلا", "پودر بلیز", "چشم عنکبوت تبخیر شده", "کرم ماگما", "صفحات فشار", "صفحات فشار دار", "اهرم", "دکمه", "در تله", "پیستون", "استیکی پیستون", "در حصار", "رد استون ریپیدر", "توضیع کننده", "جعبه موسیقی", "ماین کارت", "ماین کارت با فر", "ماین کارت با بمب", "ماین کارت با صندوق", "ریل", "پاور ریل", "ریل رد یاب", "ریل فعال کننده", "مشعل رد استون", "لامپ رد استون", "قلاب سه سیم", "سنسور تشخیص روز", "اندازنده", "قیف", "ارسال کننده سیگنال رد استون", "صندوق تله", "در تله آهنی", "نظاره گر", "هدف", "سنگ درخشان", "بلاک برف", "سنگ آجر", "آجر", "سنگ ماسه", "سنگ ماسه صاف", "سنگ ماسه تزیینی", "بلاک طلا", "بلاک الماس", "بلاک آهن", "بلاک لپیز", "بلاک زمرد", "بلاک زغال", "بلاک پشم", "قفسه کتاب", "بلاک نوت", "بلاک سفالی", "فانوس کدویی", "بمب", "پله چوبی", "پله سنگی", "دیوار سنگی", "بلاک رد استون", "بلاک ندر", "بلاک قرمز ندر", "بلاک ندر قلم زنی شده", "بلاک وارت", "کوآرتز", "بلاک کوآرتز قلم زنی شده", "ستون کوآرتز", "آجر کوآرتز", "دسته گندم", "ماسه سنگ صاف", "شیشه رنگ شده", "گرانیت", "اند استیت", "دیورایت", "گرانیت صیقل خورده", "اند استیت صیقل داده شده", "دیوریت صیقل داده شده", "منشور", "آجر منشور", "منشور تیره", "فانوس دریایی", "خاک درشت", "بلاک اسلایم", "سنگ خزه", "آجر سنگی خزه ای", "آجر سنگی قلم زنی شده", "سنگ ماسه قرمز", "سنگ ماسه قرمز صاف", "سنگ ماسه قرمز قلم زنی شده", "بلاک بنفش", "صدف بنفش", "بلاک ماگما", "بلاک استخوان", "بلاک کلپ بخته", "دسته یخ", "یخ آبی", "بلاک عسل", "بلاک لانه زنبوری", "چوب پوست کنده", "باسیت صیقل داده شده", "سنگ سیاه صیقل داده شده", "سنگ سیاه صیقلی قلم زنی شده", "آجر سنگ سیاه ", "بلاک ندرایت", "کیک", "نان", "شیرنی", "ماسه", "سوپ قارچ", "سیب طلا", "هویج طلا", "دانه کدو", "دانه هندوانه", "بلاک هندوانه", "شکر", "پای کدو", "سوپ خرگوش", "سوپ دید در شب " };
        //    List<model> searchFounds = new List<model>();
        //    string userSearch = userGet.Text;
        //    string userSearchUp;
        //    string modelUp;
        //    List<model> a = new List<model>();
        //    a.Add(new model("Nothing Here!!", "Nothing here, Search for something else", "https://shadowsjerker.github.io/imageSource/searchError.png"));

        //    List<model> models = new List<model>() {
        //            new model("Planks", "One of the most useble tools in the game", "https://shadowsjerker.github.io/imageSource/1.gif"),
        //            new model("stick", "Used for building axes and ...", "https://shadowsjerker.github.io/imageSource/2.png"),
        //            new model("torch", "Used for lighting up darkness.\nAnd we suggest that use it for caves", "https://shadowsjerker.github.io/imageSource/3.png"),
        //            new model("workbench", "Is a table that you can build almost up to 90% of the tools in the game", "images/4.png"),
        //            new model("chest", "Used for storing your stuff", "Assets//1.gif"),
        //            new model("furnace", "Used for coocking", "Assets//1.gif"),
        //            new model("ladder", "For climing up", "Assets//1.gif"),
        //            new model("fence", "Often used for keeping the animals together", "Assets//1.gif"),
        //            new model("boat", "Often used for fishing\nFun fact: If you use it on ice it goes fasaaaast!!", "Assets//1.gif"),
        //            new model("", "", "")
        //        };






        //    for (int i = 0; i < models.Count; i++)
        //    {
        //        userSearchUp = userSearch.ToUpper();
        //        modelUp = models[i].name.ToUpper();

        //        if (userSearchUp.Length > modelUp.Length)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            if (userSearchUp == modelUp.Substring(0, userSearch.Length))
        //            {
        //                searchFounds.Add(models[i]);
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }

        //    }

        //    if (searchFounds.Count > 0)
        //    {
        //        sList.ItemsSource = searchFounds;
        //    }
        //    else
        //    {
        //        sList.ItemsSource = a;
        //    }
        //}

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

        private void userGet_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var tmp = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Page2)).Assembly;


            //System.IO.Stream s1 = tmp.GetManifestResourceStream("MineCraft_Guide.filename1.txt");
            //System.IO.Stream s2 = tmp.GetManifestResourceStream("MineCraft_Guide.filename2.txt");
            //System.IO.Stream s3 = tmp.GetManifestResourceStream("MineCraft_Guide.filename3.txt");

            //System.IO.StreamReader sr1 = new System.IO.StreamReader(s1);
            //System.IO.StreamReader sr2 = new System.IO.StreamReader(s2);
            //System.IO.StreamReader sr3 = new System.IO.StreamReader(s3);


            //sList.IsVisible = true;
            List<model> models = new List<model>() { };
            models.Add(new model("Axe", "Axe is it", "https://shadowsjerker.github.io/imageSource/1.gif"));
            models.Add(new model("PickAxe", "PickAxe is it", "https://shadowsjerker.github.io/imageSource/2.png"));
            models.Add(new model("Planks", "Planks is it", "https://shadowsjerker.github.io/imageSource/3.png"));
            models.Add(new model("Carrot", "Carrot is it", "https://shadowsjerker.github.io/imageSource/1.gif"));
            models.Add(new model("Axe", "Axe is it", "https://shadowsjerker.github.io/imageSource/1.gif"));
            models.Add(new model("Axe", "Axe is it", "https://shadowsjerker.github.io/imageSource/1.gif"));
            sList.ItemsSource = models;
            //List<string> readText1 = new List<string>(File.ReadAllLines("filename1.txt"));
            //List<string> readText2 = new List<string>(File.ReadAllLines("filename2.txt"));
            //List<string> readText3 = new List<string>(File.ReadAllLines("filename3.txt"));
            //List<string> name = new List<string>();
            //List<string> detail = new List<string>();
            //List<string> imageSource = new List<string>();




            //foreach (string line in readText1)
            //{
            //    name.Add(line);
            //}

            //foreach (string line in readText2)
            //{
            //    detail.Add(line);
            //}

            //foreach (string line in readText3)
            //{
            //    imageSource.Add(line);
            //}

            //for (int i = 0; i < name.Count; i++)
            //{
            //    models.Add(new model(name[i], detail[i], imageSource[i]));
            //}



            List<model> searchFounds = new List<model>();
            string userSearch = userGet.Text;
            string userSearchUp;
            string modelUp;
            List<model> a = new List<model>();
            a.Add(new model("Nothing Here!!", "Nothing here, Search for something else", "https://shadowsjerker.github.io/imageSource/searchError.png"));








            for (int i = 0; i < models.Count; i++)
            {
                userSearchUp = userSearch.ToUpper();
                modelUp = models[i].name.ToUpper();

                if (userSearchUp.Length > modelUp.Length)
                {
                    continue;
                }
                else
                {
                    if (userSearchUp == modelUp.Substring(0, userSearch.Length))
                    {
                        searchFounds.Add(models[i]);
                    }
                    else
                    {
                        continue;
                    }
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
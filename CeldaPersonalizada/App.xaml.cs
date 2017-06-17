using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CeldaPersonalizada
{
    public partial class App : Application
    {
        public static List<string> Nombres = new List<string>
        {
            "Euthalia Ilija",
            "Markos Jarle",
            "Medousa Nikolina",
            "Efthalia Sashi",
            "Egill Pavlina",
            "Scarlet Bratislava",
            "Hildur Zavier",
            "Felix Radboud",
            "Wilfrið Grimhilt",
            "Fern Yiorgos",
            "Alissa Luciano",
            "Urbana Shankar",
            "Kevin Monk",
"Wallace Berggren"       ,
"Alyse Gutter"           ,
"Brinda Antos"           ,
"Sunni Brotherton"       ,
"Luvenia Sabir"          ,
"Martha Larue"           ,
"Graham Waterhouse"      ,
"Gwyn Mcgilvray"         ,
"Nickolas Baumer"        ,
"Taren Rentas"           ,
"Daniele Gingras"        ,
"Dreama Deeb"            ,
"Louisa Hamiter"         ,
"Elfreda Rumery"         ,
"Mafalda Dorfman"        ,
"Consuela Shemwell"      ,
"Eddy Macaulay"          ,
"Naida Tarvin"           ,
"Josette Cuthbertson"
        };

        public App()
        {
            InitializeComponent();
            var tabbedPage = new TabbedPage();

            var listPage = new ListPage() { Title = "List" };
            tabbedPage.Children.Add(listPage);

            var tablePage = new TablePage() { Title = "Table" };
            tabbedPage.Children.Add(tablePage);

            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using mPlayer.Classes;

namespace mPlayer.Views
{
    /// <summary>
    /// Interaction logic for Library.xaml
    /// </summary>
    public partial class Library : Window
    {
        private static Library singletonInstance;
        private List<Album> albumList;
        
        private Library()
        {
            
            /*String xml = "<albumList><object><album></album><author></author><year></year></object></albumList>";
            XDocument doc = XDocument.Parse(xml);
            albumList = doc.Root.Elements("object").Select(x => x.album).ToList();*/
            InitializeComponent();
            InitBinding();
        }
        public static Library Instance
        {
            get
            {
                if(singletonInstance == null)
                {
                    singletonInstance = new Library();
                }
                return singletonInstance;
            }
        }
        private void InitBinding()
        {
            albumList = new List<Album>();
            Album album = new Album("Tytul", "Autor", "1995", "ProstoLabel");
            albumList.Add(album);
            albumList.Add(new Album("Styl życia G'N.O.J.A.","Peja","6 grudnia 2008","Fonografika"));
            libraryListView.ItemsSource = albumList;
        }
    }
}

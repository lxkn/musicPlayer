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
        //instance wykorzystywany w Singletonie
        private static Library singletonInstance;
        private static List<Album> albumList;
        
        private Library()
        {
            
            /*String xml = "<albumList><object><album></album><author></author><year></year></object></albumList>";
            XDocument doc = XDocument.Parse(xml);
            albumList = doc.Root.Elements("object").Select(x => x.album).ToList();*/
            InitializeComponent();
            //Bindowanie ListView
            InitBinding();
        }
        public static Library Instance
        {
            get
            {   
                // Jeżeli nie ma obiektu, stwórz
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
            albumList = loadXml(albumList);
                
           /* Album album = new Album("Tytul", "Autor", "1995", "ProstoLabel");
            albumList.Add(album);
            albumList.Add(new Album("Styl życia G'N.O.J.A.","Peja","6 grudnia 2008","Fonografika"));*/
            //Podpianie ItemsSource do albumList
            foreach(Album a in albumList)
            {
                Console.Write(a.author);
            }
            libraryListView.ItemsSource = albumList;
        }
        private List<Album> loadXml(List<Album> albumList)
        {
            albumList = (
                from e in XDocument.Load("albumList.xml").Root.Elements("album")
                select new Album
                {
                    title = (string)e.Element("title"),
                    author = (string)e.Element("author"),
                    year = (string)e.Element("year"),
                    label = (string)e.Element("label"),
                    songList = (
                       from o in e.Elements("songList").Elements("song")
                       select new Song
                       {
                           length = (int)o.Element("length"),
                           title = (string)o.Element("title"),
                           artist = (string)o.Element("artist"),
                           album = (string)o.Element("album"),
                           number = (int)o.Element("number"),
                           year = (int)o.Element("year")
                       }).ToList()
                }).ToList();
            return albumList;
        }
    }
}

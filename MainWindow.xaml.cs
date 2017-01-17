using System;
using System.Collections.Generic;
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
using mPlayer.Classes;
//using mPlayer.Views;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace mPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //obecny stan odtwarzacza
        private PlayState current_state;
        //Director
        ButtonCreater mainCreate = new ButtonCreater();
        //Builder FirstButtonsBuilder
        ButtonI builder = new FirstButtonsBuilder();
        List<Song> songList;
        private static List<Album> albumList;
        int index;

        public MainWindow()
        {
            InitializeComponent();

            mainCreate.Builder = builder;
            mainCreate.createButtons();
            ButtonsPanel bPanelFirst = mainCreate.getPanel();
            // stan poczatkowy to Stopped
            current_state = new StoppedState();
            //Tworzenie Singleton Pattern - Library
            Library lb = Library.Instance;
            //Podpinanie buttonów do obrazka
            InitBinding(bPanelFirst);
        }
        private void InitBinding(ButtonsPanel bp)
        {
            songList = new List<Song>();
            songList.Add(new Song(1.35,"Title","Artist","Album",1998,1,"path.mp3","Rychu Peja - Niezla Nuta"));
            songList.Add(new Song(1.35, "Title1", "Artist1", "Album1", 1998, 1, "path1.mp3", "Rychu Peja - Niezla Nuta"));
            playListView.ItemsSource = songList;
            playListView.SelectedItem = playListView.SelectedIndex + 1;
            index = 0;
            this.UpdateDefaultStyle();
            
            foreach (Song s in songList)
            {
                currentSong.Text = s.fileName;
                currentSec.Text = s.length.ToString();
                maxSec.Text = s.length.ToString();
            }
            /*playImage.Source = setImg(bp.playPath);
            stopImage.Source = setImg(bp.stopPath);
            nextImage.Source = setImg(bp.nextPath);
            previousImage.Source = setImg(bp.previousPath);
            repeatImage.Source = setImg(bp.repeatPath);
            shuffleImage.Source = setImg(bp.shufflePath);*/
            albumList = new List<Album>();
            albumList = loadXml(albumList);
            foreach (Album a in albumList)
            {
                Console.Write(a.author);
            }
            //Podpianie ItemsSource do albumList
            libraryListView.ItemsSource = albumList;
            /* imageButton2.Source = setImg(bp.playPath);
             imageButton3.Source = setImg(bp.playPath);
             imageButton4.Source = setImg(bp.playPath);
             imageButton5.Source = setImg(bp.playPath);
             */

        }

        public void onWindowLoad(Object sender, RoutedEventArgs e)
        {
            playListView.SelectedIndex = index;
        }
        //Wczytywanie albumów z pliku xml do Listy
        private List<Album> loadXml(List<Album> albumList)
        {

            albumList = (
                from e in XDocument.Load("albumList.xml").Root.Elements("album")//root element w <albumList>
                select new Album
                {
                    title = (string)e.Element("title"),
                    author = (string)e.Element("author"),
                    year = (string)e.Element("year"),
                    label = (string)e.Element("label"),
                    songList = (
                       from o in e.Elements("songList").Elements("song")//root element w <songList>
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

        //Ustawianie path do Obrazka
        private BitmapImage setImg(string path)
        {
            var source = new BitmapImage();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                source.BeginInit();
                source.CacheOption = BitmapCacheOption.OnLoad;
                source.StreamSource = stream;
                source.EndInit();
                source.Freeze();
            }
            return source;

        }
        

        // getter and setter dla stanu
        internal PlayState Current_state
        {
            get
            {
                return current_state;
            }

            set
            {
                current_state = value;
            }
        }


        //TEST STANOW musialem wstawic przykladowe buttony by wywolac funkcje play,stop ze stanow i zobaczyc cyz dziala
        //sprawdzic w output czy sie zmienia
        private void stop_click(object sender, RoutedEventArgs e)
        {
            current_state.stopSong(this);
            index = 1;
            playListView.Items.Refresh();
            this.UpdateDefaultStyle();
        }

        private void play_click(object sender, RoutedEventArgs e)
        {
            current_state.playSong(this);
        }
    }

}

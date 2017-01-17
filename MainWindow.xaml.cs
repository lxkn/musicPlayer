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
using System.Windows.Threading;
using System.Timers;
using System.Threading;

namespace mPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        //obecny stan odtwarzacza
        private PlayState current_state = new StoppedState();
        //Director
        ButtonCreater mainCreate = new ButtonCreater();
        //Builder FirstButtonsBuilder
        ButtonI builder = new FirstButtonsBuilder();
        List<Song> songList;
        private static List<Album> albumList;
        public static Album ObservableCollection { get; private set; }
        //ObservableC = ObservableCollection ();
        int index;
        public string songPath { get; set; }
        //Song Timer
        DispatcherTimer dtClockTime = new DispatcherTimer();
        int time = 0;
        int currentSongTime;
        public WMPLib.WindowsMediaPlayer mp3player = new WMPLib.WindowsMediaPlayer();
        public playAdapter playAdapter = new playAdapter();
        public MainWindow()
        {
            InitializeComponent();
            mainCreate.Builder = builder;
            mainCreate.createButtons();
            ButtonsPanel bPanelFirst = mainCreate.getPanel();
            // stan poczatkowy to Stopped
            //Tworzenie Singleton Pattern - Library
            Library lb = Library.Instance;
            //Podpinanie buttonów do obrazka

            //Ustawianie interwału
            dtClockTime.Interval = new TimeSpan(0, 0, 1); //in Hour, Minutes, Second.
            InitBinding(bPanelFirst);

        }

        private void dtClockTime_Tick(object sender, EventArgs e)
        {
            songTime.Text = (time++).ToString();
            timeline.Value = time;
            timeline.Maximum = currentSongTime;
            dtClockTime.Interval = new TimeSpan(0, 0, 1);
        }

        private void InitBinding(ButtonsPanel bp)
        {
            songList = new List<Song>();
            songList.Add(new Song(350,"Title","Artist","Album",1998,1, "C:\\Users\\Sebastian Paszko\\Desktop\\paluch.mp3", "Solar & Białas - #znasznasprzezto.mp3"));
            songList.Add(new Song(350, "Title1", "Artist1", "Album1", 1998, 1, "C:\\Users\\Sebastian Paszko\\Desktop\\metallica.mp3", "Solar & Białas - A do Z.mp3"));
            songList.Add(new Song(350, "Title1", "Artist1", "Album1", 1998, 1, "C:\\Users\\Sebastian Paszko\\Desktop\\wav_kozak.wav", "wav_kozak.wav"));
            playListView.ItemsSource = songList;
            playListView.SelectedItem = playListView.SelectedIndex + 1;
            index = 0;
            //this.UpdateDefaultStyle();
            
            foreach (Song s in songList)
            {
                currentSong.Text = s.fileName;
                currentSec.Text = s.length.ToString();
                maxSec.Text = s.length.ToString();
            }

            //buttonIMAGE podpinamy pod Source
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
                dtClockTime.Stop();
                time = 0;
                current_state.stopSong(this);
            
            //index = 1;
            playListView.Items.Refresh();
            //this.UpdateDefaultStyle();
        }

        private void play_click(object sender, RoutedEventArgs e)
        {
                current_state.playSong(this);

                
                dtClockTime.Tick += dtClockTime_Tick;

                dtClockTime.Start();
        }

        private void playListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentSong.Text = (playListView.SelectedItem as Song).artist;
            currentSong.Text += "-";
            currentSong.Text += (playListView.SelectedItem as Song).title;
            songPath =  (playListView.SelectedItem as Song).path;
               currentSongTime = (playListView.SelectedItem as Song).length;
        }
        private void onListViewDoubleClick(object sender, RoutedEventArgs e)
        {
            current_state.stopSong(this);
            current_state.playSong(this);
            dtClockTime.Tick += dtClockTime_Tick;
            dtClockTime.Start();
        }

    }

}

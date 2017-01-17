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
using mPlayer.Views;
using System.IO;
using System.Xml.Serialization;

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
            lb.Show();
            //Podpinanie buttonów do obrazka
            InitBinding(bPanelFirst);
        }
        private void InitBinding(ButtonsPanel bp)
        {
            songList = new List<Song>();
            songList.Add(new Song(1.35,"Title","Artist","Album",1998,1,"path.mp3"));
            playListView.ItemsSource = songList;
            imageButton.Source = setImg(bp.playPath);
            imageButton1.Source = setImg(bp.playPath);
            imageButton2.Source = setImg(bp.playPath);
            imageButton3.Source = setImg(bp.playPath);
            imageButton4.Source = setImg(bp.playPath);
            imageButton5.Source = setImg(bp.playPath);


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
        }

        private void play_click(object sender, RoutedEventArgs e)
        {
            current_state.playSong(this);
        }
    }

}

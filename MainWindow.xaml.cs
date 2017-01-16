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


        public MainWindow()
        {
            InitializeComponent();
            // stan poczatkowy to Stopped
            current_state = new StoppedState();
            Library lb = Library.Instance;
            lb.Show();   
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

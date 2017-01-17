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
namespace mPlayer
{
    /// <summary>
    /// Interaction logic for AlbumInfo.xaml
    /// </summary>
    public partial class AlbumInfo : Window
    {
        List<Song> songList;
        public AlbumInfo(List<Song>songList)
        {
            this.songList = songList;
            InitializeComponent();
            InitBinding();
        }
        private void InitBinding()
        {
            songListView.ItemsSource = songList;
        }


    }
}

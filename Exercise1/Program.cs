using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {

        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[]  {
                new Song("a", "bb", 258),
                new Song("c", "dd", 186),
                new Song("e", "ff", 293),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach(var song in songs) {
                Console.WriteLine("タイトル{0},歌手名{1},演奏時間{2:m\\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
            //:を文字と認識させるため\をつけ,\:をエスケープシーケンスと認識させないように@を先頭につけるか\\をつける
        }
    }
}

using L.Test.Core;
using L.Test.Model;
using L.Test.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace L.Console
{
    class Program
    {
        private static MusicContext dbcontext = new MusicContext();
        static void Import()
        {
            using (var _openDialog = new OpenFileDialog())
            {
                // Filter is m4a and mp3 extensions, allow multiselection, default initialDirectory is system Music folder
                _openDialog.Filter = "Music (*.mp3, *.m4a)|*.mp3;*.m4a|MP3 (*.mp3)|*.mp3|M4A (*.m4a)|*.m4a";
                _openDialog.Multiselect = true;
                _openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                DialogResult result = _openDialog.ShowDialog();

                string[] filespaths = null;

                // If dialog return OK pressed, collect paths
                if (result == DialogResult.OK)
                    filespaths = _openDialog.FileNames;
                else
                    return;

                // If paths is not null, handle files
                if (filespaths.Length > 0)
                {
                    Helper.TrackProcess(filespaths);
                }
                WriteLine("Done");
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            //Import();
            //Helper.ReseedIdentity();
            //WriteLine(dbcontext.Tracks.FirstOrDefault().Url);
            //OutputEncoding = Encoding.Unicode;
            //var viewmodel = new MainViewModel();
            //WriteLine(dbcontext.Tracks.FirstOrDefault().Tua);
            //WriteLine(viewmodel.Playlists[2].TrackList[0].Tua);

            // Load playlist from file -> done
            // Load playlist from database ->

            var p = new Playlist();
            WriteLine(p.Id);
        }
        
    }
}

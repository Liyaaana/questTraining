using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class MusicApp
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly List<string> _musicFiles = new List<string>();
        private List<string> _filteredFiles = new List<string>();
        private const string allowedFileType = "*.mp3";
        private int _currentIndex = 0;

        public MusicApp()
        {
            LoadMusicList();
        }
        private void LoadMusicList()
        {
            try
            {
                var files = Directory.GetFiles(_path, allowedFileType, SearchOption.AllDirectories);
                _musicFiles.AddRange(files);
                _filteredFiles.AddRange(files);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Play()
        {
            var fileName = Path.GetFileNameWithoutExtension(_filteredFiles[_currentIndex]);
            Console.WriteLine($"Now playing: {fileName}");
        }

        public void Next()
        {
            _currentIndex = _currentIndex < _filteredFiles.Count - 1 ? _currentIndex + 1 : 0;
            Play();
        }

        public void Previous()
        {
            _currentIndex = _currentIndex > 0 ? _currentIndex - 1 : _filteredFiles.Count - 1;
            Play();
        }

        public void Filter(string filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            if (filter == " ")
            {
                _filteredFiles.Clear();
                _filteredFiles.AddRange(_musicFiles);
                return;
            }

            //if (string.IsNullOrWhiteSpace(filter))
            //{
            //    throw new ArgumentNullException(nameof(filter));
            //}

            filter = filter.ToLowerInvariant();
            _filteredFiles = _musicFiles.Where(p =>
            {
                var fileName = Path.GetFileNameWithoutExtension(p).ToLowerInvariant();
                return fileName.Contains(filter);
            }).ToList();
        }
    }


internal class Program
    {
        static void Main(string[] args)
        {
            var s = new MusicApp();
            s.Play();
            s.Play();

            s.Next();
            s.Previous();

            s.Filter("2");
            s.Play();
            s.Filter(" ");
            s.Play();
        }
    }
}

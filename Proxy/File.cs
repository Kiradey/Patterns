using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Proxy
{
    public class File : IFile
    {
        private string _path;
        private StreamReader _streamReader;
        private File _file;
        public File(string path)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path), "Вы передали пустое значение пути к файлу!");
            }
            _path = path;
            _streamReader = new StreamReader(_path);
        }
        public double GetSize()
        {
            var file = new FileInfo(_path);
            return file.Length;
        }
        public string GetPath()
        {
            return _path;
        }
        public byte[] Show()
        {
            return System.IO.File.ReadAllBytes(_path);
        }
        public void Dispose()
        {
            _streamReader.Dispose();
        }
    }
}

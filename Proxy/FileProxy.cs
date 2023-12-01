using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class FileProxy : IFile
    {
        private File? _file;
        private string _path;
        public FileProxy(string path)
        {
            if (path == null) { throw new ArgumentNullException(nameof(path), "Вы передали пустое значение пути к файлу!"); }
            _path = path;
            _file = new File(path);
        }
        public double GetSize()
        {
            if (_file != null)
            {
                return _file.GetSize();
            }
            else
            {
                return new FileInfo(_path).Length;
            }
        }
        public string GetPath()
        {
            if (_file != null)
            {
                return _file.GetPath();
            }
            else
            {
                return _path;
            }
        }
        public byte[] Show()
        {
            if (_file == null)
            {
                _file = new File(_path);
            }
            return _file.Show();
        }
        public void Dispose()
        {
            if (_file != null) { _file.Dispose(); }
        }
    }
}

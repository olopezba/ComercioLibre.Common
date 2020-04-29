
using ComercioLibre.Services;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace ComercioLibre.Services
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //File.Delete(Path.Combine(path, fileName));
            return Path.Combine(path, fileName);
        }
    }
}
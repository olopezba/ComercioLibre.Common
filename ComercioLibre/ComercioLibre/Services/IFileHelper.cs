using System;
using System.Collections.Generic;
using System.Text;

namespace ComercioLibre.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}

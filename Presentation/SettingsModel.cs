using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SettingsModel
    {
        private bool _fullscreen = false;
        private string _imagesFolderPath = "";

        public bool Fullscreen
        {
            get
            {
                return _fullscreen;
            }
            set
            {
                _fullscreen = value;
            }
        }

        public string ImagesFolderPath
        {
            get
            {
                if (_imagesFolderPath.Length > 0) return _imagesFolderPath;
                else return null;
            }
            set
            {
                _imagesFolderPath = value;
            }
        }

    }
}

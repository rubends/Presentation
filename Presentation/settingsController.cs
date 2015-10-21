using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public class SettingsController
    {
        private SettingsView _view;
        private SettingsModel _model;
        private MainController _mainController;

        public SettingsController(MainController mainController)
        {
            _view = new SettingsView(this);
            _model = new SettingsModel();
            _mainController = mainController;
        }

        public SettingsView getView()
        {
            return _view;
        }

        public SettingsModel getModel()
        {
            return _model;
        }

        public void changeImageFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
        }

        public MainController getMainController()
        {
            return _mainController;
        }
    }
}

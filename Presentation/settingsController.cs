using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SettingsController
    {
        private SettingsView _view;
        private MainController _mainController;

        public SettingsController(MainController mainController)
        {
            _view = new SettingsView(this);
            _mainController = mainController;
        }

        public SettingsView getView()
        {
            return _view;
        }

        public MainController getMainController()
        {
            return _mainController;
        }
    }
}

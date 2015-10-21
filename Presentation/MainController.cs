using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class MainController
    {
        private MainView _view;
        private PresentationController _presentationController;
        private SettingsController _settingsController;

        public MainController()
        {
            _view = new MainView(this);
            _presentationController = new PresentationController(this);
            _settingsController = new SettingsController(this);
        }

        public MainView getView()
        {
            return _view;
        }

        public SettingsController getSettingsController()
        {
            return _settingsController;
        }

        public PresentationController getPresentationController()
        {
            return _presentationController;
        }

        public void openPresentationView()
        {
            _presentationController.getView().Show();

            FullScreen fullScreen = new FullScreen();
            fullScreen.EnterFullScreenMode(_presentationController.getView());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class PresentationController
    {
        private PresentationView _view;
        private MainController _mainController;

        public PresentationController(MainController mainController)
        {
            _view = new PresentationView(this);
            _view.Show();
            _mainController = mainController;
        }

        public PresentationView getView()
        {
            return _view;
        }
    }
}

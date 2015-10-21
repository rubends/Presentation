using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void loadImages()
        {
            string imagesPath = _mainController.getSettingsController().getImagesFolderPath();
            if (imagesPath == null)
            {
                MessageBox.Show("No image folder path set!", "Error");
            }
            else
            {
                ImageDirectory imagesDir = new ImageDirectory(imagesPath);
                if (imagesDir.getLength() > 0)
                {
                    MessageBox.Show("Files loaded: " + imagesDir.getLength().ToString(), "Message");
                    foreach(string imagePath in imagesDir.getImagePaths())
                    {

                    }
                }
                else
                {
                    MessageBox.Show("No files found.", "Error");
                }
            }
        }
    }
}

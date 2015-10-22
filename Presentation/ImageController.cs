using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
  public class ImageController
  {
    private ImageModel _model;
    private ImageView _view;

    public ImageController()
    {
      _model = new ImageModel(this);
      _view = new ImageView(this);
    }
    public void SetImage(string imagepath)
    {
      _model.ImagePath = imagepath;
      _view.UpdateView();
    }
    public ImageModel GetModel()
    {
      return _model;
    }
  }
}

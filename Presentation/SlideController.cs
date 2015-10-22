using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
  public class SlideController
  {
    private SlideModel _model;
    private SlideView _view;

    public SlideController()
    {
      _model = new SlideModel(this);
      _view = new SlideView(this);
    }

    public void SetSlide()
    {

    }
  }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
  public partial class SlideView : UserControl
  {
    private SlideController _controller;
    public SlideView(SlideController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void SlideView_Load(object sender, EventArgs e)
    {

    }
  }
}

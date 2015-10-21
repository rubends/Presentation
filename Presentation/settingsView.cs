using System;
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
    public partial class SettingsView : UserControl
    {
        private SettingsController _controller;

        public SettingsView(SettingsController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenPresentation_Click(object sender, EventArgs e)
        {
            _controller.getMainController().openPresentationView();
        }
    }
}

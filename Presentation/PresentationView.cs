using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PresentationView : Form
    {
        private PresentationController _controller;

        public PresentationView(PresentationController controller)
        {
            _controller = controller;

            InitializeComponent();
        }

        private void PresentationView_Load(object sender, EventArgs e)
        {
        }

        private void PresentationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("closed form");
            Application.Exit();
        }

        public void UpdateView()
        {
            // reset timer
            slideTimer.Interval = _controller.getMain().getSettingsController().getModel().SecondsBetweenSlides * 1000;

            // remove old slides
            foreach (Control controlItem in Controls.OfType<SlideView>())
            {
                Controls.Remove(controlItem);
            }

            // add requested slide
            SlideView nextSlide = _controller.getModel().Slides[_controller.getModel().CurrentSlide].GetView();
            nextSlide.Dock = DockStyle.Fill;
            Controls.Add(nextSlide);
            Console.WriteLine("Next slide");

        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            _controller.NextSlide();
        }
    }
}

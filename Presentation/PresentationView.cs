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
          TweetController tweet = new TweetController();
          tweet.SetTweet("Rubends", "wauw, wat eeen mooie app");
          SlideController slide = new SlideController();
          slide.SetSlide(tweet);

          Controls.Add(slide.GetView());
        }

        private void PresentationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("closed form");
            Application.Exit();
        }
    }
}

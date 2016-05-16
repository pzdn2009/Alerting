using SoundLocatePCLib;
using SpeechLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAlerting alerting = new DefaultAlerting();
            alerting.Beeping(500, 1000);
            alerting.PlaySound("");
            alerting.Speak("我在这里!");
        }
    }
}

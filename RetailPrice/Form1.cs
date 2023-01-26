using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float Turnintoint(string inputstring)
        {
            float inputnum;
            bool passesdparse = float.TryParse(inputstring, out inputnum);
            if (passesdparse && inputnum > 0) { return inputnum; }
            else { return - 1; }
        }

        private void centercontrol(Control centercontrol, int bufferwidth = 0, int bufferheight = 0)
        {
            //width height
            int[] buffer = { bufferwidth, bufferheight };
            int width = (this.Size.Width / 2) - (centercontrol.Width / 2) + buffer[0];
            int height = (this.Size.Height / 2) - (centercontrol.Height / 2) + buffer[1];
            centercontrol.Location = new Point(width, height);
        }

        private void CalculateRetail()
        {
            float wholesalecost = Turnintoint(wholesaleTB.Text);
            float markuppersentage = Turnintoint(markupTB.Text);
            if (wholesalecost > -1 && markuppersentage > -1)
            {
                //(((wholesalecost / 100) * markuppersentage) + wholesalecost)
                float totalcost = (((wholesalecost / 100) * markuppersentage) + wholesalecost);
                totalcostLB.Text = totalcost.ToString();
            }
        }

        private void wholesaleTB_TextChanged(object sender, EventArgs e)
        {
            CalculateRetail();
        }

        private void markupTB_TextChanged(object sender, EventArgs e)
        {
            CalculateRetail();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centercontrol(totalcostLB, bufferheight: 35);
            //
            centercontrol(inputGB, -5, -30);
        }
    }
}

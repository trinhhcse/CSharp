using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            AlignmentTitle();
        }
        private void AlignmentTitle()
        {
            Graphics g = this.CreateGraphics();
            double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width/2);
            double widthOfSpace = g.MeasureString(" ", this.Font).Width;
            string tmp = " ";
            double widthOfTmp = 0;
            while ((widthOfSpace + widthOfTmp) < startingPoint)
            {
                tmp += " ";
                widthOfTmp += widthOfSpace;
            }
            MessageBox.Show(tmp);
            MessageBox.Show(tmp+this.Text);
            this.Text = tmp + this.Text.Trim() + tmp;
        }
    }
}

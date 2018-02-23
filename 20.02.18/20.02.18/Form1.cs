using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._02._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var leftpos = 0;
            var topPos = 0;
            for (int J = 0; J <8; J++)
            {

                for (int i = 0; i < 8; i++)
                {
                    Button btn = new Button();
                     
                    this.Width = 8 * btn.Width + 17;
                    
                    btn.Left = leftpos;
                    btn.Top = topPos;
                    leftpos += btn.Width;
                    if ((i + J) % 2 == 0)
                    {
                        btn.BackColor = Color.Black;
                    }
                    else
                    {
                        btn.BackColor = Color.White;
                    }
                    Controls.Add(btn);
                }
                topPos += 30;
                leftpos = 0;
            }

        }
    }
}

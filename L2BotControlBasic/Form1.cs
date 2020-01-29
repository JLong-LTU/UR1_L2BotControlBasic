using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2BotControlBasic
{
    public partial class Form1 : Form
    {
        private LoCoMoCoTest.LoCoMoCo Robot { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Robot = new LoCoMoCoTest.LoCoMoCo("COM6");
        }


        // Button Control:
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            directionLabel.Text = "Direction: Forward";
            Robot.Move(LoCoMoCoTest.LoCoMoCo.BACKWARD, LoCoMoCoTest.LoCoMoCo.BACKWARD);
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            directionLabel.Text = "Direction: Reverse";
            Robot.Move(LoCoMoCoTest.LoCoMoCo.FORWARD, LoCoMoCoTest.LoCoMoCo.FORWARD);
        }

        private void coastButton_Click(object sender, EventArgs e)
        {
            directionLabel.Text = "Direction: Coast";
            Robot.Move(LoCoMoCoTest.LoCoMoCo.FLOAT, LoCoMoCoTest.LoCoMoCo.FLOAT);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            directionLabel.Text = "Direction: Left";
            Robot.Move(LoCoMoCoTest.LoCoMoCo.FORWARD, LoCoMoCoTest.LoCoMoCo.BACKWARD);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            directionLabel.Text = "Direction: Right";
            Robot.Move(LoCoMoCoTest.LoCoMoCo.BACKWARD, LoCoMoCoTest.LoCoMoCo.FORWARD);
        }


        // Arrow Key Control
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                directionLabel.Text = "Direction: Forward";
                Robot.Move(LoCoMoCoTest.LoCoMoCo.BACKWARD, LoCoMoCoTest.LoCoMoCo.BACKWARD);
            }
            else if(e.KeyCode == Keys.S)
            {
                directionLabel.Text = "Direction: Reverse";
                Robot.Move(LoCoMoCoTest.LoCoMoCo.FORWARD, LoCoMoCoTest.LoCoMoCo.FORWARD);
            }
            else if (e.KeyCode == Keys.D)
            {
                directionLabel.Text = "Direction: Right";
                Robot.Move(LoCoMoCoTest.LoCoMoCo.BACKWARD, LoCoMoCoTest.LoCoMoCo.FORWARD);
            }
            else if (e.KeyCode == Keys.A)
            {
                directionLabel.Text = "Direction: Left";
                Robot.Move(LoCoMoCoTest.LoCoMoCo.FORWARD, LoCoMoCoTest.LoCoMoCo.BACKWARD);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Robot.Move(LoCoMoCoTest.LoCoMoCo.FLOAT, LoCoMoCoTest.LoCoMoCo.FLOAT);
        }

        
    }
}

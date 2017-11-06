using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace QuickKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        InputSimulator input = new InputSimulator();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread.Sleep(timeout * 10);
            if (radioButton1.Checked)
            {
                Pegelschrieb();
            }
            else
            {
                Distribution();
            }
            button1.Enabled = true;
        }
        private int timeout = 500;
        private int shortTimeout = 50;
        private int longTimeOut = 4000;
        private int superlongTimeout = 8000;

        private void Pegelschrieb()
        {
            int max = (checkBox1.Checked) ? 31 : 30;

            for (int i = 0; i < max; i++)
            {
                /*
                input.Keyboard.KeyPress(VirtualKeyCode.PRIOR); //PAGE UP
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.PRIOR);
                Thread.Sleep(longTimeOut);
                */
                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_G); //PAGE UP
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.TAB);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.TAB);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.UP);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(longTimeOut);

                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(superlongTimeout);
            }
        }

        private void Distribution()
        {
            for (int i = 0; i < 170; i++)
            {
                input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                Thread.Sleep(timeout);
                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(superlongTimeout * 2);
                MessageBox.Show("Cherety");
                input.Keyboard.KeyPress(VirtualKeyCode.MENU); //ALT
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

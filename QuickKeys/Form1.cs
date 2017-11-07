using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using Microsoft.Office.Interop.Word;

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
        private string docname;

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
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);
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
            docname = "Document 2017-11-07_07-58-14-791.docx";
            for (int i = 0; i < 250; i++)
            {

                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
                Thread.Sleep(timeout);
                AppendText(Clipboard.GetText() + "\r\n" + i + "\r\n");
                //Thread.Sleep(timeout);
                //input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                Thread.Sleep(timeout);
                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(superlongTimeout * 2);

                input.Keyboard.KeyPress((VirtualKeyCode)Keys.LMenu); //ALT
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                Thread.Sleep(timeout);

                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                Thread.Sleep(timeout);
                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(superlongTimeout * 2);

                input.Keyboard.KeyPress((VirtualKeyCode)Keys.LMenu); //ALT
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                Thread.Sleep(timeout);

                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendText("olalal");
        }

        private void AppendText(string text)
        {
            input.Keyboard.ModifiedKeyStroke((VirtualKeyCode)Keys.LWin, VirtualKeyCode.VK_R);
            Thread.Sleep(shortTimeout);
            string swag = "taskkill /f /im winword.exe";
            Clipboard.SetText(swag);
            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(shortTimeout);
            input.Keyboard.ModifiedKeyStroke((VirtualKeyCode)Keys.LMenu, VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);

            string path = Environment.GetEnvironmentVariable("tmp") + "\\";
            path += docname;
            try
            {
                Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application();
                oWord.Visible = false;
                //MessageBox.Show(path);
                //oWord.Documents.Open(path);
                oWord.Documents.Open("\"" + path + "\"");
                //MessageBox.Show("Could open");
                oWord.ActiveDocument.Characters.Last.Select(); // Line 1
                oWord.Selection.Collapse(); // Line 2
                oWord.Selection.TypeText(text);
                oWord.ActiveDocument.Save();
                oWord.Quit();
                //MessageBox.Show("The text is inserted.");
            }
            catch (Exception)
            {
                //MessageBox.Show("Please right click on the window and provide the path");
                File.AppendAllText(path + "__QuickLog.txt", text);
            }
            // Document

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //Process.Start("cmd.exe", swag);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

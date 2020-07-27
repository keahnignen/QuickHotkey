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
            //Thread.Sleep(1000);
            //var x = Cursor.Position.X;
            //var y = Cursor.Position.Y;
            //MessageBox.Show($"x: {x} y: {y}");
        }

        InputSimulator input = new InputSimulator();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Thread.Sleep(timeout * 10);

            if (radioButton1.Checked)
            {
                Pegelschrieb();
            }

            if (rdoDistribution.Checked)
            {
                Distribution(true);
            }

            if (radioButton3.Checked)
            {
                PDF();
            }

            if (radioButton4.Checked)
            {
                Marker();
            }

            if (rdoNewDistribution.Checked)
            {
                NewDistribution();
            }

            if (rdoAppendDistribution.Checked)
            {
                AppendDistribution();
            }

            if (rdoDatedependingDistrivution.Checked)
            {
                DateDependingDistribution();
            }

            PlaySound();
            this.Show();
        }

        private void DateDependingDistribution()
        {
            throw new NotImplementedException();
        }

        private void AppendDistribution()
        {
            /*
            Cursor.Position = new Point(1258, 486);
            Thread.Sleep(timeout);
            input.Mouse.RightButtonClick();
            Thread.Sleep(timeout);


            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_H);
            Thread.Sleep(timeout);
            object clipboard = Clipboard.GetData(DataFormats.StringFormat);
            Clipboard.SetText("^p");
            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            Thread.Sleep(timeout);
            Clipboard.SetData(DataFormats.StringFormat, clipboard);

            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(longTimeOut);
            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(longTimeOut);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.TAB);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(longTimeOut);
            */

            var x = 1456;
            var y = 525;

            int max = (int) numericUpDown1.Value;
            for (int i = 0; i < max; i++)
            {
                Cursor.Position = new Point(x, y);
                Thread.Sleep(shortTimeout);

                input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);
                input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);

                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_X);
                Thread.Sleep(timeout);


                var newx = 58 - x;
                var newY = 673 - y;


                Cursor.Position = new Point(203, 486);
                Thread.Sleep(timeout);
                input.Mouse.LeftButtonClick();
                //input.Mouse.LeftButtonUp();
                Thread.Sleep(shortTimeout);
                input.Mouse.LeftButtonClick();
                //input.Mouse.LeftButtonUp();
                Thread.Sleep(shortTimeout);
                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);

                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.NEXT); //PageDown
                Thread.Sleep(shortTimeout);
            }
        }

        private void NewDistribution()
        {
            int max = (int) numericUpDown1.Value;


            SaveCurrentDistributionRow(true);
            max -= 1;
            for (int i = 0; i < max; i++)
            {
                SaveCurrentDistributionRow();
            }
        }

        private void SaveCurrentDistributionRow(bool itsItTheFirstRow = false)
        {
            if (!itsItTheFirstRow)
            {
                SaveDistributionSheet();
            }

            PressReturn();
            PressLeft();
            PressRight(true);

            /*
            input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
            Thread.Sleep(timeout);
            */

            SaveDistributionSheet();

            PressReturn();

            PressLeft();

            /*
            input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
            Thread.Sleep(timeout);
            */

            input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
            Thread.Sleep(timeout);

            PressRight(false);
        }


        private void PressLeft() => PressButton(VirtualKeyCode.LEFT, 20, shortTimeout);

        private int NudRightSteps() => (int)numericUpDown2.Value;

        private void PressRight(bool addOne) => PressButton(VirtualKeyCode.RIGHT, (addOne) ? NudRightSteps()+1 : NudRightSteps(), shortTimeout);

        private void PressReturn() => PressButton(VirtualKeyCode.RETURN, 10, shortTimeout);

        private void PressButton(VirtualKeyCode keyCode, int multiplier, int timeoutAfter)
        {
            for (int i = 0; i < multiplier; i++)
            {
                input.Keyboard.KeyPress(keyCode);
                Thread.Sleep(timeoutAfter);
            }
        }

        private void SaveDistributionSheet()
        {
            input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
            Thread.Sleep(timeout);
            SaveInDocument();
            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.F4);
            Thread.Sleep(timeout);
        }

        private void Marker()
        {
            while (true)
            {
                Cursor.Position = new Point(3072, 911);
                Thread.Sleep(timeout);
                input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);

                Cursor.Position = new Point(2177, 100);
                Thread.Sleep(timeout);
                input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);
                Cursor.Position = new Point(2899, 409);
                Thread.Sleep(timeout);
                input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);


                SaveInDocument();
            }
        }

        private int timeout = 500;
        private int shortTimeout = 50;
        private int longTimeOut = 4000;
        private int superlongTimeout = 8000;
        private string docname;

        private void PDF()
        {
            for (int i = 0; i < 10; i++)
            {
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(longTimeOut);
                input.Keyboard.KeyPress((VirtualKeyCode) Keys.LMenu); //ALT
                Thread.Sleep(timeout);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_D);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_T);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.TAB);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_P);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(longTimeOut * 2);

                input.Keyboard.ModifiedKeyStroke((VirtualKeyCode) Keys.LMenu, VirtualKeyCode.F4);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);
            }
        }


        private void Pegelschrieb()
        {
            int max = (int) numericUpDown1.Value;

            for (int i = 0; i < max; i++)
            {
                /*
                input.Keyboard.KeyPress(VirtualKeyCode.PRIOR); //PAGE UP
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.PRIOR);
                Thread.Sleep(longTimeOut);
                */
                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_G);
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
                //input.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                //input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                Thread.Sleep(shortTimeout);

                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                //input.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                //input.Keyboard.KeyPress(VirtualKeyCode.VK_0);
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

                SaveInDocument();
            }
        }

        private void PlaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"FinishSound.wav");
            player.Play();
        }

        private void SaveInDocument()
        {
            input.Mouse.RightButtonClick();
            Thread.Sleep(timeout);
            input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
            Thread.Sleep(timeout);
            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(superlongTimeout);
        }

        private void AppendFile(bool skip = false)
        {
            if (skip)
            {
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);

                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
                Thread.Sleep(timeout * 2);

                string path = Environment.GetEnvironmentVariable("tmp") + "\\";
                File.AppendAllText(path + "__otherlog.txt", Clipboard.GetText() + DateTime.Now.ToString("O") + "\r\n");
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                Thread.Sleep(timeout);
                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_G);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(longTimeOut);
                input.Keyboard.ModifiedKeyStroke((VirtualKeyCode) Keys.LWin, VirtualKeyCode.VK_2);
                Thread.Sleep(shortTimeout);
                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LMENU, VirtualKeyCode.F4);
                Thread.Sleep(timeout);
                input.Mouse.LeftButtonClick();
                Thread.Sleep(shortTimeout);
            }
            else
            {
                input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                Thread.Sleep(timeout);
                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(longTimeOut);
            }


            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.F4);
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
            Thread.Sleep(longTimeOut);


            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.F4);
            Thread.Sleep(timeout);

            input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
            Thread.Sleep(shortTimeout);
        }

        private void Distribution(bool bla = false)
        {
            for (int y = 0; y < 6; y++)
            {
                AppendFile(true);
                for (int i = 0; i < 30; i++)
                {
                    AppendFile();
                }
            }
        }

        private void Distribution()
        {
            Thread.Sleep(timeout);
            docname = "Document 2017-11-07_07-58-14-791.docx";
            for (int i = 0; i < 190; i++)
            {
                input.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                Thread.Sleep(timeout);
                input.Mouse.RightButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                Thread.Sleep(superlongTimeout * 2);

                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.F4);
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

                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.F4);
                Thread.Sleep(timeout);

                input.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                Thread.Sleep(timeout);

                input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
                Thread.Sleep(timeout * 2);
                //Thread.Sleep(timeout);
                //input.Mouse.LeftButtonClick();
                Thread.Sleep(timeout);
                input.Keyboard.ModifiedKeyStroke((VirtualKeyCode) Keys.LMenu, VirtualKeyCode.TAB);
                Thread.Sleep(shortTimeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(timeout);
                input.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                Thread.Sleep(timeout);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WriteLog("olalal");
        }

        private void WriteLog(string text)
        {
            input.Keyboard.ModifiedKeyStroke((VirtualKeyCode) Keys.LWin, VirtualKeyCode.VK_R);
            Thread.Sleep(shortTimeout);
            string swag = "taskkill /f /im winword.exe";
            Clipboard.SetText(swag);
            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            Thread.Sleep(shortTimeout);
            input.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(shortTimeout);


            string path = Environment.GetEnvironmentVariable("tmp") + "\\";


            string doucments = path + txtBox.Text;

            if (!File.Exists(doucments)) throw new Exception("asdasd");

            try
            {
                File.AppendAllText(path + "__otherlog.txt", text);
                Microsoft.Office.Interop.Word.Application oWord = new Microsoft.Office.Interop.Word.Application();
                oWord.Visible = false;
                //MessageBox.Show(path);
                //oWord.Documents.Open(path);
                oWord.Documents.Open("\"" + doucments + "\"");
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

        public static void ChangeDate()
        {
            while (true)
            {
                StartCmd();
                Thread.Sleep(1000);
            }
        }

        private void PressKey(VirtualKeyCode  key, int Timeout = 1000)
        {
            input.Keyboard.KeyPress(key);
            Thread.Sleep(Timeout);
        }

        private void PressKey(VirtualKeyCode modifedKey, VirtualKeyCode key, int Timeout = 1000)
        {
            input.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            Thread.Sleep(shortTimeout);
        }

        public static void StartCmd()
        {
            var strCmdText = $@" /C date 16-05-2018";


            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Verb = "runas";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
            //process.Close();
        }

        private void AppendText(string text)
        {
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdoAppendDistribution_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
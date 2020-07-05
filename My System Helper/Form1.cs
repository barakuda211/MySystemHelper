using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace My_System_Helper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            main_ref = this;
            Recognition();  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AppendTextBox("Welcome!");
        }

        public void AppendTextBox(string text)
        {
            textBox.AppendText(text + Environment.NewLine);
        }

        public void DoCommand(string command)
        {
            switch (command)
            {
                case "закрыть":
                    Environment.Exit(0);
                    return;
                case "паблик":
                    System.Diagnostics.Process.Start("https://vk.com/jojobrazzers");
                    return;
                case "элэс":
                    System.Diagnostics.Process.Start("https://vk.com/im");
                    return;
                case "яндекс":
                    System.Diagnostics.Process.Start("https://ya.ru");
                    return;
                case "гугл":
                    System.Diagnostics.Process.Start("https://google.com");
                    return;
                case "гугл картинки":
                    System.Diagnostics.Process.Start("https://www.google.ru/imghp?hl=ru");
                    return;
                case "яндекс картинки":
                    System.Diagnostics.Process.Start("https://yandex.ru/images/");
                    return;
            }
        }

    }
}

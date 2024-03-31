using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Valute
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1: case 2:
                        this.BackColor = Color.White;
                        ProgramNameLabel.ForeColor = Color.Empty;
                        ProgramVersionLabel.ForeColor = Color.Empty;
                        ProgramDeveloperLabel.ForeColor = Color.Empty;
                        ProgramDescriptionLabel.ForeColor = Color.Empty;
                        button1.BackColor = Color.White;
                        button1.ForeColor = Color.Empty;
                        button2.BackColor = Color.White;
                        button2.ForeColor = Color.Empty;
                        button3.BackColor = Color.White;
                        button3.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.FromArgb(255, 32, 32, 33);
                        ProgramNameLabel.ForeColor = Color.White;
                        ProgramVersionLabel.ForeColor = Color.White;
                        ProgramDeveloperLabel.ForeColor = Color.White;
                        ProgramDescriptionLabel.ForeColor = Color.White;
                        button1.BackColor = Color.FromArgb(255, 48, 49, 49);
                        button1.ForeColor = Color.White;
                        button2.BackColor = Color.FromArgb(255, 48, 49, 49);
                        button2.ForeColor = Color.White;
                        button3.BackColor = Color.FromArgb(255, 48, 49, 49);
                        button3.ForeColor = Color.White;
                        break;
                }
            } else
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                        switch ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1))
                        {
                            case 0:
                                this.BackColor = Color.FromArgb(255, 32, 32, 33);
                                ProgramNameLabel.ForeColor = Color.White;
                                ProgramVersionLabel.ForeColor = Color.White;
                                ProgramDeveloperLabel.ForeColor = Color.White;
                                ProgramDescriptionLabel.ForeColor = Color.White;
                                button1.BackColor = Color.FromArgb(255, 48, 49, 49);
                                button1.ForeColor = Color.White;
                                button2.BackColor = Color.FromArgb(255, 48, 49, 49);
                                button2.ForeColor = Color.White;
                                button3.BackColor = Color.FromArgb(255, 48, 49, 49);
                                button3.ForeColor = Color.White;
                                break;
                            case 1:
                                this.BackColor = Color.White;
                                ProgramNameLabel.ForeColor = Color.Empty;
                                ProgramVersionLabel.ForeColor = Color.Empty;
                                ProgramDeveloperLabel.ForeColor = Color.Empty;
                                ProgramDescriptionLabel.ForeColor = Color.Empty;
                                button1.BackColor = Color.White;
                                button1.ForeColor = Color.Empty;
                                button2.BackColor = Color.White;
                                button2.ForeColor = Color.Empty;
                                button3.BackColor = Color.White;
                                button3.ForeColor = Color.Empty;
                                break;
                        }
                        break;
                    case 2:
                        this.BackColor = Color.White;
                        ProgramNameLabel.ForeColor = Color.Empty;
                        ProgramVersionLabel.ForeColor = Color.Empty;
                        ProgramDeveloperLabel.ForeColor = Color.Empty;
                        ProgramDescriptionLabel.ForeColor = Color.Empty;
                        button1.BackColor = Color.White;
                        button1.ForeColor = Color.Empty;
                        button2.BackColor = Color.White;
                        button2.ForeColor = Color.Empty;
                        button3.BackColor = Color.White;
                        button3.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.FromArgb(255, 32, 32, 33);
                        ProgramNameLabel.ForeColor = Color.White;
                        ProgramVersionLabel.ForeColor = Color.White;
                        ProgramDeveloperLabel.ForeColor = Color.White;
                        ProgramDescriptionLabel.ForeColor = Color.White;
                        button1.BackColor = Color.FromArgb(255, 48, 49, 49);
                        button1.ForeColor = Color.White;
                        button2.BackColor = Color.FromArgb(255, 48, 49, 49);
                        button2.ForeColor = Color.White;
                        button3.BackColor = Color.FromArgb(255, 48, 49, 49);
                        button3.ForeColor = Color.White;
                        break;
                }
            }
            if (!Properties.Settings.Default.UseEnglishLanguage)
            {
                Text = "Про програму";
                ProgramVersionLabel.Text = "Версія 1.2";
                ProgramDeveloperLabel.Text = "Розробник: MaksimCeleron";
                ProgramDescriptionLabel.Text = "Конвертер валют, написаний на C#";
                button1.Text = "YouTube канал";
                button2.Text = "Telegram канал";
            } else
            {
                Text = "About";
                ProgramVersionLabel.Text = "Version 1.2";
                ProgramDeveloperLabel.Text = "Developer: MaksimCeleron";
                ProgramDescriptionLabel.Text = "Currency converter, written on C#";
                button1.Text = "YouTube channel";
                button2.Text = "Telegram channel";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCR7RC5PCfs4-RZz6TUrBQDA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/MaksimCeleronCh");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MaksimCeleron");
        }
    }
}

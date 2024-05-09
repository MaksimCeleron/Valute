using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Microsoft.Win32;

namespace Valute
{
    public partial class ValuteForm : Form
    {
        double convertationresult = 0;
        Converter converter = null;
        bool changecurrencydisplay = false;

        public ValuteForm()
        {
            converter = new Converter();

            InitializeComponent();
        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {
            RatesToolStripMenuItem.Text = "1 UAH - " + Math.Round(converter.GetCurrencies()[12].GetRate(), 2) + " USD";

            if (!Properties.Settings.Default.CodeCurrencyDisplay && !Properties.Settings.Default.UseEnglishLanguage)
            {
                назваToolStripMenuItem_Click(назваToolStripMenuItem, null);
            } else
            {
                кодToolStripMenuItem_Click(кодToolStripMenuItem, null);
            }
            if (!Properties.Settings.Default.AlwaysShowFullCount)
            {
                приУтримуванніCtrlFToolStripMenuItem_Click(приУтримуванніCtrlFToolStripMenuItem, null);
            } else
            {
                завждиToolStripMenuItem_Click(завждиToolStripMenuItem, null);
            }
            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                SystemToolStripMenuItem.Available = false;

                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                    case 2:
                        LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                        break;
                    case 3:
                        DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                        break;
                }
            }
            else
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                        SystemToolStripMenuItem_Click(SystemToolStripMenuItem, null);
                        break;
                    case 2:
                        LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                        break;
                    case 3:
                        DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                        break;
                }
            }
            if (!Properties.Settings.Default.UseEnglishLanguage)
            {
                українськаToolStripMenuItem_Click(українськаToolStripMenuItem, null);
            } else
            {
                англійськаToolStripMenuItem_Click(англійськаToolStripMenuItem, null);
            }
        }

        private void CurrencyCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrencyCountTextBox.Text == "")
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            } else
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }

                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) && (e.KeyChar != ',' || !char.IsDigit(CurrencyCountTextBox.Text.Last()) || CurrencyCountTextBox.Text.Contains(','));
            }
        }

        private void DisableInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RemoveSelectedSourceCurrency(object sender, EventArgs e)
        {
            string selectedconvertcurrencystring = ConvertCurrencyComboBox.Text;
            int selectedconvertcurrencyint = 0;
            
            ConvertCurrencyComboBox.Items.Clear();
            if (Properties.Settings.Default.UseEnglishLanguage)
            {
                for (int repeats = 0; repeats < converter.GetCurrencies().Count; repeats++)
                {
                    ConvertCurrencyComboBox.Items.Add(converter.GetCurrencies()[repeats].GetCode());
                }
            } else
            {
                if (!Properties.Settings.Default.CodeCurrencyDisplay)
                {
                    for (int repeats = 0; repeats < converter.GetCurrencies().Count; repeats++)
                    {
                        ConvertCurrencyComboBox.Items.Add(converter.GetCurrencies()[repeats].GetName());
                    }
                } else
                {
                    for (int repeats = 0; repeats < converter.GetCurrencies().Count; repeats++)
                    {
                        ConvertCurrencyComboBox.Items.Add(converter.GetCurrencies()[repeats].GetCode());
                    }
                }
            }
            ConvertCurrencyComboBox.Items.RemoveAt(SourceCurrencyComboBox.SelectedIndex);
            if (SourceCurrencyComboBox.Text == ConvertCurrencyComboBox.Text)
            {
                ConvertCurrencyComboBox.SelectedIndex = 0;
            } else if (!changecurrencydisplay)
            {
                foreach (string currency in ConvertCurrencyComboBox.Items)
                {
                    if (currency == selectedconvertcurrencystring)
                    {
                        break;
                    } else
                    {
                        selectedconvertcurrencyint++;
                    }
                }

                ConvertCurrencyComboBox.SelectedIndex = selectedconvertcurrencyint;
            }

            if (CurrencyCountTextBox.Text != "" && !changecurrencydisplay)
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = !Properties.Settings.Default.AlwaysShowFullCount ? Math.Round(convertationresult, 2).ToString() : convertationresult.ToString();
            }
        }

        private void SystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1))
            {
                case 0:
                    DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                    break;
                case 1:
                    LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                    break;
            }

            Properties.Settings.Default.Theme = 1;
            Properties.Settings.Default.Save();

            SystemToolStripMenuItem.Checked = true;
            LightToolStripMenuItem.Checked = false;
            DarkToolStripMenuItem.Checked = false;
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            MenuStrip.BackColor = Color.White;
            MenuStrip.ForeColor = Color.Black;
            відображенняВалютToolStripMenuItem.BackColor = Color.White;
            відображенняВалютToolStripMenuItem.ForeColor = Color.Empty;
            назваToolStripMenuItem.BackColor = Color.White;
            назваToolStripMenuItem.ForeColor = Color.Empty;
            кодToolStripMenuItem.BackColor = Color.White;
            кодToolStripMenuItem.ForeColor = Color.Empty;
            показПовноїКількостіToolStripMenuItem.BackColor = Color.White;
            показПовноїКількостіToolStripMenuItem.ForeColor = Color.Empty;
            приУтримуванніCtrlFToolStripMenuItem.BackColor = Color.White;
            приУтримуванніCtrlFToolStripMenuItem.ForeColor = Color.Empty;
            завждиToolStripMenuItem.BackColor = Color.White;
            завждиToolStripMenuItem.ForeColor = Color.Empty;
            ThemeToolStripMenuItem.BackColor = Color.White;
            ThemeToolStripMenuItem.ForeColor = Color.Empty;
            SystemToolStripMenuItem.BackColor = Color.White;
            SystemToolStripMenuItem.ForeColor = Color.Empty;
            LightToolStripMenuItem.BackColor = Color.White;
            LightToolStripMenuItem.ForeColor = Color.Empty;
            DarkToolStripMenuItem.BackColor = Color.White;
            DarkToolStripMenuItem.ForeColor = Color.Empty;
            моваToolStripMenuItem.BackColor = Color.White;
            моваToolStripMenuItem.ForeColor = Color.Empty;
            українськаToolStripMenuItem.BackColor = Color.White;
            українськаToolStripMenuItem.ForeColor = Color.Empty;
            англійськаToolStripMenuItem.BackColor = Color.White;
            англійськаToolStripMenuItem.ForeColor = Color.Empty;
            CurrencyCountGroupBox.BackColor = Color.Empty;
            CurrencyCountGroupBox.ForeColor = Color.Empty;
            SourceCurrencyGroupBox.BackColor = Color.Empty;
            SourceCurrencyGroupBox.ForeColor = Color.Empty;
            ConvertCurrencyGroupBox.BackColor = Color.Empty;
            ConvertCurrencyGroupBox.ForeColor = Color.Empty;
            ConvertationResultGroupBox.BackColor = Color.Empty;
            ConvertationResultGroupBox.ForeColor = Color.Empty;
            CurrencyCountTextBox.BackColor = Color.Empty;
            CurrencyCountTextBox.ForeColor = Color.Empty;
            SourceCurrencyComboBox.BackColor = Color.Empty;
            SourceCurrencyComboBox.ForeColor = Color.Empty;
            ConvertCurrencyComboBox.BackColor = Color.Empty;
            ConvertCurrencyComboBox.ForeColor = Color.Empty;
            ConvertationResultTextBox.BackColor = Color.Empty;
            ConvertationResultTextBox.ForeColor = Color.Empty;

            Properties.Settings.Default.Theme = 2;
            Properties.Settings.Default.Save();

            SystemToolStripMenuItem.Checked = false;
            LightToolStripMenuItem.Checked = true;
            DarkToolStripMenuItem.Checked = false;
        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 32, 32, 33);
            MenuStrip.BackColor = Color.FromArgb(255, 48, 49, 49);
            MenuStrip.ForeColor = Color.White;
            відображенняВалютToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            відображенняВалютToolStripMenuItem.ForeColor = Color.White;
            назваToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            назваToolStripMenuItem.ForeColor = Color.White;
            кодToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            кодToolStripMenuItem.ForeColor = Color.White;
            показПовноїКількостіToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            показПовноїКількостіToolStripMenuItem.ForeColor = Color.White;
            приУтримуванніCtrlFToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            приУтримуванніCtrlFToolStripMenuItem.ForeColor = Color.White;
            завждиToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            завждиToolStripMenuItem.ForeColor = Color.White;
            ThemeToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            ThemeToolStripMenuItem.ForeColor = Color.White;
            SystemToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            SystemToolStripMenuItem.ForeColor = Color.White;
            LightToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            LightToolStripMenuItem.ForeColor = Color.White;
            DarkToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            DarkToolStripMenuItem.ForeColor = Color.White;
            моваToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            моваToolStripMenuItem.ForeColor = Color.White;
            українськаToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            українськаToolStripMenuItem.ForeColor = Color.White;
            англійськаToolStripMenuItem.BackColor = Color.FromArgb(255, 48, 49, 49);
            англійськаToolStripMenuItem.ForeColor = Color.White;
            CurrencyCountGroupBox.BackColor = Color.FromArgb(255, 32, 32, 33);
            CurrencyCountGroupBox.ForeColor = Color.White;
            SourceCurrencyGroupBox.BackColor = Color.FromArgb(255, 32, 32, 33);
            SourceCurrencyGroupBox.ForeColor = Color.White;
            ConvertCurrencyGroupBox.BackColor = Color.FromArgb(255, 32, 32, 33);
            ConvertCurrencyGroupBox.ForeColor = Color.White;
            ConvertationResultGroupBox.BackColor = Color.FromArgb(255, 32, 32, 33);
            ConvertationResultGroupBox.ForeColor = Color.White;
            CurrencyCountTextBox.BackColor = Color.FromArgb(255, 48, 49, 49);
            CurrencyCountTextBox.ForeColor = Color.White;
            SourceCurrencyComboBox.BackColor = Color.FromArgb(255, 48, 49, 49);
            SourceCurrencyComboBox.ForeColor = Color.White;
            ConvertCurrencyComboBox.BackColor = Color.FromArgb(255, 48, 49, 49);
            ConvertCurrencyComboBox.ForeColor = Color.White;
            ConvertationResultTextBox.BackColor = Color.FromArgb(255, 48, 49, 49);
            ConvertationResultTextBox.ForeColor = Color.White;

            Properties.Settings.Default.Theme = 3;
            Properties.Settings.Default.Save();

            SystemToolStripMenuItem.Checked = false;
            LightToolStripMenuItem.Checked = false;
            DarkToolStripMenuItem.Checked = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AboutForm = new AboutForm();
            AboutForm.ShowDialog();
        }

        private void RatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RatesForm RatesForm = new RatesForm();
            RatesForm.ShowDialog();
        }

        private void ValuteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Properties.Settings.Default.AlwaysShowFullCount && Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F && convertationresult != 0)
            {
                ConvertationResultTextBox.Text = convertationresult.ToString();
            }
        }

        private void ValuteForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Properties.Settings.Default.AlwaysShowFullCount && Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F && convertationresult != 0)
            {
                ConvertationResultTextBox.Text = Math.Round(convertationresult, 2).ToString();
            }
        }

        private void назваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CodeCurrencyDisplay = false;
            Properties.Settings.Default.Save();

            int selectedsourcecurrency = SourceCurrencyComboBox.SelectedIndex != -1 ? SourceCurrencyComboBox.SelectedIndex : 0;
            int selectedconvertcurrency = ConvertCurrencyComboBox.SelectedIndex != -1 ? ConvertCurrencyComboBox.SelectedIndex : 0;
            changecurrencydisplay = true;
            SourceCurrencyComboBox.Items.Clear();
            foreach (var currency in converter.GetCurrencies())
            {
                SourceCurrencyComboBox.Items.Add(currency.GetName());
            }
            SourceCurrencyComboBox.SelectedIndex = selectedsourcecurrency;
            RemoveSelectedSourceCurrency(sender, e);
            ConvertCurrencyComboBox.SelectedIndex = selectedconvertcurrency;
            if (CurrencyCountTextBox.Text != "")
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = !Properties.Settings.Default.AlwaysShowFullCount ? Math.Round(convertationresult, 2).ToString() : convertationresult.ToString();
            }
            changecurrencydisplay = false;

            назваToolStripMenuItem.Checked = true;
            кодToolStripMenuItem.Checked = false;
        }

        private void кодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == кодToolStripMenuItem)
            {
                Properties.Settings.Default.CodeCurrencyDisplay = true;
                Properties.Settings.Default.Save();
            }

            int selectedsourcecurrency = SourceCurrencyComboBox.SelectedIndex != -1 ? SourceCurrencyComboBox.SelectedIndex : 0;
            int selectedconvertcurrency = ConvertCurrencyComboBox.SelectedIndex != -1 ? ConvertCurrencyComboBox.SelectedIndex : 0;
            changecurrencydisplay = true;
            SourceCurrencyComboBox.Items.Clear();
            foreach (var currency in converter.GetCurrencies())
            {
                SourceCurrencyComboBox.Items.Add(currency.GetCode());
            }
            SourceCurrencyComboBox.SelectedIndex = selectedsourcecurrency;
            RemoveSelectedSourceCurrency(sender, e);
            ConvertCurrencyComboBox.SelectedIndex = selectedconvertcurrency;
            if (CurrencyCountTextBox.Text != "")
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = !Properties.Settings.Default.AlwaysShowFullCount ? Math.Round(convertationresult, 2).ToString() : convertationresult.ToString();
            }
            changecurrencydisplay = false;

            назваToolStripMenuItem.Checked = false;
            кодToolStripMenuItem.Checked = true;
        }

        private void приУтримуванніCtrlFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrencyCountTextBox.Text != "")
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = Math.Round(convertationresult, 2).ToString();
            }

            Properties.Settings.Default.AlwaysShowFullCount = false;
            Properties.Settings.Default.Save();

            приУтримуванніCtrlFToolStripMenuItem.Checked = true;
            завждиToolStripMenuItem.Checked = false;
        }

        private void завждиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrencyCountTextBox.Text != "")
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = convertationresult.ToString();
            }

            Properties.Settings.Default.AlwaysShowFullCount = true;
            Properties.Settings.Default.Save();

            приУтримуванніCtrlFToolStripMenuItem.Checked = false;
            завждиToolStripMenuItem.Checked = true;
        }

        private void CurrencyCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CurrencyCountTextBox.Text != "")
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = !Properties.Settings.Default.AlwaysShowFullCount ? Math.Round(convertationresult, 2).ToString() : convertationresult.ToString();
            } else
            {
                ConvertationResultTextBox.Text = "";
            }
        }

        private void ConvertCurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrencyCountTextBox.Text != "" && !changecurrencydisplay)
            {
                convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
                ConvertationResultTextBox.Text = !Properties.Settings.Default.AlwaysShowFullCount ? Math.Round(convertationresult, 2).ToString() : convertationresult.ToString();
            }
        }

        private void українськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            налаштуванняToolStripMenuItem.Text = "Налаштування";
            відображенняВалютToolStripMenuItem.Text = "Відображення валют";
            назваToolStripMenuItem.Text = "Назва";
            кодToolStripMenuItem.Text = "Код";
            показПовноїКількостіToolStripMenuItem.Text = "Показ повної кількості";
            приУтримуванніCtrlFToolStripMenuItem.Text = "При утримуванні Ctrl+F";
            завждиToolStripMenuItem.Text = "Завжди";
            ThemeToolStripMenuItem.Text = "Тема";
            SystemToolStripMenuItem.Text = "Системна";
            LightToolStripMenuItem.Text = "Світла";
            DarkToolStripMenuItem.Text = "Темна";
            моваToolStripMenuItem.Text = "Мова";
            українськаToolStripMenuItem.Text = "Українська";
            англійськаToolStripMenuItem.Text = "Англійська";
            AboutToolStripMenuItem.Text = "Про програму";
            CurrencyCountGroupBox.Text = "Кількість валюти";
            SourceCurrencyGroupBox.Text = "Вихідна валюта";
            ConvertCurrencyGroupBox.Text = "Валюта для конвертації";
            ConvertationResultGroupBox.Text = "Результат конвертації";

            Properties.Settings.Default.UseEnglishLanguage = false;
            Properties.Settings.Default.Save();

            назваToolStripMenuItem.Enabled = true;
            кодToolStripMenuItem.Enabled = true;
            if (!Properties.Settings.Default.CodeCurrencyDisplay)
            {
                назваToolStripMenuItem_Click(назваToolStripMenuItem, null);
            }

            українськаToolStripMenuItem.Checked = true;
            англійськаToolStripMenuItem.Checked = false;
        }

        private void англійськаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            налаштуванняToolStripMenuItem.Text = "Settings";
            відображенняВалютToolStripMenuItem.Text = "Currency display";
            назваToolStripMenuItem.Text = "Name";
            кодToolStripMenuItem.Text = "Code";
            показПовноїКількостіToolStripMenuItem.Text = "Show full count";
            приУтримуванніCtrlFToolStripMenuItem.Text = "When holding Ctrl+F";
            завждиToolStripMenuItem.Text = "Always";
            ThemeToolStripMenuItem.Text = "Theme";
            SystemToolStripMenuItem.Text = "System";
            LightToolStripMenuItem.Text = "Light";
            DarkToolStripMenuItem.Text = "Dark";
            моваToolStripMenuItem.Text = "Language";
            українськаToolStripMenuItem.Text = "Ukrainian";
            англійськаToolStripMenuItem.Text = "English";
            AboutToolStripMenuItem.Text = "About";
            CurrencyCountGroupBox.Text = "Currency count";
            SourceCurrencyGroupBox.Text = "Source currency";
            ConvertCurrencyGroupBox.Text = "Convert currency";
            ConvertationResultGroupBox.Text = "Convertation result";

            Properties.Settings.Default.UseEnglishLanguage = true;
            Properties.Settings.Default.Save();

            кодToolStripMenuItem_Click(англійськаToolStripMenuItem, null);
            назваToolStripMenuItem.Enabled = false;
            кодToolStripMenuItem.Enabled = false;

            українськаToolStripMenuItem.Checked = false;
            англійськаToolStripMenuItem.Checked = true;
        }
    }

    public class Currency
    {
        string name = "";
        string code = "";
        double rate = 0;

        public Currency(string name, string code, double rate)
        {
            this.name = name;
            this.code = code;
            this.rate = rate;
        }

        public string GetName() => name;

        public string GetCode() => code;

        public double GetRate() => rate;
    }

    public class Converter
    {
        private List<Currency> currencies = null;
        private List<Currency> currencieswithoutuah = null;

        public Converter()
        {
            currencies = new List<Currency>();
            currencieswithoutuah = new List<Currency>();

            currencies.Add(new Currency("Українська гривня", "UAH", 1));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader streamreader = new StreamReader(stream);

            string data = streamreader.ReadToEnd();
            response.Close();
            
            dynamic converteddata = JsonConvert.DeserializeObject(data);
            for (int repeats = 0; repeats < converteddata.Count; repeats++)
            {
                string name = converteddata[repeats].txt;
                string code = converteddata[repeats].cc;
                double rate = converteddata[repeats].rate;
                currencies.Add(new Currency(name, code, rate));
            }
            currencies.Sort((left, right) => left.GetName().CompareTo(right.GetName()));

            currencieswithoutuah.AddRange(currencies);
            foreach (var currency in currencieswithoutuah)
            {
                if (currency.GetCode() == "UAH")
                {
                    currencieswithoutuah.Remove(currency);
                    break;
                }
            }
        }

        public List<Currency> GetCurrencies() => currencies;

        public List<Currency> GetCurrenciesWithoutUAH() => currencieswithoutuah;

        public double Convert(string currencycount, int sourcecurrency, string convertcurrency)
        {
            int correctconvertcurrency = 0;

            if (!Properties.Settings.Default.CodeCurrencyDisplay)
            {
                foreach (var currency in currencies)
                {
                    if (currency.GetName() == convertcurrency)
                    {
                        break;
                    } else
                    {
                        correctconvertcurrency++;
                    }
                }
            } else
            {
                foreach (var currency in currencies)
                {
                    if (currency.GetCode() == convertcurrency)
                    {
                        break;
                    }
                    else
                    {
                        correctconvertcurrency++;
                    }
                }
            }

            return System.Convert.ToDouble(currencycount) * (currencies[sourcecurrency].GetRate() / currencies[correctconvertcurrency].GetRate());
        }
    }
}

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

        public ValuteForm()
        {
            converter = new Converter();

            InitializeComponent();
        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {
            foreach (var currency in converter.GetCurrencies())
            {
                SourceCurrencyComboBox.Items.Add(currency.GetName());
            }
            SourceCurrencyComboBox.SelectedIndex = 0;
            RemoveSelectedSourceCurrency(sender, e);
            ConvertCurrencyComboBox.SelectedIndex = 0;

            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                AutoToolStripMenuItem.Available = false;

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
                        AutoToolStripMenuItem_Click(AutoToolStripMenuItem, null);
                        break;
                    case 2:
                        LightToolStripMenuItem_Click(LightToolStripMenuItem, null);
                        break;
                    case 3:
                        DarkToolStripMenuItem_Click(DarkToolStripMenuItem, null);
                        break;
                }
            }
        }

        private void CurrencyCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrencyCountTextBox.Text == "")
            {
                e.Handled = !char.IsDigit(e.KeyChar);
                ConvertButton.Enabled = true;
            } else
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }

                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) && (e.KeyChar != ',' || !char.IsDigit(CurrencyCountTextBox.Text.Last()) || CurrencyCountTextBox.Text.Contains(','));
                try
                {
                    ConvertButton.Enabled = (e.KeyChar != ',' || e.Handled) && (e.KeyChar != (char)Keys.Back || (CurrencyCountTextBox.Text[CurrencyCountTextBox.Text.Length - 2] != ',' && CurrencyCountTextBox.Text.Length != 1));
                } catch
                {
                    ConvertButton.Enabled = (e.KeyChar != ',' || e.Handled) && (e.KeyChar != (char)Keys.Back || CurrencyCountTextBox.Text.Length != 1);
                }
            }
        }

        private void DisableInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RemoveSelectedSourceCurrency(object sender, EventArgs e)
        {
            ConvertCurrencyComboBox.Items.Clear();
            for (int repeats = 0; repeats < converter.GetCurrencies().Count; repeats++)
            {
                ConvertCurrencyComboBox.Items.Add(converter.GetCurrencies()[repeats].GetName());
            }
            ConvertCurrencyComboBox.Items.RemoveAt(SourceCurrencyComboBox.SelectedIndex);
            if (SourceCurrencyComboBox.Text == ConvertCurrencyComboBox.Text)
            {
                ConvertCurrencyComboBox.SelectedIndex = 0;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            convertationresult = converter.Convert(CurrencyCountTextBox.Text, SourceCurrencyComboBox.SelectedIndex, ConvertCurrencyComboBox.Text);
            ConvertationResultTextBox.Text = Math.Round(convertationresult, 2).ToString();
        }

        private void AutoToolStripMenuItem_Click(object sender, EventArgs e)
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

            AutoToolStripMenuItem.Checked = true;
            LightToolStripMenuItem.Checked = false;
            DarkToolStripMenuItem.Checked = false;
        }

        private void LightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Empty;
            MenuStrip.BackColor = Color.FromArgb(255, 227, 227, 227);
            AutoToolStripMenuItem.BackColor = Color.Empty;
            AutoToolStripMenuItem.ForeColor = Color.Empty;
            LightToolStripMenuItem.BackColor = Color.Empty;
            LightToolStripMenuItem.ForeColor = Color.Empty;
            DarkToolStripMenuItem.BackColor = Color.Empty;
            DarkToolStripMenuItem.ForeColor = Color.Empty;
            CurrencyCountGroupBox.BackColor = Color.Empty;
            CurrencyCountGroupBox.ForeColor = Color.Empty;
            SourceCurrencyGroupBox.BackColor = Color.Empty;
            SourceCurrencyGroupBox.ForeColor = Color.Empty;
            ConvertCurrencyGroupBox.BackColor = Color.Empty;
            ConvertCurrencyGroupBox.ForeColor = Color.Empty;
            ConvertationResultGroupBox.BackColor = Color.Empty;
            ConvertationResultGroupBox.ForeColor = Color.Empty;

            Properties.Settings.Default.Theme = 2;
            Properties.Settings.Default.Save();

            AutoToolStripMenuItem.Checked = false;
            LightToolStripMenuItem.Checked = true;
            DarkToolStripMenuItem.Checked = false;
        }

        private void DarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            MenuStrip.BackColor = Color.LightGray;
            AutoToolStripMenuItem.BackColor = Color.Black;
            AutoToolStripMenuItem.ForeColor = Color.White;
            LightToolStripMenuItem.BackColor = Color.Black;
            LightToolStripMenuItem.ForeColor = Color.White;
            DarkToolStripMenuItem.BackColor = Color.Black;
            DarkToolStripMenuItem.ForeColor = Color.White;
            CurrencyCountGroupBox.BackColor = Color.Black;
            CurrencyCountGroupBox.ForeColor = Color.White;
            SourceCurrencyGroupBox.BackColor = Color.Black;
            SourceCurrencyGroupBox.ForeColor = Color.White;
            ConvertCurrencyGroupBox.BackColor = Color.Black;
            ConvertCurrencyGroupBox.ForeColor = Color.White;
            ConvertationResultGroupBox.BackColor = Color.Black;
            ConvertationResultGroupBox.ForeColor = Color.White;

            Properties.Settings.Default.Theme = 3;
            Properties.Settings.Default.Save();

            AutoToolStripMenuItem.Checked = false;
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
            if (e.KeyValue == (char)Keys.F && Control.ModifierKeys == Keys.Control && convertationresult != 0)
            {
                ConvertationResultTextBox.Text = convertationresult.ToString();
            }
        }

        private void ValuteForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F && Control.ModifierKeys == Keys.Control && convertationresult != 0)
            {
                ConvertationResultTextBox.Text = Math.Round(convertationresult, 2).ToString();
            }
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

            return System.Convert.ToDouble(currencycount) * (currencies[sourcecurrency].GetRate() / currencies[correctconvertcurrency].GetRate());
        }
    }
}

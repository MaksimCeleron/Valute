using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Valute
{
    public partial class ValuteWidgetForm : Form
    {
        double convertationresult = 0;
        Converter converter = null;

        public ValuteWidgetForm()
        {
            converter = new Converter();

            InitializeComponent();
        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {
            foreach (var currency in converter.GetCurrencies())
            {
                SourceCurrencyComboBox.Items.Add(currency.GetName());
                if (currency.GetCode() != "UAH")
                {
                    RatesListBox.Items.Add(currency.GetName() + '(' + currency.GetCode() + ") - " + Math.Round(currency.GetRate(), 2) + " Українська гривня");
                }
            }
            SourceCurrencyComboBox.SelectedIndex = 0;
            RemoveSelectedSourceCurrency(sender, e);
            ConvertCurrencyComboBox.SelectedIndex = 0;

            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                    case 2:
                        this.BackColor = Color.Empty;
                        ShowRatesToolStripMenuItem.BackColor = Color.Empty;
                        ShowRatesToolStripMenuItem.ForeColor = Color.Empty;
                        CurrencyCountGroupBox.BackColor = Color.Empty;
                        CurrencyCountGroupBox.ForeColor = Color.Empty;
                        ConvertationResultGroupBox.BackColor = Color.Empty;
                        ConvertationResultGroupBox.ForeColor = Color.Empty;
                        RatesListBox.BackColor = Color.Empty;
                        RatesListBox.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        ShowRatesToolStripMenuItem.BackColor = Color.Black;
                        ShowRatesToolStripMenuItem.ForeColor = Color.White;
                        CurrencyCountGroupBox.BackColor = Color.Black;
                        CurrencyCountGroupBox.ForeColor = Color.White;
                        ConvertationResultGroupBox.BackColor = Color.Black;
                        ConvertationResultGroupBox.ForeColor = Color.White;
                        RatesListBox.BackColor = Color.Black;
                        RatesListBox.ForeColor = Color.White;
                        break;
                }
            }
            else
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                        switch ((int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1))
                        {
                            case 0:
                                this.BackColor = Color.Black;
                                ShowRatesToolStripMenuItem.BackColor = Color.Black;
                                ShowRatesToolStripMenuItem.ForeColor = Color.White;
                                CurrencyCountGroupBox.BackColor = Color.Black;
                                CurrencyCountGroupBox.ForeColor = Color.White;
                                ConvertationResultGroupBox.BackColor = Color.Black;
                                ConvertationResultGroupBox.ForeColor = Color.White;
                                RatesListBox.BackColor = Color.Black;
                                RatesListBox.ForeColor = Color.White;
                                break;
                            case 1:
                                this.BackColor = Color.Empty;
                                ShowRatesToolStripMenuItem.BackColor = Color.Empty;
                                ShowRatesToolStripMenuItem.ForeColor = Color.Empty;
                                CurrencyCountGroupBox.BackColor = Color.Empty;
                                CurrencyCountGroupBox.ForeColor = Color.Empty;
                                ConvertationResultGroupBox.BackColor = Color.Empty;
                                ConvertationResultGroupBox.ForeColor = Color.Empty;
                                RatesListBox.BackColor = Color.Empty;
                                RatesListBox.ForeColor = Color.Empty;
                                break;
                        }
                        break;
                    case 2:
                        this.BackColor = Color.Empty;
                        ShowRatesToolStripMenuItem.BackColor = Color.Empty;
                        ShowRatesToolStripMenuItem.ForeColor = Color.Empty;
                        CurrencyCountGroupBox.BackColor = Color.Empty;
                        CurrencyCountGroupBox.ForeColor = Color.Empty;
                        ConvertationResultGroupBox.BackColor = Color.Empty;
                        ConvertationResultGroupBox.ForeColor = Color.Empty;
                        RatesListBox.BackColor = Color.Empty;
                        RatesListBox.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        ShowRatesToolStripMenuItem.BackColor = Color.Black;
                        ShowRatesToolStripMenuItem.ForeColor = Color.White;
                        CurrencyCountGroupBox.BackColor = Color.Black;
                        CurrencyCountGroupBox.ForeColor = Color.White;
                        ConvertationResultGroupBox.BackColor = Color.Black;
                        ConvertationResultGroupBox.ForeColor = Color.White;
                        RatesListBox.BackColor = Color.Black;
                        RatesListBox.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void CurrencyCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CurrencyCountTextBox.Text == "")
            {
                e.Handled = !char.IsDigit(e.KeyChar);
                ConvertButton.Enabled = !e.Handled;
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

        private void ShowRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowRatesToolStripMenuItem.Checked)
            {
                Height = 262;
                RatesListBox.Show();
            }
            else
            {
                Height = 135;
                RatesListBox.Hide();
            }
        }

        private void ValuteForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F && convertationresult != 0)
            {
                ConvertationResultTextBox.Text = convertationresult.ToString();
                for (int repeats = 0; repeats < RatesListBox.Items.Count; repeats++)
                {
                    RatesListBox.Items[repeats] = converter.GetCurrenciesWithoutUAH()[repeats].GetName() + '(' + converter.GetCurrenciesWithoutUAH()[repeats].GetCode() + ") - " + converter.GetCurrenciesWithoutUAH()[repeats].GetRate() + " Українська гривня";
                }
            } else if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F)
            {
                for (int repeats = 0; repeats < RatesListBox.Items.Count; repeats++)
                {
                    RatesListBox.Items[repeats] = converter.GetCurrenciesWithoutUAH()[repeats].GetName() + '(' + converter.GetCurrenciesWithoutUAH()[repeats].GetCode() + ") - " + converter.GetCurrenciesWithoutUAH()[repeats].GetRate() + " Українська гривня";
                }
            } else if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.M)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void ValuteForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F && convertationresult != 0)
            {
                ConvertationResultTextBox.Text = Math.Round(convertationresult, 2).ToString();
                for (int repeats = 0; repeats < RatesListBox.Items.Count; repeats++)
                {
                    RatesListBox.Items[repeats] = converter.GetCurrenciesWithoutUAH()[repeats].GetName() + '(' + converter.GetCurrenciesWithoutUAH()[repeats].GetCode() + ") - " + Math.Round(converter.GetCurrenciesWithoutUAH()[repeats].GetRate(), 2) + " Українська гривня";
                }
            } else if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F)
            {
                for (int repeats = 0; repeats < RatesListBox.Items.Count; repeats++)
                {
                    RatesListBox.Items[repeats] = converter.GetCurrenciesWithoutUAH()[repeats].GetName() + '(' + converter.GetCurrenciesWithoutUAH()[repeats].GetCode() + ") - " + Math.Round(converter.GetCurrenciesWithoutUAH()[repeats].GetRate(), 2) + " Українська гривня";
                }
            }
        }

        private void ValuteWidgetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ValuteForm ValuteForm = new ValuteForm();
            ValuteForm.Show();
        }
    }
}

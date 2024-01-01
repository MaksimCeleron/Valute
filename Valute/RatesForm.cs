using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Valute
{
    public partial class RatesForm : Form
    {
        Converter converter = new Converter();

        public RatesForm()
        {
            InitializeComponent();
        }

        private void RatesForm_Load(object sender, EventArgs e)
        {
            foreach (var currency in converter.GetCurrencies())
            {
                if (currency.GetCode() != "UAH")
                {
                    RatesListBox.Items.Add(currency.GetName() + '(' + currency.GetCode() + ") - " + Math.Round(currency.GetRate(), 2) + " Українська гривня");
                }
            }

            if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1) == null)
            {
                switch (Properties.Settings.Default.Theme)
                {
                    case 1:
                    case 2:
                        this.BackColor = Color.Empty;
                        RatesListBox.BackColor = Color.Empty;
                        RatesListBox.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
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
                                RatesListBox.BackColor = Color.Black;
                                RatesListBox.ForeColor = Color.White;
                                break;
                            case 1:
                                this.BackColor = Color.Empty;
                                RatesListBox.BackColor = Color.Empty;
                                RatesListBox.ForeColor = Color.Empty;
                                break;
                        }
                        break;
                    case 2:
                        this.BackColor = Color.Empty;
                        RatesListBox.BackColor = Color.Empty;
                        RatesListBox.ForeColor = Color.Empty;
                        break;
                    case 3:
                        this.BackColor = Color.Black;
                        RatesListBox.BackColor = Color.Black;
                        RatesListBox.ForeColor = Color.White;
                        break;
                }
            }
        }

        private void RatesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F)
            {
                for (int repeats = 0; repeats < RatesListBox.Items.Count; repeats++)
                {
                    RatesListBox.Items[repeats] = converter.GetCurrenciesWithoutUAH()[repeats].GetName() + '(' + converter.GetCurrenciesWithoutUAH()[repeats].GetCode() + ") - " + converter.GetCurrenciesWithoutUAH()[repeats].GetRate() + " Українська гривня";
                }
            }
        }

        private void RatesForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyValue == (char)Keys.F)
            {
                for (int repeats = 0; repeats < RatesListBox.Items.Count; repeats++)
                {
                    RatesListBox.Items[repeats] = converter.GetCurrenciesWithoutUAH()[repeats].GetName() + '(' + converter.GetCurrenciesWithoutUAH()[repeats].GetCode() + ") - " + Math.Round(converter.GetCurrenciesWithoutUAH()[repeats].GetRate(), 2) + " Українська гривня";
                }
            }
        }
    }
}

namespace Valute
{
    partial class ValuteForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValuteForm));
            this.CurrencyCountGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrencyCountTextBox = new System.Windows.Forms.TextBox();
            this.SourceCurrencyGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.ConvertCurrencyGroupBox = new System.Windows.Forms.GroupBox();
            this.ConvertCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.ConvertationResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ConvertationResultTextBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.RatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відображенняВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показПовноїКількостіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приУтримуванніCtrlFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завждиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.українськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.англійськаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrencyCountGroupBox.SuspendLayout();
            this.SourceCurrencyGroupBox.SuspendLayout();
            this.ConvertCurrencyGroupBox.SuspendLayout();
            this.ConvertationResultGroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrencyCountGroupBox
            // 
            this.CurrencyCountGroupBox.Controls.Add(this.CurrencyCountTextBox);
            this.CurrencyCountGroupBox.Location = new System.Drawing.Point(12, 27);
            this.CurrencyCountGroupBox.Name = "CurrencyCountGroupBox";
            this.CurrencyCountGroupBox.Size = new System.Drawing.Size(428, 45);
            this.CurrencyCountGroupBox.TabIndex = 1;
            this.CurrencyCountGroupBox.TabStop = false;
            this.CurrencyCountGroupBox.Text = "Кількість валюти";
            // 
            // CurrencyCountTextBox
            // 
            this.CurrencyCountTextBox.Location = new System.Drawing.Point(6, 19);
            this.CurrencyCountTextBox.Name = "CurrencyCountTextBox";
            this.CurrencyCountTextBox.Size = new System.Drawing.Size(416, 20);
            this.CurrencyCountTextBox.TabIndex = 2;
            this.CurrencyCountTextBox.TextChanged += new System.EventHandler(this.CurrencyCountTextBox_TextChanged);
            this.CurrencyCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrencyCountTextBox_KeyPress);
            // 
            // SourceCurrencyGroupBox
            // 
            this.SourceCurrencyGroupBox.Controls.Add(this.SourceCurrencyComboBox);
            this.SourceCurrencyGroupBox.Location = new System.Drawing.Point(12, 78);
            this.SourceCurrencyGroupBox.Name = "SourceCurrencyGroupBox";
            this.SourceCurrencyGroupBox.Size = new System.Drawing.Size(211, 45);
            this.SourceCurrencyGroupBox.TabIndex = 2;
            this.SourceCurrencyGroupBox.TabStop = false;
            this.SourceCurrencyGroupBox.Text = "Вихідна валюта";
            // 
            // SourceCurrencyComboBox
            // 
            this.SourceCurrencyComboBox.FormattingEnabled = true;
            this.SourceCurrencyComboBox.Location = new System.Drawing.Point(6, 18);
            this.SourceCurrencyComboBox.Name = "SourceCurrencyComboBox";
            this.SourceCurrencyComboBox.Size = new System.Drawing.Size(199, 21);
            this.SourceCurrencyComboBox.TabIndex = 1;
            this.SourceCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.RemoveSelectedSourceCurrency);
            this.SourceCurrencyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertCurrencyGroupBox
            // 
            this.ConvertCurrencyGroupBox.Controls.Add(this.ConvertCurrencyComboBox);
            this.ConvertCurrencyGroupBox.Location = new System.Drawing.Point(229, 78);
            this.ConvertCurrencyGroupBox.Name = "ConvertCurrencyGroupBox";
            this.ConvertCurrencyGroupBox.Size = new System.Drawing.Size(211, 45);
            this.ConvertCurrencyGroupBox.TabIndex = 3;
            this.ConvertCurrencyGroupBox.TabStop = false;
            this.ConvertCurrencyGroupBox.Text = "Валюта для конвертації";
            // 
            // ConvertCurrencyComboBox
            // 
            this.ConvertCurrencyComboBox.FormattingEnabled = true;
            this.ConvertCurrencyComboBox.Location = new System.Drawing.Point(6, 19);
            this.ConvertCurrencyComboBox.Name = "ConvertCurrencyComboBox";
            this.ConvertCurrencyComboBox.Size = new System.Drawing.Size(199, 21);
            this.ConvertCurrencyComboBox.TabIndex = 0;
            this.ConvertCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.ConvertCurrencyComboBox_SelectedIndexChanged);
            this.ConvertCurrencyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertationResultGroupBox
            // 
            this.ConvertationResultGroupBox.Controls.Add(this.ConvertationResultTextBox);
            this.ConvertationResultGroupBox.Location = new System.Drawing.Point(12, 129);
            this.ConvertationResultGroupBox.Name = "ConvertationResultGroupBox";
            this.ConvertationResultGroupBox.Size = new System.Drawing.Size(428, 45);
            this.ConvertationResultGroupBox.TabIndex = 2;
            this.ConvertationResultGroupBox.TabStop = false;
            this.ConvertationResultGroupBox.Text = "Результат конвертації";
            // 
            // ConvertationResultTextBox
            // 
            this.ConvertationResultTextBox.Location = new System.Drawing.Point(6, 19);
            this.ConvertationResultTextBox.Name = "ConvertationResultTextBox";
            this.ConvertationResultTextBox.Size = new System.Drawing.Size(416, 20);
            this.ConvertationResultTextBox.TabIndex = 1;
            this.ConvertationResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.White;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RatesToolStripMenuItem,
            this.налаштуванняToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(452, 24);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // RatesToolStripMenuItem
            // 
            this.RatesToolStripMenuItem.Name = "RatesToolStripMenuItem";
            this.RatesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.RatesToolStripMenuItem.Text = "1 UAH - - USD";
            this.RatesToolStripMenuItem.Click += new System.EventHandler(this.RatesToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відображенняВалютToolStripMenuItem,
            this.показПовноїКількостіToolStripMenuItem,
            this.ThemeToolStripMenuItem,
            this.моваToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // відображенняВалютToolStripMenuItem
            // 
            this.відображенняВалютToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.відображенняВалютToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назваToolStripMenuItem,
            this.кодToolStripMenuItem});
            this.відображенняВалютToolStripMenuItem.Name = "відображенняВалютToolStripMenuItem";
            this.відображенняВалютToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.відображенняВалютToolStripMenuItem.Text = "Відображення валют";
            // 
            // назваToolStripMenuItem
            // 
            this.назваToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.назваToolStripMenuItem.Name = "назваToolStripMenuItem";
            this.назваToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.назваToolStripMenuItem.Text = "Назва";
            this.назваToolStripMenuItem.Click += new System.EventHandler(this.назваToolStripMenuItem_Click);
            // 
            // кодToolStripMenuItem
            // 
            this.кодToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.кодToolStripMenuItem.Name = "кодToolStripMenuItem";
            this.кодToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.кодToolStripMenuItem.Text = "Код";
            this.кодToolStripMenuItem.Click += new System.EventHandler(this.кодToolStripMenuItem_Click);
            // 
            // показПовноїКількостіToolStripMenuItem
            // 
            this.показПовноїКількостіToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.показПовноїКількостіToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приУтримуванніCtrlFToolStripMenuItem,
            this.завждиToolStripMenuItem});
            this.показПовноїКількостіToolStripMenuItem.Name = "показПовноїКількостіToolStripMenuItem";
            this.показПовноїКількостіToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.показПовноїКількостіToolStripMenuItem.Text = "Показ повної кількості";
            // 
            // приУтримуванніCtrlFToolStripMenuItem
            // 
            this.приУтримуванніCtrlFToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.приУтримуванніCtrlFToolStripMenuItem.Name = "приУтримуванніCtrlFToolStripMenuItem";
            this.приУтримуванніCtrlFToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.приУтримуванніCtrlFToolStripMenuItem.Text = "При утримуванні Ctrl+F";
            this.приУтримуванніCtrlFToolStripMenuItem.Click += new System.EventHandler(this.приУтримуванніCtrlFToolStripMenuItem_Click);
            // 
            // завждиToolStripMenuItem
            // 
            this.завждиToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.завждиToolStripMenuItem.Name = "завждиToolStripMenuItem";
            this.завждиToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.завждиToolStripMenuItem.Text = "Завжди";
            this.завждиToolStripMenuItem.Click += new System.EventHandler(this.завждиToolStripMenuItem_Click);
            // 
            // ThemeToolStripMenuItem
            // 
            this.ThemeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.LightToolStripMenuItem,
            this.DarkToolStripMenuItem});
            this.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem";
            this.ThemeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ThemeToolStripMenuItem.Text = "Тема";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.SystemToolStripMenuItem.Text = "Системна";
            this.SystemToolStripMenuItem.Click += new System.EventHandler(this.SystemToolStripMenuItem_Click);
            // 
            // LightToolStripMenuItem
            // 
            this.LightToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.LightToolStripMenuItem.Name = "LightToolStripMenuItem";
            this.LightToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.LightToolStripMenuItem.Text = "Світла";
            this.LightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItem_Click);
            // 
            // DarkToolStripMenuItem
            // 
            this.DarkToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem";
            this.DarkToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.DarkToolStripMenuItem.Text = "Темна";
            this.DarkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.AboutToolStripMenuItem.Text = "Про програму";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // моваToolStripMenuItem
            // 
            this.моваToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.моваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.українськаToolStripMenuItem,
            this.англійськаToolStripMenuItem});
            this.моваToolStripMenuItem.Name = "моваToolStripMenuItem";
            this.моваToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.моваToolStripMenuItem.Text = "Мова";
            // 
            // українськаToolStripMenuItem
            // 
            this.українськаToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.українськаToolStripMenuItem.Name = "українськаToolStripMenuItem";
            this.українськаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.українськаToolStripMenuItem.Text = "Українська";
            this.українськаToolStripMenuItem.Click += new System.EventHandler(this.українськаToolStripMenuItem_Click);
            // 
            // англійськаToolStripMenuItem
            // 
            this.англійськаToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.англійськаToolStripMenuItem.Name = "англійськаToolStripMenuItem";
            this.англійськаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.англійськаToolStripMenuItem.Text = "Англійська";
            this.англійськаToolStripMenuItem.Click += new System.EventHandler(this.англійськаToolStripMenuItem_Click);
            // 
            // ValuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 186);
            this.Controls.Add(this.ConvertationResultGroupBox);
            this.Controls.Add(this.ConvertCurrencyGroupBox);
            this.Controls.Add(this.SourceCurrencyGroupBox);
            this.Controls.Add(this.CurrencyCountGroupBox);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "ValuteForm";
            this.Text = "Valute";
            this.Load += new System.EventHandler(this.ConverterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValuteForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValuteForm_KeyUp);
            this.CurrencyCountGroupBox.ResumeLayout(false);
            this.CurrencyCountGroupBox.PerformLayout();
            this.SourceCurrencyGroupBox.ResumeLayout(false);
            this.ConvertCurrencyGroupBox.ResumeLayout(false);
            this.ConvertationResultGroupBox.ResumeLayout(false);
            this.ConvertationResultGroupBox.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox CurrencyCountGroupBox;
        private System.Windows.Forms.GroupBox SourceCurrencyGroupBox;
        private System.Windows.Forms.GroupBox ConvertCurrencyGroupBox;
        private System.Windows.Forms.ComboBox ConvertCurrencyComboBox;
        private System.Windows.Forms.GroupBox ConvertationResultGroupBox;
        private System.Windows.Forms.ComboBox SourceCurrencyComboBox;
        private System.Windows.Forms.TextBox ConvertationResultTextBox;
        private System.Windows.Forms.TextBox CurrencyCountTextBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відображенняВалютToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показПовноїКількостіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приУтримуванніCtrlFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завждиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem українськаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem англійськаToolStripMenuItem;
    }
}


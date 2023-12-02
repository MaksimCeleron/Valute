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
            this.ConvertButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.RatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CurrencyCountGroupBox.Size = new System.Drawing.Size(427, 45);
            this.CurrencyCountGroupBox.TabIndex = 1;
            this.CurrencyCountGroupBox.TabStop = false;
            this.CurrencyCountGroupBox.Text = "Кількість валюти";
            // 
            // CurrencyCountTextBox
            // 
            this.CurrencyCountTextBox.Location = new System.Drawing.Point(6, 19);
            this.CurrencyCountTextBox.Name = "CurrencyCountTextBox";
            this.CurrencyCountTextBox.Size = new System.Drawing.Size(415, 20);
            this.CurrencyCountTextBox.TabIndex = 2;
            this.CurrencyCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrencyCountTextBox_KeyPress);
            // 
            // SourceCurrencyGroupBox
            // 
            this.SourceCurrencyGroupBox.Controls.Add(this.SourceCurrencyComboBox);
            this.SourceCurrencyGroupBox.Location = new System.Drawing.Point(12, 78);
            this.SourceCurrencyGroupBox.Name = "SourceCurrencyGroupBox";
            this.SourceCurrencyGroupBox.Size = new System.Drawing.Size(170, 45);
            this.SourceCurrencyGroupBox.TabIndex = 2;
            this.SourceCurrencyGroupBox.TabStop = false;
            this.SourceCurrencyGroupBox.Text = "Вибір вихідної валюти";
            // 
            // SourceCurrencyComboBox
            // 
            this.SourceCurrencyComboBox.FormattingEnabled = true;
            this.SourceCurrencyComboBox.Location = new System.Drawing.Point(6, 18);
            this.SourceCurrencyComboBox.Name = "SourceCurrencyComboBox";
            this.SourceCurrencyComboBox.Size = new System.Drawing.Size(158, 21);
            this.SourceCurrencyComboBox.TabIndex = 1;
            this.SourceCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.RemoveSelectedSourceCurrency);
            this.SourceCurrencyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertCurrencyGroupBox
            // 
            this.ConvertCurrencyGroupBox.Controls.Add(this.ConvertCurrencyComboBox);
            this.ConvertCurrencyGroupBox.Location = new System.Drawing.Point(269, 78);
            this.ConvertCurrencyGroupBox.Name = "ConvertCurrencyGroupBox";
            this.ConvertCurrencyGroupBox.Size = new System.Drawing.Size(170, 45);
            this.ConvertCurrencyGroupBox.TabIndex = 3;
            this.ConvertCurrencyGroupBox.TabStop = false;
            this.ConvertCurrencyGroupBox.Text = "Вибір валюти для конвертації";
            // 
            // ConvertCurrencyComboBox
            // 
            this.ConvertCurrencyComboBox.FormattingEnabled = true;
            this.ConvertCurrencyComboBox.Location = new System.Drawing.Point(6, 19);
            this.ConvertCurrencyComboBox.Name = "ConvertCurrencyComboBox";
            this.ConvertCurrencyComboBox.Size = new System.Drawing.Size(158, 21);
            this.ConvertCurrencyComboBox.TabIndex = 0;
            this.ConvertCurrencyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertationResultGroupBox
            // 
            this.ConvertationResultGroupBox.Controls.Add(this.ConvertationResultTextBox);
            this.ConvertationResultGroupBox.Location = new System.Drawing.Point(12, 129);
            this.ConvertationResultGroupBox.Name = "ConvertationResultGroupBox";
            this.ConvertationResultGroupBox.Size = new System.Drawing.Size(427, 45);
            this.ConvertationResultGroupBox.TabIndex = 2;
            this.ConvertationResultGroupBox.TabStop = false;
            this.ConvertationResultGroupBox.Text = "Результат конвертації";
            // 
            // ConvertationResultTextBox
            // 
            this.ConvertationResultTextBox.Location = new System.Drawing.Point(6, 19);
            this.ConvertationResultTextBox.Name = "ConvertationResultTextBox";
            this.ConvertationResultTextBox.Size = new System.Drawing.Size(415, 20);
            this.ConvertationResultTextBox.TabIndex = 1;
            this.ConvertationResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Enabled = false;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertButton.Location = new System.Drawing.Point(188, 78);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 45);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "➔";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RatesToolStripMenuItem,
            this.ThemeToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(451, 25);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // RatesToolStripMenuItem
            // 
            this.RatesToolStripMenuItem.Name = "RatesToolStripMenuItem";
            this.RatesToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.RatesToolStripMenuItem.Text = "Курси валют";
            this.RatesToolStripMenuItem.Click += new System.EventHandler(this.RatesToolStripMenuItem_Click);
            // 
            // ThemeToolStripMenuItem
            // 
            this.ThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoToolStripMenuItem,
            this.LightToolStripMenuItem,
            this.DarkToolStripMenuItem});
            this.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem";
            this.ThemeToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.ThemeToolStripMenuItem.Text = "Тема";
            // 
            // AutoToolStripMenuItem
            // 
            this.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem";
            this.AutoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AutoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.AutoToolStripMenuItem.Text = "Авто";
            this.AutoToolStripMenuItem.Click += new System.EventHandler(this.AutoToolStripMenuItem_Click);
            // 
            // LightToolStripMenuItem
            // 
            this.LightToolStripMenuItem.Name = "LightToolStripMenuItem";
            this.LightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LightToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.LightToolStripMenuItem.Text = "Світла";
            this.LightToolStripMenuItem.Click += new System.EventHandler(this.LightToolStripMenuItem_Click);
            // 
            // DarkToolStripMenuItem
            // 
            this.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem";
            this.DarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DarkToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.DarkToolStripMenuItem.Text = "Темна";
            this.DarkToolStripMenuItem.Click += new System.EventHandler(this.DarkToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.AboutToolStripMenuItem.Text = "Про програму";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ValuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 186);
            this.Controls.Add(this.ConvertButton);
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
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox CurrencyCountTextBox;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RatesToolStripMenuItem;
    }
}


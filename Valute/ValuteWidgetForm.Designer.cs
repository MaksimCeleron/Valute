namespace Valute
{
    partial class ValuteWidgetForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValuteWidgetForm));
            this.CurrencyCountGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrencyCountTextBox = new System.Windows.Forms.TextBox();
            this.SourceCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.ConvertCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.ConvertationResultGroupBox = new System.Windows.Forms.GroupBox();
            this.ConvertationResultTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RatesListBox = new System.Windows.Forms.ListBox();
            this.CurrencyCountGroupBox.SuspendLayout();
            this.ConvertationResultGroupBox.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrencyCountGroupBox
            // 
            this.CurrencyCountGroupBox.Controls.Add(this.SourceCurrencyComboBox);
            this.CurrencyCountGroupBox.Controls.Add(this.CurrencyCountTextBox);
            this.CurrencyCountGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CurrencyCountGroupBox.Name = "CurrencyCountGroupBox";
            this.CurrencyCountGroupBox.Size = new System.Drawing.Size(134, 72);
            this.CurrencyCountGroupBox.TabIndex = 1;
            this.CurrencyCountGroupBox.TabStop = false;
            this.CurrencyCountGroupBox.Text = "Кількість валюти";
            // 
            // CurrencyCountTextBox
            // 
            this.CurrencyCountTextBox.Location = new System.Drawing.Point(6, 19);
            this.CurrencyCountTextBox.Name = "CurrencyCountTextBox";
            this.CurrencyCountTextBox.Size = new System.Drawing.Size(122, 20);
            this.CurrencyCountTextBox.TabIndex = 2;
            this.CurrencyCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrencyCountTextBox_KeyPress);
            // 
            // SourceCurrencyComboBox
            // 
            this.SourceCurrencyComboBox.FormattingEnabled = true;
            this.SourceCurrencyComboBox.Location = new System.Drawing.Point(6, 45);
            this.SourceCurrencyComboBox.Name = "SourceCurrencyComboBox";
            this.SourceCurrencyComboBox.Size = new System.Drawing.Size(122, 21);
            this.SourceCurrencyComboBox.TabIndex = 1;
            this.SourceCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.RemoveSelectedSourceCurrency);
            this.SourceCurrencyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertCurrencyComboBox
            // 
            this.ConvertCurrencyComboBox.FormattingEnabled = true;
            this.ConvertCurrencyComboBox.Location = new System.Drawing.Point(6, 45);
            this.ConvertCurrencyComboBox.Name = "ConvertCurrencyComboBox";
            this.ConvertCurrencyComboBox.Size = new System.Drawing.Size(122, 21);
            this.ConvertCurrencyComboBox.TabIndex = 0;
            this.ConvertCurrencyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertationResultGroupBox
            // 
            this.ConvertationResultGroupBox.Controls.Add(this.ConvertCurrencyComboBox);
            this.ConvertationResultGroupBox.Controls.Add(this.ConvertationResultTextBox);
            this.ConvertationResultGroupBox.Location = new System.Drawing.Point(203, 12);
            this.ConvertationResultGroupBox.Name = "ConvertationResultGroupBox";
            this.ConvertationResultGroupBox.Size = new System.Drawing.Size(134, 72);
            this.ConvertationResultGroupBox.TabIndex = 2;
            this.ConvertationResultGroupBox.TabStop = false;
            this.ConvertationResultGroupBox.Text = "Результат конвертації";
            // 
            // ConvertationResultTextBox
            // 
            this.ConvertationResultTextBox.Location = new System.Drawing.Point(6, 19);
            this.ConvertationResultTextBox.Name = "ConvertationResultTextBox";
            this.ConvertationResultTextBox.Size = new System.Drawing.Size(122, 20);
            this.ConvertationResultTextBox.TabIndex = 1;
            this.ConvertationResultTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisableInput);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Enabled = false;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertButton.Location = new System.Drawing.Point(152, 12);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(45, 72);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "➔";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowRatesToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(256, 26);
            // 
            // ShowRatesToolStripMenuItem
            // 
            this.ShowRatesToolStripMenuItem.CheckOnClick = true;
            this.ShowRatesToolStripMenuItem.Name = "ShowRatesToolStripMenuItem";
            this.ShowRatesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ShowRatesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.ShowRatesToolStripMenuItem.Text = "Показувати курси валют";
            this.ShowRatesToolStripMenuItem.Click += new System.EventHandler(this.ShowRatesToolStripMenuItem_Click);
            // 
            // RatesListBox
            // 
            this.RatesListBox.FormattingEnabled = true;
            this.RatesListBox.Location = new System.Drawing.Point(12, 90);
            this.RatesListBox.Name = "RatesListBox";
            this.RatesListBox.Size = new System.Drawing.Size(325, 121);
            this.RatesListBox.TabIndex = 6;
            this.RatesListBox.Visible = false;
            // 
            // ValuteWidgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 96);
            this.ContextMenuStrip = this.ContextMenu;
            this.Controls.Add(this.RatesListBox);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertationResultGroupBox);
            this.Controls.Add(this.CurrencyCountGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ValuteWidgetForm";
            this.Text = "Valute";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ValuteWidgetForm_FormClosed);
            this.Load += new System.EventHandler(this.ConverterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValuteForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValuteForm_KeyUp);
            this.CurrencyCountGroupBox.ResumeLayout(false);
            this.CurrencyCountGroupBox.PerformLayout();
            this.ConvertationResultGroupBox.ResumeLayout(false);
            this.ConvertationResultGroupBox.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox CurrencyCountGroupBox;
        private System.Windows.Forms.ComboBox ConvertCurrencyComboBox;
        private System.Windows.Forms.GroupBox ConvertationResultGroupBox;
        private System.Windows.Forms.ComboBox SourceCurrencyComboBox;
        private System.Windows.Forms.TextBox ConvertationResultTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox CurrencyCountTextBox;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowRatesToolStripMenuItem;
        private System.Windows.Forms.ListBox RatesListBox;
    }
}


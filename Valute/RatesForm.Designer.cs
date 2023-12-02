namespace Valute
{
    partial class RatesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RatesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RatesListBox
            // 
            this.RatesListBox.FormattingEnabled = true;
            this.RatesListBox.Location = new System.Drawing.Point(12, 12);
            this.RatesListBox.Name = "RatesListBox";
            this.RatesListBox.Size = new System.Drawing.Size(386, 329);
            this.RatesListBox.TabIndex = 0;
            // 
            // RatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 353);
            this.Controls.Add(this.RatesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatesForm";
            this.Text = "Курси валют";
            this.Load += new System.EventHandler(this.RatesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RatesForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RatesForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox RatesListBox;
    }
}
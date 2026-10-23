namespace StockMarketSimulator
{
    partial class StockMarketForm
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
            uiListBoxCompanies = new ListBox();
            SuspendLayout();
            // 
            // uiListBoxCompanies
            // 
            uiListBoxCompanies.FormattingEnabled = true;
            uiListBoxCompanies.Location = new Point(0, 42);
            uiListBoxCompanies.Name = "uiListBoxCompanies";
            uiListBoxCompanies.Size = new Size(212, 409);
            uiListBoxCompanies.TabIndex = 0;
            // 
            // StockMarketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(800, 450);
            Controls.Add(uiListBoxCompanies);
            Name = "StockMarketForm";
            Text = "StockMarketForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox uiListBoxCompanies;
    }
}

namespace MegaDesk_1._0
{
    partial class DisplayQuote
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
            this.Return = new System.Windows.Forms.Button();
            this.QuoteTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(210, 376);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 0;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Return_MouseClick);
            // 
            // QuoteTotalLabel
            // 
            this.QuoteTotalLabel.AutoSize = true;
            this.QuoteTotalLabel.Location = new System.Drawing.Point(308, 186);
            this.QuoteTotalLabel.Name = "QuoteTotalLabel";
            this.QuoteTotalLabel.Size = new System.Drawing.Size(51, 20);
            this.QuoteTotalLabel.TabIndex = 1;
            this.QuoteTotalLabel.Text = "label1";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuoteTotalLabel);
            this.Controls.Add(this.Return);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label QuoteTotalLabel;
    }
}
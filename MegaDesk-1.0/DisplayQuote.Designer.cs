
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(303, 338);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(171, 58);
            this.Return.TabIndex = 0;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Return_MouseClick);
            // 
            // QuoteTotalLabel
            // 
            this.QuoteTotalLabel.AutoSize = true;
            this.QuoteTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteTotalLabel.Location = new System.Drawing.Point(402, 194);
            this.QuoteTotalLabel.Name = "QuoteTotalLabel";
            this.QuoteTotalLabel.Size = new System.Drawing.Size(56, 25);
            this.QuoteTotalLabel.TabIndex = 1;
            this.QuoteTotalLabel.Text = "Total";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(364, 121);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(335, 194);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(78, 25);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total: $";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(364, 253);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(53, 25);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.NameLabel);
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
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}
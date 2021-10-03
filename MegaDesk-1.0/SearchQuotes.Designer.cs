
namespace MegaDesk_1._0
{
    partial class SearchQuotes
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
            System.Windows.Forms.Button Return;
            Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Return
            // 
            Return.Location = new System.Drawing.Point(323, 367);
            Return.Name = "Return";
            Return.Size = new System.Drawing.Size(131, 47);
            Return.TabIndex = 0;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Return_MouseClick);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Return);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
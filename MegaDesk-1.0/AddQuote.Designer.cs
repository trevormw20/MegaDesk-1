
namespace MegaDesk_1._0
{
    partial class AddQuote
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
            this.Header = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.Drawers = new System.Windows.Forms.Label();
            this.SurfaceMaterial = new System.Windows.Forms.Label();
            this.RushOrder = new System.Windows.Forms.Label();
            this.RushBox = new System.Windows.Forms.ComboBox();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.PriceQuote = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.DrawersBox = new System.Windows.Forms.ComboBox();
            this.WidthBox = new System.Windows.Forms.NumericUpDown();
            this.DepthBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Location = new System.Drawing.Point(333, 23);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(53, 20);
            this.Header.TabIndex = 0;
            this.Header.Text = "Quote";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(223, 61);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(223, 105);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(90, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // DeskWidth
            // 
            this.DeskWidth.AutoSize = true;
            this.DeskWidth.Location = new System.Drawing.Point(223, 154);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(231, 20);
            this.DeskWidth.TabIndex = 3;
            this.DeskWidth.Text = "Desk Width ( min 24\", max 96\"):";
            // 
            // DeskDepth
            // 
            this.DeskDepth.AutoSize = true;
            this.DeskDepth.Location = new System.Drawing.Point(223, 192);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(234, 20);
            this.DeskDepth.TabIndex = 4;
            this.DeskDepth.Text = "Desk Depth ( min 12\", max 48\"):";
            // 
            // Drawers
            // 
            this.Drawers.AutoSize = true;
            this.Drawers.Location = new System.Drawing.Point(223, 246);
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(125, 20);
            this.Drawers.TabIndex = 5;
            this.Drawers.Text = "Drawers ( 0 - 7 ):";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.AutoSize = true;
            this.SurfaceMaterial.Location = new System.Drawing.Point(223, 297);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(129, 20);
            this.SurfaceMaterial.TabIndex = 6;
            this.SurfaceMaterial.Text = "Surface Material:";
            // 
            // RushOrder
            // 
            this.RushOrder.AutoSize = true;
            this.RushOrder.Location = new System.Drawing.Point(223, 339);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(95, 20);
            this.RushOrder.TabIndex = 7;
            this.RushOrder.Text = "Rush Order:";
            // 
            // RushBox
            // 
            this.RushBox.FormattingEnabled = true;
            this.RushBox.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
            this.RushBox.Location = new System.Drawing.Point(354, 339);
            this.RushBox.Name = "RushBox";
            this.RushBox.Size = new System.Drawing.Size(121, 28);
            this.RushBox.TabIndex = 8;
            this.RushBox.Text = " Default";
            // 
            // MaterialBox
            // 
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Items.AddRange(new object[] {
            "Oak $200",
            "Laminate $100",
            "Pine $50",
            "Rosewood $300",
            "Veneer $125"});
            this.MaterialBox.Location = new System.Drawing.Point(354, 297);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(121, 28);
            this.MaterialBox.TabIndex = 9;
            this.MaterialBox.Text = "Pine $50";
            // 
            // PriceQuote
            // 
            this.PriceQuote.Location = new System.Drawing.Point(395, 394);
            this.PriceQuote.Name = "PriceQuote";
            this.PriceQuote.Size = new System.Drawing.Size(132, 35);
            this.PriceQuote.TabIndex = 10;
            this.PriceQuote.Text = "Price Quote";
            this.PriceQuote.UseVisualStyleBackColor = true;
            this.PriceQuote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PriceQuote_MouseClick);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(180, 394);
            this.Return.Name = "Return";
            this.Return.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Return.Size = new System.Drawing.Size(119, 35);
            this.Return.TabIndex = 11;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Return_MouseClick);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(319, 61);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(133, 26);
            this.FirstNameBox.TabIndex = 12;
            this.FirstNameBox.Enter += new System.EventHandler(this.FirstNameBox_Enter);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(319, 102);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(133, 26);
            this.LastNameBox.TabIndex = 13;
            // 
            // DrawersBox
            // 
            this.DrawersBox.FormattingEnabled = true;
            this.DrawersBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawersBox.Location = new System.Drawing.Point(354, 243);
            this.DrawersBox.Name = "DrawersBox";
            this.DrawersBox.Size = new System.Drawing.Size(121, 28);
            this.DrawersBox.TabIndex = 16;
            this.DrawersBox.Text = "0";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(460, 154);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(120, 26);
            this.WidthBox.TabIndex = 17;
            this.WidthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.WidthBox.ValueChanged += new System.EventHandler(this.WidthBox_ValueChanged);
            this.WidthBox.Click += new System.EventHandler(this.WidthBox_Click);
            this.WidthBox.Enter += new System.EventHandler(this.WidthBox_Enter);
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(463, 190);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(120, 26);
            this.DepthBox.TabIndex = 18;
            this.DepthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthBox.ValueChanged += new System.EventHandler(this.DepthBox_ValueChanged);
            this.DepthBox.Click += new System.EventHandler(this.DepthBox_Click);
            this.DepthBox.Enter += new System.EventHandler(this.DepthBox_Enter);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.DrawersBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.PriceQuote);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.RushBox);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Header);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.WidthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.Label Drawers;
        private System.Windows.Forms.Label SurfaceMaterial;
        private System.Windows.Forms.Label RushOrder;
        private System.Windows.Forms.ComboBox RushBox;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.Button PriceQuote;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.ComboBox DrawersBox;
        private System.Windows.Forms.NumericUpDown WidthBox;
        private System.Windows.Forms.NumericUpDown DepthBox;
    }
}
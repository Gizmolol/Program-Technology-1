namespace ConsoleApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(369, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.BackColorChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.comboBox2.BindingContextChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.comboBox2.CausesValidationChanged += new System.EventHandler(this.statusStrip1_Leave);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Activated += new System.EventHandler(this.statusStrip1_Leave);
            this.printPreviewDialog1.BindingContextChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.printPreviewDialog1.Click += new System.EventHandler(this.statusStrip1_Leave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(369, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.AutoSizeChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.flowLayoutPanel1.Click += new System.EventHandler(this.statusStrip1_Leave);
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.AutoSizeChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            this.statusStrip1.BackColorChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.statusStrip1.BackgroundImageChanged += new System.EventHandler(this.statusStrip1_Leave);
            this.statusStrip1.Leave += new System.EventHandler(this.statusStrip1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
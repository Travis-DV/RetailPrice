namespace RetailPrice
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
            this.inputGB = new System.Windows.Forms.GroupBox();
            this.wholesaleLB = new System.Windows.Forms.Label();
            this.wholesaleTB = new System.Windows.Forms.TextBox();
            this.markupLB = new System.Windows.Forms.Label();
            this.markupTB = new System.Windows.Forms.TextBox();
            this.totalcostLB = new System.Windows.Forms.Label();
            this.inputGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGB
            // 
            this.inputGB.Controls.Add(this.markupTB);
            this.inputGB.Controls.Add(this.markupLB);
            this.inputGB.Controls.Add(this.wholesaleTB);
            this.inputGB.Controls.Add(this.wholesaleLB);
            this.inputGB.Location = new System.Drawing.Point(12, 12);
            this.inputGB.Name = "inputGB";
            this.inputGB.Size = new System.Drawing.Size(200, 110);
            this.inputGB.TabIndex = 0;
            this.inputGB.TabStop = false;
            this.inputGB.Text = "Inputs";
            // 
            // wholesaleLB
            // 
            this.wholesaleLB.AutoSize = true;
            this.wholesaleLB.Location = new System.Drawing.Point(6, 21);
            this.wholesaleLB.Name = "wholesaleLB";
            this.wholesaleLB.Size = new System.Drawing.Size(134, 13);
            this.wholesaleLB.TabIndex = 0;
            this.wholesaleLB.Text = "Input the whole sale price: ";
            // 
            // wholesaleTB
            // 
            this.wholesaleTB.Location = new System.Drawing.Point(9, 37);
            this.wholesaleTB.Name = "wholesaleTB";
            this.wholesaleTB.Size = new System.Drawing.Size(100, 20);
            this.wholesaleTB.TabIndex = 1;
            this.wholesaleTB.TextChanged += new System.EventHandler(this.wholesaleTB_TextChanged);
            // 
            // markupLB
            // 
            this.markupLB.AutoSize = true;
            this.markupLB.Location = new System.Drawing.Point(6, 60);
            this.markupLB.Name = "markupLB";
            this.markupLB.Size = new System.Drawing.Size(155, 13);
            this.markupLB.TabIndex = 2;
            this.markupLB.Text = "Input your markup percentage: ";
            // 
            // markupTB
            // 
            this.markupTB.Location = new System.Drawing.Point(9, 77);
            this.markupTB.Name = "markupTB";
            this.markupTB.Size = new System.Drawing.Size(100, 20);
            this.markupTB.TabIndex = 3;
            this.markupTB.TextChanged += new System.EventHandler(this.markupTB_TextChanged);
            // 
            // totalcostLB
            // 
            this.totalcostLB.AutoSize = true;
            this.totalcostLB.Location = new System.Drawing.Point(61, 122);
            this.totalcostLB.Name = "totalcostLB";
            this.totalcostLB.Size = new System.Drawing.Size(74, 13);
            this.totalcostLB.TabIndex = 1;
            this.totalcostLB.Text = "Retail Cost is: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 141);
            this.Controls.Add(this.totalcostLB);
            this.Controls.Add(this.inputGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputGB.ResumeLayout(false);
            this.inputGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGB;
        private System.Windows.Forms.TextBox markupTB;
        private System.Windows.Forms.Label markupLB;
        private System.Windows.Forms.TextBox wholesaleTB;
        private System.Windows.Forms.Label wholesaleLB;
        private System.Windows.Forms.Label totalcostLB;
    }
}


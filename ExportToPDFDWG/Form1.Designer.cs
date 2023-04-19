
namespace ExportToPDFDWG
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
            this.pdf = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ExportDWG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pdf.Location = new System.Drawing.Point(66, 135);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(161, 42);
            this.pdf.TabIndex = 0;
            this.pdf.Text = "Export to PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(66, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Print PDF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.print_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(66, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ExportDWG
            // 
            this.ExportDWG.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ExportDWG.Location = new System.Drawing.Point(66, 195);
            this.ExportDWG.Name = "ExportDWG";
            this.ExportDWG.Size = new System.Drawing.Size(161, 43);
            this.ExportDWG.TabIndex = 4;
            this.ExportDWG.Text = "Export To DWG";
            this.ExportDWG.UseVisualStyleBackColor = false;
            this.ExportDWG.Click += new System.EventHandler(this.ExportDWG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Note that after export to PDF or DWG, make sure to close SolidWorks before expor" +
    "ting again.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Note that the form is using SolidWorks 2022 SP5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(66, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Print DWG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(502, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportDWG);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IME Export To DWG and PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ExportDWG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}


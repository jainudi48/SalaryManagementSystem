namespace WindowsFormsApplication1
{
    partial class frmNavigation
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
            this.btnPunchSalary = new System.Windows.Forms.Button();
            this.btnPrintSalarySlip = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPayFixation = new System.Windows.Forms.Button();
            this.btnFormulaFixation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPunchSalary
            // 
            this.btnPunchSalary.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunchSalary.Location = new System.Drawing.Point(39, 95);
            this.btnPunchSalary.Name = "btnPunchSalary";
            this.btnPunchSalary.Size = new System.Drawing.Size(113, 23);
            this.btnPunchSalary.TabIndex = 0;
            this.btnPunchSalary.Text = "Punch Salary";
            this.btnPunchSalary.UseVisualStyleBackColor = true;
            this.btnPunchSalary.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrintSalarySlip
            // 
            this.btnPrintSalarySlip.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSalarySlip.Location = new System.Drawing.Point(39, 128);
            this.btnPrintSalarySlip.Name = "btnPrintSalarySlip";
            this.btnPrintSalarySlip.Size = new System.Drawing.Size(113, 23);
            this.btnPrintSalarySlip.TabIndex = 1;
            this.btnPrintSalarySlip.Text = "Print Salary Slip";
            this.btnPrintSalarySlip.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(39, 161);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnPayFixation
            // 
            this.btnPayFixation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFixation.Location = new System.Drawing.Point(39, 29);
            this.btnPayFixation.Name = "btnPayFixation";
            this.btnPayFixation.Size = new System.Drawing.Size(113, 23);
            this.btnPayFixation.TabIndex = 3;
            this.btnPayFixation.Text = "Pay Fixation";
            this.btnPayFixation.UseVisualStyleBackColor = true;
            this.btnPayFixation.Click += new System.EventHandler(this.btnPayFixation_Click);
            // 
            // btnFormulaFixation
            // 
            this.btnFormulaFixation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulaFixation.Location = new System.Drawing.Point(39, 62);
            this.btnFormulaFixation.Name = "btnFormulaFixation";
            this.btnFormulaFixation.Size = new System.Drawing.Size(113, 23);
            this.btnFormulaFixation.TabIndex = 4;
            this.btnFormulaFixation.Text = "Formula Fixation";
            this.btnFormulaFixation.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnPayFixation);
            this.panel1.Controls.Add(this.btnFormulaFixation);
            this.panel1.Controls.Add(this.btnPunchSalary);
            this.panel1.Controls.Add(this.btnPrintSalarySlip);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 243);
            this.panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(39, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 269);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navigation";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPunchSalary;
        private System.Windows.Forms.Button btnPrintSalarySlip;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnPayFixation;
        private System.Windows.Forms.Button btnFormulaFixation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}
namespace WindowsFormsApplication1
{
    partial class frmFormulaFixation
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
            this.gbFormulaFixation = new System.Windows.Forms.GroupBox();
            this.btnShowDatePanel = new System.Windows.Forms.Button();
            this.txtEffectiveDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaOnTraPercent = new System.Windows.Forms.Label();
            this.lblHraPercent = new System.Windows.Forms.Label();
            this.lblDaPercent = new System.Windows.Forms.Label();
            this.txtDaOnTraPercent = new System.Windows.Forms.TextBox();
            this.txtHraPercent = new System.Windows.Forms.TextBox();
            this.txtDaPercent = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkConfirm = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.gbFormulaFixation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFormulaFixation
            // 
            this.gbFormulaFixation.Controls.Add(this.btnShowDatePanel);
            this.gbFormulaFixation.Controls.Add(this.txtEffectiveDate);
            this.gbFormulaFixation.Controls.Add(this.label1);
            this.gbFormulaFixation.Controls.Add(this.lblDaOnTraPercent);
            this.gbFormulaFixation.Controls.Add(this.lblHraPercent);
            this.gbFormulaFixation.Controls.Add(this.lblDaPercent);
            this.gbFormulaFixation.Controls.Add(this.txtDaOnTraPercent);
            this.gbFormulaFixation.Controls.Add(this.txtHraPercent);
            this.gbFormulaFixation.Controls.Add(this.txtDaPercent);
            this.gbFormulaFixation.Controls.Add(this.label57);
            this.gbFormulaFixation.Controls.Add(this.label56);
            this.gbFormulaFixation.Controls.Add(this.label55);
            this.gbFormulaFixation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormulaFixation.Location = new System.Drawing.Point(12, 12);
            this.gbFormulaFixation.Name = "gbFormulaFixation";
            this.gbFormulaFixation.Size = new System.Drawing.Size(290, 152);
            this.gbFormulaFixation.TabIndex = 107;
            this.gbFormulaFixation.TabStop = false;
            this.gbFormulaFixation.Text = "Formula Fixation";
            // 
            // btnShowDatePanel
            // 
            this.btnShowDatePanel.Enabled = false;
            this.btnShowDatePanel.Location = new System.Drawing.Point(201, 114);
            this.btnShowDatePanel.Name = "btnShowDatePanel";
            this.btnShowDatePanel.Size = new System.Drawing.Size(34, 23);
            this.btnShowDatePanel.TabIndex = 76;
            this.btnShowDatePanel.Text = "...";
            this.btnShowDatePanel.UseVisualStyleBackColor = true;
            this.btnShowDatePanel.Click += new System.EventHandler(this.btnShowDatePanel_Click);
            // 
            // txtEffectiveDate
            // 
            this.txtEffectiveDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEffectiveDate.Location = new System.Drawing.Point(108, 114);
            this.txtEffectiveDate.Name = "txtEffectiveDate";
            this.txtEffectiveDate.Size = new System.Drawing.Size(86, 22);
            this.txtEffectiveDate.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Effective Date";
            // 
            // lblDaOnTraPercent
            // 
            this.lblDaOnTraPercent.AutoSize = true;
            this.lblDaOnTraPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaOnTraPercent.Location = new System.Drawing.Point(162, 90);
            this.lblDaOnTraPercent.Name = "lblDaOnTraPercent";
            this.lblDaOnTraPercent.Size = new System.Drawing.Size(73, 16);
            this.lblDaOnTraPercent.TabIndex = 73;
            this.lblDaOnTraPercent.Text = "132% of TRA";
            // 
            // lblHraPercent
            // 
            this.lblHraPercent.AutoSize = true;
            this.lblHraPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHraPercent.Location = new System.Drawing.Point(162, 58);
            this.lblHraPercent.Name = "lblHraPercent";
            this.lblHraPercent.Size = new System.Drawing.Size(115, 16);
            this.lblHraPercent.TabIndex = 72;
            this.lblHraPercent.Text = "30% of PAY and AGP";
            // 
            // lblDaPercent
            // 
            this.lblDaPercent.AutoSize = true;
            this.lblDaPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaPercent.Location = new System.Drawing.Point(162, 29);
            this.lblDaPercent.Name = "lblDaPercent";
            this.lblDaPercent.Size = new System.Drawing.Size(121, 16);
            this.lblDaPercent.TabIndex = 71;
            this.lblDaPercent.Text = "132% of PAY and AGP";
            // 
            // txtDaOnTraPercent
            // 
            this.txtDaOnTraPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaOnTraPercent.Location = new System.Drawing.Point(108, 84);
            this.txtDaOnTraPercent.Name = "txtDaOnTraPercent";
            this.txtDaOnTraPercent.Size = new System.Drawing.Size(48, 22);
            this.txtDaOnTraPercent.TabIndex = 69;
            this.txtDaOnTraPercent.Text = "132";
            this.txtDaOnTraPercent.TextChanged += new System.EventHandler(this.tbDaOnTraPercent_TextChanged);
            this.txtDaOnTraPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDaOnTraPercent_KeyPress);
            // 
            // txtHraPercent
            // 
            this.txtHraPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHraPercent.Location = new System.Drawing.Point(108, 52);
            this.txtHraPercent.Name = "txtHraPercent";
            this.txtHraPercent.Size = new System.Drawing.Size(48, 22);
            this.txtHraPercent.TabIndex = 68;
            this.txtHraPercent.Text = "30";
            this.txtHraPercent.TextChanged += new System.EventHandler(this.tbHraPercent_TextChanged);
            this.txtHraPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDaOnTraPercent_KeyPress);
            // 
            // txtDaPercent
            // 
            this.txtDaPercent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaPercent.Location = new System.Drawing.Point(108, 23);
            this.txtDaPercent.Name = "txtDaPercent";
            this.txtDaPercent.Size = new System.Drawing.Size(48, 22);
            this.txtDaPercent.TabIndex = 67;
            this.txtDaPercent.Text = "132";
            this.txtDaPercent.TextChanged += new System.EventHandler(this.tbDaPercent_TextChanged);
            this.txtDaPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDaOnTraPercent_KeyPress);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(16, 90);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(66, 16);
            this.label57.TabIndex = 66;
            this.label57.Text = "DA ON TRA";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(16, 54);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(31, 16);
            this.label56.TabIndex = 65;
            this.label56.Text = "HRA";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(16, 25);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(23, 16);
            this.label55.TabIndex = 64;
            this.label55.Text = "DA";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkConfirm);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 44);
            this.panel1.TabIndex = 108;
            // 
            // chkConfirm
            // 
            this.chkConfirm.AutoSize = true;
            this.chkConfirm.Enabled = false;
            this.chkConfirm.Location = new System.Drawing.Point(18, 12);
            this.chkConfirm.Name = "chkConfirm";
            this.chkConfirm.Size = new System.Drawing.Size(69, 20);
            this.chkConfirm.TabIndex = 2;
            this.chkConfirm.Text = "Confirm";
            this.chkConfirm.UseVisualStyleBackColor = true;
            this.chkConfirm.CheckedChanged += new System.EventHandler(this.chkConfirm_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(188, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(93, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(314, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 109;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // frmFormulaFixation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 226);
            this.ControlBox = false;
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFormulaFixation);
            this.Name = "frmFormulaFixation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formula Fixation";
            this.Load += new System.EventHandler(this.frmFormulaFixation_Load);
            this.gbFormulaFixation.ResumeLayout(false);
            this.gbFormulaFixation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormulaFixation;
        private System.Windows.Forms.TextBox txtEffectiveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDaOnTraPercent;
        private System.Windows.Forms.Label lblHraPercent;
        private System.Windows.Forms.Label lblDaPercent;
        private System.Windows.Forms.TextBox txtDaOnTraPercent;
        private System.Windows.Forms.TextBox txtHraPercent;
        private System.Windows.Forms.TextBox txtDaPercent;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btnShowDatePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
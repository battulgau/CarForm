namespace WindowsFormsApplication1
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAral = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZagvar = new System.Windows.Forms.TextBox();
            this.txtAralDugaar = new System.Windows.Forms.TextBox();
            this.txtUngu = new System.Windows.Forms.TextBox();
            this.maskOn = new System.Windows.Forms.MaskedTextBox();
            this.maskUlsDugaar = new System.Windows.Forms.MaskedTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbAngilal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(63, 46);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Модел: ";
            // 
            // lblAral
            // 
            this.lblAral.AutoSize = true;
            this.lblAral.Location = new System.Drawing.Point(63, 70);
            this.lblAral.Name = "lblAral";
            this.lblAral.Size = new System.Drawing.Size(83, 13);
            this.lblAral.TabIndex = 1;
            this.lblAral.Text = "Арлын дугаар: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Өнгө: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Үйлдвэрлэсэн он: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ангилал: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Улсын дугаар: ";
            // 
            // txtZagvar
            // 
            this.txtZagvar.Location = new System.Drawing.Point(165, 46);
            this.txtZagvar.Name = "txtZagvar";
            this.txtZagvar.Size = new System.Drawing.Size(150, 20);
            this.txtZagvar.TabIndex = 6;
            // 
            // txtAralDugaar
            // 
            this.txtAralDugaar.Location = new System.Drawing.Point(165, 70);
            this.txtAralDugaar.Name = "txtAralDugaar";
            this.txtAralDugaar.Size = new System.Drawing.Size(150, 20);
            this.txtAralDugaar.TabIndex = 7;
            // 
            // txtUngu
            // 
            this.txtUngu.Location = new System.Drawing.Point(165, 96);
            this.txtUngu.Name = "txtUngu";
            this.txtUngu.Size = new System.Drawing.Size(150, 20);
            this.txtUngu.TabIndex = 8;
            // 
            // maskOn
            // 
            this.maskOn.Location = new System.Drawing.Point(165, 123);
            this.maskOn.Mask = "0000";
            this.maskOn.Name = "maskOn";
            this.maskOn.Size = new System.Drawing.Size(150, 20);
            this.maskOn.TabIndex = 12;
            // 
            // maskUlsDugaar
            // 
            this.maskUlsDugaar.Location = new System.Drawing.Point(165, 176);
            this.maskUlsDugaar.Mask = "0000-LLL";
            this.maskUlsDugaar.Name = "maskUlsDugaar";
            this.maskUlsDugaar.Size = new System.Drawing.Size(150, 20);
            this.maskUlsDugaar.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(165, 215);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 38);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Машины мэдээлэл харах";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblInfo.Location = new System.Drawing.Point(62, 309);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 16;
            // 
            // cmbAngilal
            // 
            this.cmbAngilal.FormattingEnabled = true;
            this.cmbAngilal.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "M"});
            this.cmbAngilal.Location = new System.Drawing.Point(165, 150);
            this.cmbAngilal.Name = "cmbAngilal";
            this.cmbAngilal.Size = new System.Drawing.Size(150, 21);
            this.cmbAngilal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(63, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таны оруулсан машины талаарх мэдээлэл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAngilal);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.maskUlsDugaar);
            this.Controls.Add(this.maskOn);
            this.Controls.Add(this.txtUngu);
            this.Controls.Add(this.txtAralDugaar);
            this.Controls.Add(this.txtZagvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAral);
            this.Controls.Add(this.lblModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblAral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtZagvar;
        private System.Windows.Forms.TextBox txtAralDugaar;
        private System.Windows.Forms.TextBox txtUngu;
        private System.Windows.Forms.MaskedTextBox maskOn;
        private System.Windows.Forms.MaskedTextBox maskUlsDugaar;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbAngilal;
        private System.Windows.Forms.Label label1;
    }
}


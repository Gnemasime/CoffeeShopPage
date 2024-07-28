namespace CoffeeShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAmountGiven = new System.Windows.Forms.TextBox();
            this.checkBoxMilk = new System.Windows.Forms.CheckBox();
            this.checkBoxHoney = new System.Windows.Forms.CheckBox();
            this.radioButtonCappuccino = new System.Windows.Forms.RadioButton();
            this.radioButtonRicofy = new System.Windows.Forms.RadioButton();
            this.radioButtonJacobs = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter amount to spend:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAmountGiven
            // 
            this.textBoxAmountGiven.Location = new System.Drawing.Point(290, 28);
            this.textBoxAmountGiven.Name = "textBoxAmountGiven";
            this.textBoxAmountGiven.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmountGiven.TabIndex = 1;
            // 
            // checkBoxMilk
            // 
            this.checkBoxMilk.AutoSize = true;
            this.checkBoxMilk.Location = new System.Drawing.Point(290, 114);
            this.checkBoxMilk.Name = "checkBoxMilk";
            this.checkBoxMilk.Size = new System.Drawing.Size(45, 17);
            this.checkBoxMilk.TabIndex = 3;
            this.checkBoxMilk.Text = "Milk";
            this.checkBoxMilk.UseVisualStyleBackColor = true;
            // 
            // checkBoxHoney
            // 
            this.checkBoxHoney.AutoSize = true;
            this.checkBoxHoney.Location = new System.Drawing.Point(290, 146);
            this.checkBoxHoney.Name = "checkBoxHoney";
            this.checkBoxHoney.Size = new System.Drawing.Size(57, 17);
            this.checkBoxHoney.TabIndex = 4;
            this.checkBoxHoney.Text = "Honey";
            this.checkBoxHoney.UseVisualStyleBackColor = true;
            // 
            // radioButtonCappuccino
            // 
            this.radioButtonCappuccino.AutoSize = true;
            this.radioButtonCappuccino.Location = new System.Drawing.Point(125, 113);
            this.radioButtonCappuccino.Name = "radioButtonCappuccino";
            this.radioButtonCappuccino.Size = new System.Drawing.Size(108, 17);
            this.radioButtonCappuccino.TabIndex = 6;
            this.radioButtonCappuccino.Text = "Cappuccino  R25";
            this.radioButtonCappuccino.UseVisualStyleBackColor = true;
            this.radioButtonCappuccino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonRicofy
            // 
            this.radioButtonRicofy.AutoSize = true;
            this.radioButtonRicofy.Location = new System.Drawing.Point(125, 145);
            this.radioButtonRicofy.Name = "radioButtonRicofy";
            this.radioButtonRicofy.Size = new System.Drawing.Size(108, 17);
            this.radioButtonRicofy.TabIndex = 7;
            this.radioButtonRicofy.Text = "Ricofy           R20";
            this.radioButtonRicofy.UseVisualStyleBackColor = true;
            // 
            // radioButtonJacobs
            // 
            this.radioButtonJacobs.AutoSize = true;
            this.radioButtonJacobs.Location = new System.Drawing.Point(125, 178);
            this.radioButtonJacobs.Name = "radioButtonJacobs";
            this.radioButtonJacobs.Size = new System.Drawing.Size(106, 17);
            this.radioButtonJacobs.TabIndex = 8;
            this.radioButtonJacobs.Text = "Jacobs         R45";
            this.radioButtonJacobs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select drink:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Extras:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(192, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(122, 266);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(75, 13);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Amount spent:";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Location = new System.Drawing.Point(122, 296);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(47, 13);
            this.labelChange.TabIndex = 13;
            this.labelChange.Text = "Change:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonJacobs);
            this.Controls.Add(this.radioButtonRicofy);
            this.Controls.Add(this.radioButtonCappuccino);
            this.Controls.Add(this.checkBoxHoney);
            this.Controls.Add(this.checkBoxMilk);
            this.Controls.Add(this.textBoxAmountGiven);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "CoffeeShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmountGiven;
        private System.Windows.Forms.CheckBox checkBoxMilk;
        private System.Windows.Forms.CheckBox checkBoxHoney;
        private System.Windows.Forms.RadioButton radioButtonCappuccino;
        private System.Windows.Forms.RadioButton radioButtonRicofy;
        private System.Windows.Forms.RadioButton radioButtonJacobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelChange;
    }
}


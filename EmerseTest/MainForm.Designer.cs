
namespace EmerseTest
{
    partial class MainForm
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
            this.labHeight = new System.Windows.Forms.Label();
            this.labWeight = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUS = new System.Windows.Forms.RadioButton();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labCate = new System.Windows.Forms.Label();
            this.labBMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxInch = new System.Windows.Forms.TextBox();
            this.labNBmi = new System.Windows.Forms.Label();
            this.labNWeight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // labHeight
            // 
            this.labHeight.AutoSize = true;
            this.labHeight.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labHeight.Location = new System.Drawing.Point(34, 120);
            this.labHeight.Name = "labHeight";
            this.labHeight.Size = new System.Drawing.Size(117, 24);
            this.labHeight.TabIndex = 1;
            this.labHeight.Text = "Height (cm)";
            this.labHeight.Click += new System.EventHandler(this.label2_Click);
            // 
            // labWeight
            // 
            this.labWeight.AutoSize = true;
            this.labWeight.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labWeight.Location = new System.Drawing.Point(34, 172);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(116, 24);
            this.labWeight.TabIndex = 2;
            this.labWeight.Text = "Weight (kg)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calaulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUS);
            this.groupBox1.Controls.Add(this.radioMetric);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(522, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioUS
            // 
            this.radioUS.AutoSize = true;
            this.radioUS.Location = new System.Drawing.Point(42, 92);
            this.radioUS.Name = "radioUS";
            this.radioUS.Size = new System.Drawing.Size(191, 28);
            this.radioUS.TabIndex = 1;
            this.radioUS.Text = "US Unit (foot, lbs)";
            this.radioUS.UseVisualStyleBackColor = true;
            this.radioUS.CheckedChanged += new System.EventHandler(this.radioUS_CheckedChanged);
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Checked = true;
            this.radioMetric.Location = new System.Drawing.Point(42, 44);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(208, 28);
            this.radioMetric.TabIndex = 0;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric Unit (kg, cm)";
            this.radioMetric.UseVisualStyleBackColor = true;
            this.radioMetric.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labNWeight);
            this.groupBox2.Controls.Add(this.labNBmi);
            this.groupBox2.Controls.Add(this.labCate);
            this.groupBox2.Controls.Add(this.labBMI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(37, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 299);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results for Apu S";
            // 
            // labCate
            // 
            this.labCate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labCate.Location = new System.Drawing.Point(290, 125);
            this.labCate.Name = "labCate";
            this.labCate.Size = new System.Drawing.Size(387, 41);
            this.labCate.TabIndex = 3;
            // 
            // labBMI
            // 
            this.labBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labBMI.Location = new System.Drawing.Point(577, 66);
            this.labBMI.Name = "labBMI";
            this.labBMI.Size = new System.Drawing.Size(100, 35);
            this.labBMI.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Weight Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your BMI";
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(173, 48);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.NameTextBox1.Size = new System.Drawing.Size(505, 24);
            this.NameTextBox1.TabIndex = 6;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(173, 113);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 24);
            this.textBoxHeight.TabIndex = 7;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(173, 172);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 24);
            this.textBoxWeight.TabIndex = 8;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxInch
            // 
            this.textBoxInch.Location = new System.Drawing.Point(289, 113);
            this.textBoxInch.Name = "textBoxInch";
            this.textBoxInch.Size = new System.Drawing.Size(100, 24);
            this.textBoxInch.TabIndex = 9;
            this.textBoxInch.TextChanged += new System.EventHandler(this.textBoxInch_TextChanged);
            // 
            // labNBmi
            // 
            this.labNBmi.ForeColor = System.Drawing.Color.Green;
            this.labNBmi.Location = new System.Drawing.Point(159, 205);
            this.labNBmi.Name = "labNBmi";
            this.labNBmi.Size = new System.Drawing.Size(518, 31);
            this.labNBmi.TabIndex = 4;
            this.labNBmi.Click += new System.EventHandler(this.labNBmi_Click);
            // 
            // labNWeight
            // 
            this.labNWeight.AllowDrop = true;
            this.labNWeight.ForeColor = System.Drawing.Color.Green;
            this.labNWeight.Location = new System.Drawing.Point(163, 253);
            this.labNWeight.Name = "labNWeight";
            this.labNWeight.Size = new System.Drawing.Size(514, 34);
            this.labNWeight.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 653);
            this.Controls.Add(this.textBoxInch);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labWeight);
            this.Controls.Add(this.labHeight);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Body Mass Index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labHeight;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUS;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labCate;
        private System.Windows.Forms.Label labBMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.TextBox textBoxInch;
        private System.Windows.Forms.Label labNWeight;
        private System.Windows.Forms.Label labNBmi;
    }
}


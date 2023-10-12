namespace TimeFrequencyConversionApp
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
            this.conversionbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Label();
            this.unit1 = new System.Windows.Forms.Label();
            this.unit2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conversionbox
            // 
            this.conversionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionbox.FormattingEnabled = true;
            this.conversionbox.Items.AddRange(new object[] {
            "Time to Frequency",
            "Frequency to Time"});
            this.conversionbox.Location = new System.Drawing.Point(17, 61);
            this.conversionbox.Name = "conversionbox";
            this.conversionbox.Size = new System.Drawing.Size(271, 28);
            this.conversionbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Conversion:";
            // 
            // inputbox
            // 
            this.inputbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.Location = new System.Drawing.Point(17, 142);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(125, 26);
            this.inputbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Value:";
            // 
            // convert
            // 
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.Location = new System.Drawing.Point(17, 180);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(125, 20);
            this.convert.TabIndex = 7;
            this.convert.Text = "Input Value:";
            // 
            // unit1
            // 
            this.unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit1.Location = new System.Drawing.Point(148, 148);
            this.unit1.Name = "unit1";
            this.unit1.Size = new System.Drawing.Size(125, 20);
            this.unit1.TabIndex = 8;
            this.unit1.Text = "unit1";
            // 
            // unit2
            // 
            this.unit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit2.Location = new System.Drawing.Point(148, 180);
            this.unit2.Name = "unit2";
            this.unit2.Size = new System.Drawing.Size(125, 20);
            this.unit2.TabIndex = 9;
            this.unit2.Text = "unit2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(99, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "CONVERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unit2);
            this.Controls.Add(this.unit1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conversionbox);
            this.Name = "Form1";
            this.Text = "Time & Frequency Conversion App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox conversionbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label convert;
        private System.Windows.Forms.Label unit1;
        private System.Windows.Forms.Label unit2;
        private System.Windows.Forms.Button button1;
    }
}


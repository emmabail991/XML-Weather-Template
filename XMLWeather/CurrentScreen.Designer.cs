namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.tempOutput = new System.Windows.Forms.Label();
            this.conditionOutputLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(26, 66);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(71, 34);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(30, 198);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(38, 20);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.Blue;
            this.minOutput.Location = new System.Drawing.Point(75, 234);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(0, 25);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(30, 238);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(34, 20);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // dateOutput
            // 
            this.dateOutput.AutoSize = true;
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(145, 199);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(72, 24);
            this.dateOutput.TabIndex = 26;
            this.dateOutput.Text = "Current";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(147, 16);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(75, 199);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(0, 25);
            this.maxOutput.TabIndex = 43;
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(136, 66);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(71, 23);
            this.conditionLabel.TabIndex = 44;
            this.conditionLabel.Text = "City";
            // 
            // tempOutput
            // 
            this.tempOutput.BackColor = System.Drawing.Color.Transparent;
            this.tempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOutput.ForeColor = System.Drawing.Color.White;
            this.tempOutput.Location = new System.Drawing.Point(3, 111);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(250, 54);
            this.tempOutput.TabIndex = 45;
            this.tempOutput.Text = "City";
            // 
            // conditionOutputLabel
            // 
            this.conditionOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutputLabel.ForeColor = System.Drawing.Color.White;
            this.conditionOutputLabel.Location = new System.Drawing.Point(146, 111);
            this.conditionOutputLabel.Name = "conditionOutputLabel";
            this.conditionOutputLabel.Size = new System.Drawing.Size(71, 74);
            this.conditionOutputLabel.TabIndex = 46;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(30, 306);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(187, 26);
            this.searchButton.TabIndex = 47;
            this.searchButton.Text = "Search for a city";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 48;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.conditionOutputLabel);
            this.Controls.Add(this.tempOutput);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.Label conditionOutputLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

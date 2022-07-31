namespace Exercise2_RectanglCalculator
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
            this.label_Length = new System.Windows.Forms.Label();
            this.label_Width = new System.Windows.Forms.Label();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label_Area = new System.Windows.Forms.Label();
            this.label_Perimeter = new System.Windows.Forms.Label();
            this.label_Diagonal = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Length
            // 
            this.label_Length.AutoSize = true;
            this.label_Length.BackColor = System.Drawing.Color.Transparent;
            this.label_Length.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Length.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Length.Location = new System.Drawing.Point(158, 70);
            this.label_Length.Name = "label_Length";
            this.label_Length.Size = new System.Drawing.Size(135, 45);
            this.label_Length.TabIndex = 0;
            this.label_Length.Text = "Length";
            this.label_Length.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.BackColor = System.Drawing.Color.Transparent;
            this.label_Width.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Width.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Width.Location = new System.Drawing.Point(158, 136);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(121, 45);
            this.label_Width.TabIndex = 1;
            this.label_Width.Text = "Width";
            // 
            // textBox_Length
            // 
            this.textBox_Length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Length.Location = new System.Drawing.Point(366, 70);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(270, 45);
            this.textBox_Length.TabIndex = 2;
            this.textBox_Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Width
            // 
            this.textBox_Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Width.Location = new System.Drawing.Point(366, 137);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(270, 45);
            this.textBox_Width.TabIndex = 3;
            this.textBox_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Area
            // 
            this.label_Area.AutoSize = true;
            this.label_Area.BackColor = System.Drawing.Color.Transparent;
            this.label_Area.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Area.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Area.Location = new System.Drawing.Point(107, 226);
            this.label_Area.Name = "label_Area";
            this.label_Area.Size = new System.Drawing.Size(94, 45);
            this.label_Area.TabIndex = 4;
            this.label_Area.Text = "Area";
            // 
            // label_Perimeter
            // 
            this.label_Perimeter.AutoSize = true;
            this.label_Perimeter.BackColor = System.Drawing.Color.Transparent;
            this.label_Perimeter.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Perimeter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Perimeter.Location = new System.Drawing.Point(301, 226);
            this.label_Perimeter.Name = "label_Perimeter";
            this.label_Perimeter.Size = new System.Drawing.Size(186, 45);
            this.label_Perimeter.TabIndex = 5;
            this.label_Perimeter.Text = "Perimeter";
            // 
            // label_Diagonal
            // 
            this.label_Diagonal.AutoSize = true;
            this.label_Diagonal.BackColor = System.Drawing.Color.Transparent;
            this.label_Diagonal.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Diagonal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_Diagonal.Location = new System.Drawing.Point(568, 226);
            this.label_Diagonal.Name = "label_Diagonal";
            this.label_Diagonal.Size = new System.Drawing.Size(155, 45);
            this.label_Diagonal.TabIndex = 6;
            this.label_Diagonal.Text = "Diagonal";
            // 
            // button_Calculate
            // 
            this.button_Calculate.BackColor = System.Drawing.Color.Green;
            this.button_Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Calculate.Location = new System.Drawing.Point(282, 304);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(229, 63);
            this.button_Calculate.TabIndex = 7;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = false;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercise2_RectanglCalculator.Properties.Resources.chalkboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 469);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.label_Diagonal);
            this.Controls.Add(this.label_Perimeter);
            this.Controls.Add(this.label_Area);
            this.Controls.Add(this.textBox_Width);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.label_Width);
            this.Controls.Add(this.label_Length);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Length;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label_Area;
        private System.Windows.Forms.Label label_Perimeter;
        private System.Windows.Forms.Label label_Diagonal;
        private System.Windows.Forms.Button button_Calculate;
    }
}


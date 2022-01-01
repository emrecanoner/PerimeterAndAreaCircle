namespace CalculatingPerimeterandAreaofaCircle
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
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.tboxradius = new System.Windows.Forms.TextBox();
            this.tboxPi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.Location = new System.Drawing.Point(201, 50);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(75, 23);
            this.btnPerimeter.TabIndex = 0;
            this.btnPerimeter.Text = "Perimeter";
            this.btnPerimeter.UseVisualStyleBackColor = true;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // tboxradius
            // 
            this.tboxradius.Location = new System.Drawing.Point(78, 53);
            this.tboxradius.Name = "tboxradius";
            this.tboxradius.Size = new System.Drawing.Size(100, 20);
            this.tboxradius.TabIndex = 1;
            this.tboxradius.TextChanged += new System.EventHandler(this.tboxradius_TextChanged);
            // 
            // tboxPi
            // 
            this.tboxPi.Location = new System.Drawing.Point(78, 90);
            this.tboxPi.Name = "tboxPi";
            this.tboxPi.Size = new System.Drawing.Size(100, 20);
            this.tboxPi.TabIndex = 2;
            this.tboxPi.TextChanged += new System.EventHandler(this.tboxPi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pi:";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(201, 88);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 5;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPi);
            this.Controls.Add(this.tboxradius);
            this.Controls.Add(this.btnPerimeter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.TextBox tboxradius;
        private System.Windows.Forms.TextBox tboxPi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArea;
    }
}


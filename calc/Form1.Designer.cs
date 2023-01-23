namespace calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.equal = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.TextBox();
            this.vyber = new System.Windows.Forms.ComboBox();
            this.second = new System.Windows.Forms.TextBox();
            this.vysledek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(335, 323);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(152, 48);
            this.equal.TabIndex = 0;
            this.equal.Text = "button1";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(293, 65);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(236, 23);
            this.first.TabIndex = 1;
            // 
            // vyber
            // 
            this.vyber.FormattingEnabled = true;
            this.vyber.Location = new System.Drawing.Point(322, 116);
            this.vyber.Name = "vyber";
            this.vyber.Size = new System.Drawing.Size(184, 23);
            this.vyber.TabIndex = 2;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(293, 171);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(236, 23);
            this.second.TabIndex = 3;
            // 
            // vysledek
            // 
            this.vysledek.Location = new System.Drawing.Point(335, 232);
            this.vysledek.Name = "vysledek";
            this.vysledek.Size = new System.Drawing.Size(144, 23);
            this.vysledek.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vysledek);
            this.Controls.Add(this.second);
            this.Controls.Add(this.vyber);
            this.Controls.Add(this.first);
            this.Controls.Add(this.equal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button equal;
        private TextBox first;
        private ComboBox vyber;
        private TextBox second;
        private TextBox vysledek;
    }
}
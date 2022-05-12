
namespace v0512
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
            this.mybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mybutton
            // 
            this.mybutton.BackColor = System.Drawing.Color.Orange;
            this.mybutton.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mybutton.ForeColor = System.Drawing.Color.Red;
            this.mybutton.Location = new System.Drawing.Point(54, 100);
            this.mybutton.Name = "mybutton";
            this.mybutton.Size = new System.Drawing.Size(196, 93);
            this.mybutton.TabIndex = 0;
            this.mybutton.Text = "button1";
            this.mybutton.UseVisualStyleBackColor = false;
            this.mybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mybutton;
    }
}


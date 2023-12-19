
namespace Tyuiu.KarpovAA.Sprint7.Project.V12
{
    partial class FormAbout
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
            this.buttonOK_KAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK_KAA
            // 
            this.buttonOK_KAA.Location = new System.Drawing.Point(627, 355);
            this.buttonOK_KAA.Name = "buttonOK_KAA";
            this.buttonOK_KAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KAA.TabIndex = 0;
            this.buttonOK_KAA.Text = "OK";
            this.buttonOK_KAA.UseVisualStyleBackColor = true;
            this.buttonOK_KAA.Click += new System.EventHandler(this.buttonOK_KAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KAA;
    }
}
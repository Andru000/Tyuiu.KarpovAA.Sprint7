
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_KAA = new System.Windows.Forms.Button();
            this.labelTask_KAA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_KAA
            // 
            this.buttonOK_KAA.Location = new System.Drawing.Point(350, 170);
            this.buttonOK_KAA.Name = "buttonOK_KAA";
            this.buttonOK_KAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KAA.TabIndex = 0;
            this.buttonOK_KAA.Text = "OK";
            this.buttonOK_KAA.UseVisualStyleBackColor = true;
            this.buttonOK_KAA.Click += new System.EventHandler(this.buttonOK_KAA_Click);
            // 
            // labelTask_KAA
            // 
            this.labelTask_KAA.AutoSize = true;
            this.labelTask_KAA.Location = new System.Drawing.Point(141, 27);
            this.labelTask_KAA.Name = "labelTask_KAA";
            this.labelTask_KAA.Size = new System.Drawing.Size(284, 117);
            this.labelTask_KAA.TabIndex = 1;
            this.labelTask_KAA.Text = resources.GetString("labelTask_KAA.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.KarpovAA.Sprint7.Project.V12.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(32, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 207);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTask_KAA);
            this.Controls.Add(this.buttonOK_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KAA;
        private System.Windows.Forms.Label labelTask_KAA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
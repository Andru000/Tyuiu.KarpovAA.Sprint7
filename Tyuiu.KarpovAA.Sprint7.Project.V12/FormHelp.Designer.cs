
namespace Tyuiu.KarpovAA.Sprint7.Project.V12
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.buttonOK_KAA = new System.Windows.Forms.Button();
            this.textBoxTitle_KAA = new System.Windows.Forms.TextBox();
            this.panelFull_KAA = new System.Windows.Forms.Panel();
            this.textBoxTask_KAA = new System.Windows.Forms.TextBox();
            this.panelFull_KAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK_KAA
            // 
            this.buttonOK_KAA.BackColor = System.Drawing.Color.Gray;
            this.buttonOK_KAA.Location = new System.Drawing.Point(796, 456);
            this.buttonOK_KAA.Name = "buttonOK_KAA";
            this.buttonOK_KAA.Size = new System.Drawing.Size(88, 67);
            this.buttonOK_KAA.TabIndex = 0;
            this.buttonOK_KAA.Text = "OK";
            this.buttonOK_KAA.UseVisualStyleBackColor = false;
            this.buttonOK_KAA.Click += new System.EventHandler(this.buttonOK_KAA_Click);
            // 
            // textBoxTitle_KAA
            // 
            this.textBoxTitle_KAA.BackColor = System.Drawing.Color.Gray;
            this.textBoxTitle_KAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxTitle_KAA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTitle_KAA.Location = new System.Drawing.Point(305, 12);
            this.textBoxTitle_KAA.Multiline = true;
            this.textBoxTitle_KAA.Name = "textBoxTitle_KAA";
            this.textBoxTitle_KAA.ReadOnly = true;
            this.textBoxTitle_KAA.Size = new System.Drawing.Size(270, 29);
            this.textBoxTitle_KAA.TabIndex = 1;
            this.textBoxTitle_KAA.Text = "Руководство пользователя";
            // 
            // panelFull_KAA
            // 
            this.panelFull_KAA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelFull_KAA.Controls.Add(this.textBoxTask_KAA);
            this.panelFull_KAA.Controls.Add(this.textBoxTitle_KAA);
            this.panelFull_KAA.Controls.Add(this.buttonOK_KAA);
            this.panelFull_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull_KAA.Location = new System.Drawing.Point(0, 0);
            this.panelFull_KAA.Name = "panelFull_KAA";
            this.panelFull_KAA.Size = new System.Drawing.Size(916, 554);
            this.panelFull_KAA.TabIndex = 2;
            // 
            // textBoxTask_KAA
            // 
            this.textBoxTask_KAA.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxTask_KAA.Location = new System.Drawing.Point(12, 47);
            this.textBoxTask_KAA.Multiline = true;
            this.textBoxTask_KAA.Name = "textBoxTask_KAA";
            this.textBoxTask_KAA.ReadOnly = true;
            this.textBoxTask_KAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTask_KAA.Size = new System.Drawing.Size(755, 495);
            this.textBoxTask_KAA.TabIndex = 2;
            this.textBoxTask_KAA.Text = resources.GetString("textBoxTask_KAA.Text");
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 554);
            this.Controls.Add(this.panelFull_KAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.panelFull_KAA.ResumeLayout(false);
            this.panelFull_KAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KAA;
        private System.Windows.Forms.TextBox textBoxTitle_KAA;
        private System.Windows.Forms.Panel panelFull_KAA;
        private System.Windows.Forms.TextBox textBoxTask_KAA;
    }
}
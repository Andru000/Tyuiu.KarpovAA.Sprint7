
namespace Tyuiu.KarpovAA.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDone_KAA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDone_KAA
            // 
            this.buttonDone_KAA.Location = new System.Drawing.Point(628, 368);
            this.buttonDone_KAA.Name = "buttonDone_KAA";
            this.buttonDone_KAA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_KAA.TabIndex = 0;
            this.buttonDone_KAA.Text = "Выполнить";
            this.buttonDone_KAA.UseVisualStyleBackColor = true;
            this.buttonDone_KAA.Click += new System.EventHandler(this.buttonDone_KAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_KAA);
            this.Name = "FormMain";
            this.Text = "Спринт 7 | Task Project | Вариант 12 | Карпов А. А.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_KAA;
    }
}


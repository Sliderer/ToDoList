
namespace ToDoList
{
    partial class Form1
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
            this.addNote = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.descriotion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addNote
            // 
            this.addNote.Location = new System.Drawing.Point(368, 287);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(75, 23);
            this.addNote.TabIndex = 0;
            this.addNote.Text = "Add";
            this.addNote.UseVisualStyleBackColor = true;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(318, 67);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 22);
            this.title.TabIndex = 1;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(318, 125);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(157, 22);
            this.date.TabIndex = 2;
            // 
            // descriotion
            // 
            this.descriotion.Location = new System.Drawing.Point(318, 195);
            this.descriotion.Name = "descriotion";
            this.descriotion.Size = new System.Drawing.Size(157, 22);
            this.descriotion.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(773, 367);
            this.Controls.Add(this.descriotion);
            this.Controls.Add(this.date);
            this.Controls.Add(this.title);
            this.Controls.Add(this.addNote);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNoteButtom;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox descriotion;
    }
}


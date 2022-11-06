namespace Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.vscode = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pycharm = new System.Windows.Forms.CheckBox();
            this.python = new System.Windows.Forms.CheckBox();
            this.telegram = new System.Windows.Forms.CheckBox();
            this.Git = new System.Windows.Forms.CheckBox();
            this.nodeJS = new System.Windows.Forms.CheckBox();
            this.visualSC = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(36, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Установить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vscode
            // 
            this.vscode.AutoSize = true;
            this.vscode.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vscode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vscode.Location = new System.Drawing.Point(19, 21);
            this.vscode.Name = "vscode";
            this.vscode.Size = new System.Drawing.Size(107, 29);
            this.vscode.TabIndex = 1;
            this.vscode.Text = "VS CODE";
            this.vscode.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pycharm);
            this.panel1.Controls.Add(this.python);
            this.panel1.Controls.Add(this.telegram);
            this.panel1.Controls.Add(this.Git);
            this.panel1.Controls.Add(this.nodeJS);
            this.panel1.Controls.Add(this.visualSC);
            this.panel1.Controls.Add(this.vscode);
            this.panel1.Location = new System.Drawing.Point(36, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 279);
            this.panel1.TabIndex = 2;
            // 
            // pycharm
            // 
            this.pycharm.AutoSize = true;
            this.pycharm.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pycharm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pycharm.Location = new System.Drawing.Point(19, 91);
            this.pycharm.Name = "pycharm";
            this.pycharm.Size = new System.Drawing.Size(104, 29);
            this.pycharm.TabIndex = 7;
            this.pycharm.Text = "Pycharm";
            this.pycharm.UseVisualStyleBackColor = true;
            // 
            // python
            // 
            this.python.AutoSize = true;
            this.python.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.python.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.python.Location = new System.Drawing.Point(19, 126);
            this.python.Name = "python";
            this.python.Size = new System.Drawing.Size(145, 29);
            this.python.TabIndex = 6;
            this.python.Text = "Python (3.9.7)";
            this.python.UseVisualStyleBackColor = true;
            // 
            // telegram
            // 
            this.telegram.AutoSize = true;
            this.telegram.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telegram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.telegram.Location = new System.Drawing.Point(19, 231);
            this.telegram.Name = "telegram";
            this.telegram.Size = new System.Drawing.Size(110, 29);
            this.telegram.TabIndex = 3;
            this.telegram.Text = "Telegram";
            this.telegram.UseVisualStyleBackColor = true;
            // 
            // Git
            // 
            this.Git.AutoSize = true;
            this.Git.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Git.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Git.Location = new System.Drawing.Point(19, 161);
            this.Git.Name = "Git";
            this.Git.Size = new System.Drawing.Size(55, 29);
            this.Git.TabIndex = 5;
            this.Git.Text = "Git";
            this.Git.UseVisualStyleBackColor = true;
            // 
            // nodeJS
            // 
            this.nodeJS.AutoSize = true;
            this.nodeJS.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeJS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nodeJS.Location = new System.Drawing.Point(19, 196);
            this.nodeJS.Name = "nodeJS";
            this.nodeJS.Size = new System.Drawing.Size(99, 29);
            this.nodeJS.TabIndex = 4;
            this.nodeJS.Text = "Node JS";
            this.nodeJS.UseVisualStyleBackColor = true;
            // 
            // visualSC
            // 
            this.visualSC.AutoSize = true;
            this.visualSC.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualSC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visualSC.Location = new System.Drawing.Point(19, 56);
            this.visualSC.Name = "visualSC";
            this.visualSC.Size = new System.Drawing.Size(190, 29);
            this.visualSC.TabIndex = 2;
            this.visualSC.Text = "Visual Studio Code";
            this.visualSC.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 360);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(422, 42);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите галочки и нажмите на кнопку установить, после чего вам установятся устан" +
    "овщики на рабочий стол";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test
            // 
            this.test.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(32, 478);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(416, 40);
            this.test.TabIndex = 5;
            this.test.Text = "Название программы";
            this.test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 527);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "@ENCODEE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox vscode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox pycharm;
        private System.Windows.Forms.CheckBox python;
        private System.Windows.Forms.CheckBox Git;
        private System.Windows.Forms.CheckBox nodeJS;
        private System.Windows.Forms.CheckBox telegram;
        private System.Windows.Forms.CheckBox visualSC;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label test;
    }
}


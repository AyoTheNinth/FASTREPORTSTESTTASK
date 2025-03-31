namespace FASTREPORTSTESTTASK
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
            this.MakeRectangleButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RectangleHeightTxtBx = new System.Windows.Forms.TextBox();
            this.RectWidthTxtBx = new System.Windows.Forms.TextBox();
            this.RaduisTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MakeRectangleButton
            // 
            this.MakeRectangleButton.Location = new System.Drawing.Point(632, 102);
            this.MakeRectangleButton.Name = "MakeRectangleButton";
            this.MakeRectangleButton.Size = new System.Drawing.Size(147, 43);
            this.MakeRectangleButton.TabIndex = 1;
            this.MakeRectangleButton.Text = "Создать прямоугольник";
            this.MakeRectangleButton.UseVisualStyleBackColor = true;
            this.MakeRectangleButton.Click += new System.EventHandler(this.MakeRectangleButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Тут должен был быть кружочек";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "а тут треугольничек";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 416);
            this.panel1.TabIndex = 4;
            // 
            // RectangleHeightTxtBx
            // 
            this.RectangleHeightTxtBx.Location = new System.Drawing.Point(631, 76);
            this.RectangleHeightTxtBx.Name = "RectangleHeightTxtBx";
            this.RectangleHeightTxtBx.Size = new System.Drawing.Size(80, 20);
            this.RectangleHeightTxtBx.TabIndex = 9;
            // 
            // RectWidthTxtBx
            // 
            this.RectWidthTxtBx.Location = new System.Drawing.Point(632, 50);
            this.RectWidthTxtBx.Name = "RectWidthTxtBx";
            this.RectWidthTxtBx.Size = new System.Drawing.Size(79, 20);
            this.RectWidthTxtBx.TabIndex = 10;
            // 
            // RaduisTxtBx
            // 
            this.RaduisTxtBx.Location = new System.Drawing.Point(631, 205);
            this.RaduisTxtBx.Name = "RaduisTxtBx";
            this.RaduisTxtBx.Size = new System.Drawing.Size(80, 20);
            this.RaduisTxtBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Длина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Радиус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaduisTxtBx);
            this.Controls.Add(this.RectWidthTxtBx);
            this.Controls.Add(this.RectangleHeightTxtBx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MakeRectangleButton);
            this.MaximumSize = new System.Drawing.Size(816, 480);
            this.MinimumSize = new System.Drawing.Size(816, 480);
            this.Name = "Form1";
            this.Text = "Тестовое задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MakeRectangleButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RectangleHeightTxtBx;
        private System.Windows.Forms.TextBox RectWidthTxtBx;
        private System.Windows.Forms.TextBox RaduisTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


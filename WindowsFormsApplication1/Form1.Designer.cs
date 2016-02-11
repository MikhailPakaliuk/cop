namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelOffsetWidth = new System.Windows.Forms.Label();
            this.labelOffsetLong = new System.Windows.Forms.Label();
            this.labelWidhtUpperBase = new System.Windows.Forms.Label();
            this.labelLongUpperBase = new System.Windows.Forms.Label();
            this.labelWidhtBottomBase = new System.Windows.Forms.Label();
            this.labelLongBottomBase = new System.Windows.Forms.Label();
            this.textBoxOffsetWidth = new System.Windows.Forms.TextBox();
            this.textBoxOffsetLong = new System.Windows.Forms.TextBox();
            this.textBoxWidthUpperBase = new System.Windows.Forms.TextBox();
            this.textBoxLongUpperBase = new System.Windows.Forms.TextBox();
            this.textBoxWidthBottomBase = new System.Windows.Forms.TextBox();
            this.textBoxLongBottomBase = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(486, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 253);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Входные данные";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.labelHeight);
            this.groupBox1.Controls.Add(this.labelOffsetWidth);
            this.groupBox1.Controls.Add(this.labelOffsetLong);
            this.groupBox1.Controls.Add(this.labelWidhtUpperBase);
            this.groupBox1.Controls.Add(this.labelLongUpperBase);
            this.groupBox1.Controls.Add(this.labelWidhtBottomBase);
            this.groupBox1.Controls.Add(this.labelLongBottomBase);
            this.groupBox1.Controls.Add(this.textBoxOffsetWidth);
            this.groupBox1.Controls.Add(this.textBoxOffsetLong);
            this.groupBox1.Controls.Add(this.textBoxWidthUpperBase);
            this.groupBox1.Controls.Add(this.textBoxLongUpperBase);
            this.groupBox1.Controls.Add(this.textBoxWidthBottomBase);
            this.groupBox1.Controls.Add(this.textBoxLongBottomBase);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 215);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(177, 164);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(65, 20);
            this.textBoxHeight.TabIndex = 15;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(126, 167);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(45, 13);
            this.labelHeight.TabIndex = 14;
            this.labelHeight.Text = "Высота";
            // 
            // labelOffsetWidth
            // 
            this.labelOffsetWidth.AutoSize = true;
            this.labelOffsetWidth.Location = new System.Drawing.Point(303, 120);
            this.labelOffsetWidth.Name = "labelOffsetWidth";
            this.labelOffsetWidth.Size = new System.Drawing.Size(117, 13);
            this.labelOffsetWidth.TabIndex = 13;
            this.labelOffsetWidth.Text = "Смещение по ширине";
            // 
            // labelOffsetLong
            // 
            this.labelOffsetLong.AutoSize = true;
            this.labelOffsetLong.Location = new System.Drawing.Point(56, 120);
            this.labelOffsetLong.Name = "labelOffsetLong";
            this.labelOffsetLong.Size = new System.Drawing.Size(115, 13);
            this.labelOffsetLong.TabIndex = 12;
            this.labelOffsetLong.Text = "Смещение по длинне";
            // 
            // labelWidhtUpperBase
            // 
            this.labelWidhtUpperBase.AutoSize = true;
            this.labelWidhtUpperBase.Location = new System.Drawing.Point(273, 74);
            this.labelWidhtUpperBase.Name = "labelWidhtUpperBase";
            this.labelWidhtUpperBase.Size = new System.Drawing.Size(147, 13);
            this.labelWidhtUpperBase.TabIndex = 11;
            this.labelWidhtUpperBase.Text = "Ширина вернего основания";
            // 
            // labelLongUpperBase
            // 
            this.labelLongUpperBase.AutoSize = true;
            this.labelLongUpperBase.Location = new System.Drawing.Point(19, 74);
            this.labelLongUpperBase.Name = "labelLongUpperBase";
            this.labelLongUpperBase.Size = new System.Drawing.Size(152, 13);
            this.labelLongUpperBase.TabIndex = 10;
            this.labelLongUpperBase.Text = "Длинна верхнего основания";
            // 
            // labelWidhtBottomBase
            // 
            this.labelWidhtBottomBase.AutoSize = true;
            this.labelWidhtBottomBase.Location = new System.Drawing.Point(273, 31);
            this.labelWidhtBottomBase.Name = "labelWidhtBottomBase";
            this.labelWidhtBottomBase.Size = new System.Drawing.Size(149, 13);
            this.labelWidhtBottomBase.TabIndex = 9;
            this.labelWidhtBottomBase.Text = "Ширина нижнего основания";
            // 
            // labelLongBottomBase
            // 
            this.labelLongBottomBase.AutoSize = true;
            this.labelLongBottomBase.Location = new System.Drawing.Point(22, 31);
            this.labelLongBottomBase.Name = "labelLongBottomBase";
            this.labelLongBottomBase.Size = new System.Drawing.Size(149, 13);
            this.labelLongBottomBase.TabIndex = 8;
            this.labelLongBottomBase.Text = "Длинна нижнего основания";
            // 
            // textBoxOffsetWidth
            // 
            this.textBoxOffsetWidth.Location = new System.Drawing.Point(428, 117);
            this.textBoxOffsetWidth.Name = "textBoxOffsetWidth";
            this.textBoxOffsetWidth.Size = new System.Drawing.Size(65, 20);
            this.textBoxOffsetWidth.TabIndex = 7;
            // 
            // textBoxOffsetLong
            // 
            this.textBoxOffsetLong.Location = new System.Drawing.Point(177, 117);
            this.textBoxOffsetLong.Name = "textBoxOffsetLong";
            this.textBoxOffsetLong.Size = new System.Drawing.Size(65, 20);
            this.textBoxOffsetLong.TabIndex = 6;
            // 
            // textBoxWidthUpperBase
            // 
            this.textBoxWidthUpperBase.Location = new System.Drawing.Point(428, 71);
            this.textBoxWidthUpperBase.Name = "textBoxWidthUpperBase";
            this.textBoxWidthUpperBase.Size = new System.Drawing.Size(65, 20);
            this.textBoxWidthUpperBase.TabIndex = 5;
            // 
            // textBoxLongUpperBase
            // 
            this.textBoxLongUpperBase.Location = new System.Drawing.Point(177, 71);
            this.textBoxLongUpperBase.Name = "textBoxLongUpperBase";
            this.textBoxLongUpperBase.Size = new System.Drawing.Size(65, 20);
            this.textBoxLongUpperBase.TabIndex = 4;
            // 
            // textBoxWidthBottomBase
            // 
            this.textBoxWidthBottomBase.Location = new System.Drawing.Point(428, 28);
            this.textBoxWidthBottomBase.Name = "textBoxWidthBottomBase";
            this.textBoxWidthBottomBase.Size = new System.Drawing.Size(65, 20);
            this.textBoxWidthBottomBase.TabIndex = 3;
            // 
            // textBoxLongBottomBase
            // 
            this.textBoxLongBottomBase.Location = new System.Drawing.Point(177, 28);
            this.textBoxLongBottomBase.Name = "textBoxLongBottomBase";
            this.textBoxLongBottomBase.Size = new System.Drawing.Size(65, 20);
            this.textBoxLongBottomBase.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выходные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 413);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelOffsetWidth;
        private System.Windows.Forms.Label labelOffsetLong;
        private System.Windows.Forms.Label labelWidhtUpperBase;
        private System.Windows.Forms.Label labelLongUpperBase;
        private System.Windows.Forms.Label labelWidhtBottomBase;
        private System.Windows.Forms.Label labelLongBottomBase;
        private System.Windows.Forms.TextBox textBoxOffsetWidth;
        private System.Windows.Forms.TextBox textBoxOffsetLong;
        private System.Windows.Forms.TextBox textBoxWidthUpperBase;
        private System.Windows.Forms.TextBox textBoxLongUpperBase;
        private System.Windows.Forms.TextBox textBoxWidthBottomBase;
        private System.Windows.Forms.TextBox textBoxLongBottomBase;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}


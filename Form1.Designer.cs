namespace TiMP_CourseWork
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstCoeftb = new System.Windows.Forms.TextBox();
            this.secondCoeftb = new System.Windows.Forms.TextBox();
            this.thirdCoeftb = new System.Windows.Forms.TextBox();
            this.freeCoeftb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.intervaltb1 = new System.Windows.Forms.TextBox();
            this.intervaltb2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.steptb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.executebtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.zeroYtb1 = new System.Windows.Forms.TextBox();
            this.zeroZtb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clrbtn = new System.Windows.Forms.Button();
            this.dbchbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "y\'\' +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(608, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "z0=y\'(x0)= ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "y =";
            // 
            // firstCoeftb
            // 
            this.firstCoeftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstCoeftb.Location = new System.Drawing.Point(14, 21);
            this.firstCoeftb.Name = "firstCoeftb";
            this.firstCoeftb.Size = new System.Drawing.Size(72, 30);
            this.firstCoeftb.TabIndex = 3;
            this.firstCoeftb.Text = "1";
            this.firstCoeftb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstCoeftb_KeyPress);
            // 
            // secondCoeftb
            // 
            this.secondCoeftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondCoeftb.Location = new System.Drawing.Point(150, 21);
            this.secondCoeftb.Name = "secondCoeftb";
            this.secondCoeftb.Size = new System.Drawing.Size(72, 30);
            this.secondCoeftb.TabIndex = 3;
            this.secondCoeftb.Text = "-x";
            this.secondCoeftb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondCoeftb_KeyPress);
            // 
            // thirdCoeftb
            // 
            this.thirdCoeftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdCoeftb.Location = new System.Drawing.Point(282, 21);
            this.thirdCoeftb.Name = "thirdCoeftb";
            this.thirdCoeftb.Size = new System.Drawing.Size(72, 30);
            this.thirdCoeftb.TabIndex = 3;
            this.thirdCoeftb.Text = "2x";
            this.thirdCoeftb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdCoeftb_KeyPress);
            this.thirdCoeftb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.thirdCoeftb_KeyUp);
            this.thirdCoeftb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.thirdCoeftb_PreviewKeyDown);
            // 
            // freeCoeftb
            // 
            this.freeCoeftb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.freeCoeftb.Location = new System.Drawing.Point(410, 21);
            this.freeCoeftb.Name = "freeCoeftb";
            this.freeCoeftb.Size = new System.Drawing.Size(72, 30);
            this.freeCoeftb.TabIndex = 3;
            this.freeCoeftb.Text = "0,8";
            this.freeCoeftb.TextChanged += new System.EventHandler(this.freeCoeftb_TextChanged);
            this.freeCoeftb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.freeCoeftb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите дифференциальное уравнение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите диапазон изменения аргумента:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "x ∈ [";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(150, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = ";";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(253, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "]";
            // 
            // intervaltb1
            // 
            this.intervaltb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervaltb1.Location = new System.Drawing.Point(72, 78);
            this.intervaltb1.Name = "intervaltb1";
            this.intervaltb1.Size = new System.Drawing.Size(72, 30);
            this.intervaltb1.TabIndex = 3;
            this.intervaltb1.Text = "1,5";
            this.intervaltb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervaltb1_KeyPress);
            // 
            // intervaltb2
            // 
            this.intervaltb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intervaltb2.Location = new System.Drawing.Point(175, 79);
            this.intervaltb2.Name = "intervaltb2";
            this.intervaltb2.Size = new System.Drawing.Size(72, 30);
            this.intervaltb2.TabIndex = 3;
            this.intervaltb2.Text = "2,5";
            this.intervaltb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervaltb2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(361, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Шаг изменения аргумента:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(360, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "h =";
            // 
            // steptb
            // 
            this.steptb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steptb.Location = new System.Drawing.Point(412, 79);
            this.steptb.Name = "steptb";
            this.steptb.Size = new System.Drawing.Size(72, 30);
            this.steptb.TabIndex = 3;
            this.steptb.Text = "0,1";
            this.steptb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.steptb_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(10, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Вывод:";
            // 
            // executebtn
            // 
            this.executebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.executebtn.Location = new System.Drawing.Point(155, 127);
            this.executebtn.Name = "executebtn";
            this.executebtn.Size = new System.Drawing.Size(124, 35);
            this.executebtn.TabIndex = 8;
            this.executebtn.Text = "Вычислить";
            this.executebtn.UseVisualStyleBackColor = false;
            this.executebtn.Click += new System.EventHandler(this.executebtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(609, -3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Введите значение функции:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(608, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 29);
            this.label13.TabIndex = 2;
            this.label13.Text = "y0(x0) =";
            // 
            // zeroYtb1
            // 
            this.zeroYtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroYtb1.Location = new System.Drawing.Point(711, 22);
            this.zeroYtb1.Name = "zeroYtb1";
            this.zeroYtb1.Size = new System.Drawing.Size(72, 30);
            this.zeroYtb1.TabIndex = 3;
            this.zeroYtb1.Text = "-0,2";
            this.zeroYtb1.TextChanged += new System.EventHandler(this.zeroYtb1_TextChanged);
            this.zeroYtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zeroYtb1_KeyPress);
            // 
            // zeroZtb
            // 
            this.zeroZtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroZtb.Location = new System.Drawing.Point(740, 79);
            this.zeroZtb.Name = "zeroZtb";
            this.zeroZtb.Size = new System.Drawing.Size(72, 30);
            this.zeroZtb.TabIndex = 3;
            this.zeroZtb.Text = "2";
            this.zeroZtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zeroZtb_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(231, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "y\' +";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 357);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clrbtn.Location = new System.Drawing.Point(308, 127);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(118, 35);
            this.clrbtn.TabIndex = 10;
            this.clrbtn.Text = "Очистить";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // dbchbox
            // 
            this.dbchbox.AutoSize = true;
            this.dbchbox.Location = new System.Drawing.Point(634, 127);
            this.dbchbox.Name = "dbchbox";
            this.dbchbox.Size = new System.Drawing.Size(219, 20);
            this.dbchbox.TabIndex = 11;
            this.dbchbox.Text = "Автоматическая запись в БД";
            this.dbchbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(865, 552);
            this.Controls.Add(this.dbchbox);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.executebtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zeroZtb);
            this.Controls.Add(this.zeroYtb1);
            this.Controls.Add(this.steptb);
            this.Controls.Add(this.freeCoeftb);
            this.Controls.Add(this.thirdCoeftb);
            this.Controls.Add(this.secondCoeftb);
            this.Controls.Add(this.intervaltb2);
            this.Controls.Add(this.intervaltb1);
            this.Controls.Add(this.firstCoeftb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Курсовая работа студента Лобко Даниила группы 3135";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstCoeftb;
        private System.Windows.Forms.TextBox secondCoeftb;
        private System.Windows.Forms.TextBox thirdCoeftb;
        private System.Windows.Forms.TextBox freeCoeftb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox intervaltb1;
        public System.Windows.Forms.TextBox intervaltb2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox steptb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button executebtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        //private System.Windows.Forms.TextBox zeroytb;
        private System.Windows.Forms.TextBox zeroYtb1;
        private System.Windows.Forms.TextBox zeroZtb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.CheckBox dbchbox;
    }
}


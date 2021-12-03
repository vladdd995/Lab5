
namespace Lab5
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
            this.Cipher = new System.Windows.Forms.LinkLabel();
            this.Author = new System.Windows.Forms.LinkLabel();
            this.Clear = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelFileOUT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFileOpen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SHA_512 = new System.Windows.Forms.RadioButton();
            this.SHA_384 = new System.Windows.Forms.RadioButton();
            this.SHA_256 = new System.Windows.Forms.RadioButton();
            this.SHA_1 = new System.Windows.Forms.RadioButton();
            this.MD5 = new System.Windows.Forms.RadioButton();
            this.RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.HashAlgorithm = new System.Windows.Forms.RadioButton();
            this.CRC32 = new System.Windows.Forms.RadioButton();
            this.fileOUT = new System.Windows.Forms.Button();
            this.fileOpen = new System.Windows.Forms.Button();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.textBox_fileOpen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cipher
            // 
            this.Cipher.AutoSize = true;
            this.Cipher.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cipher.Location = new System.Drawing.Point(158, 247);
            this.Cipher.Name = "Cipher";
            this.Cipher.Size = new System.Drawing.Size(53, 21);
            this.Cipher.TabIndex = 31;
            this.Cipher.TabStop = true;
            this.Cipher.Text = "Опис";
            this.Cipher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cipher_LinkClicked);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(20, 247);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(60, 21);
            this.Author.TabIndex = 30;
            this.Author.TabStop = true;
            this.Author.Text = "Автор";
            this.Author.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Author_LinkClicked);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(404, 209);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(120, 35);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "Очистити";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(278, 211);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(120, 35);
            this.start.TabIndex = 28;
            this.start.Text = "Виконати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelFileOUT);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(278, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 49);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Мбайт)";
            // 
            // labelFileOUT
            // 
            this.labelFileOUT.AutoSize = true;
            this.labelFileOUT.Location = new System.Drawing.Point(16, 25);
            this.labelFileOUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileOUT.Name = "labelFileOUT";
            this.labelFileOUT.Size = new System.Drawing.Size(157, 21);
            this.labelFileOUT.TabIndex = 2;
            this.labelFileOUT.Text = "Вхідний файл:  ???";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFileOpen);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(278, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 49);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт)";
            // 
            // labelFileOpen
            // 
            this.labelFileOpen.AutoSize = true;
            this.labelFileOpen.Location = new System.Drawing.Point(14, 24);
            this.labelFileOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileOpen.Name = "labelFileOpen";
            this.labelFileOpen.Size = new System.Drawing.Size(157, 21);
            this.labelFileOpen.TabIndex = 2;
            this.labelFileOpen.Text = "Вхідний файл:  ???";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SHA_512);
            this.groupBox1.Controls.Add(this.SHA_384);
            this.groupBox1.Controls.Add(this.SHA_256);
            this.groupBox1.Controls.Add(this.SHA_1);
            this.groupBox1.Controls.Add(this.MD5);
            this.groupBox1.Controls.Add(this.RIPEMD160);
            this.groupBox1.Controls.Add(this.HashAlgorithm);
            this.groupBox1.Controls.Add(this.CRC32);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(17, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 148);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи";
            // 
            // SHA_512
            // 
            this.SHA_512.AutoSize = true;
            this.SHA_512.Location = new System.Drawing.Point(145, 114);
            this.SHA_512.Name = "SHA_512";
            this.SHA_512.Size = new System.Drawing.Size(98, 25);
            this.SHA_512.TabIndex = 7;
            this.SHA_512.TabStop = true;
            this.SHA_512.Text = "SHA-512";
            this.SHA_512.UseVisualStyleBackColor = true;
            // 
            // SHA_384
            // 
            this.SHA_384.AutoSize = true;
            this.SHA_384.Location = new System.Drawing.Point(145, 85);
            this.SHA_384.Name = "SHA_384";
            this.SHA_384.Size = new System.Drawing.Size(98, 25);
            this.SHA_384.TabIndex = 6;
            this.SHA_384.TabStop = true;
            this.SHA_384.Text = "SHA-384";
            this.SHA_384.UseVisualStyleBackColor = true;
            // 
            // SHA_256
            // 
            this.SHA_256.AutoSize = true;
            this.SHA_256.Location = new System.Drawing.Point(145, 55);
            this.SHA_256.Name = "SHA_256";
            this.SHA_256.Size = new System.Drawing.Size(98, 25);
            this.SHA_256.TabIndex = 5;
            this.SHA_256.TabStop = true;
            this.SHA_256.Text = "SHA-256";
            this.SHA_256.UseVisualStyleBackColor = true;
            // 
            // SHA_1
            // 
            this.SHA_1.AutoSize = true;
            this.SHA_1.Location = new System.Drawing.Point(145, 25);
            this.SHA_1.Name = "SHA_1";
            this.SHA_1.Size = new System.Drawing.Size(80, 25);
            this.SHA_1.TabIndex = 4;
            this.SHA_1.TabStop = true;
            this.SHA_1.Text = "SHA-1";
            this.SHA_1.UseVisualStyleBackColor = true;
            // 
            // MD5
            // 
            this.MD5.AutoSize = true;
            this.MD5.Location = new System.Drawing.Point(7, 115);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(66, 25);
            this.MD5.TabIndex = 3;
            this.MD5.TabStop = true;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // RIPEMD160
            // 
            this.RIPEMD160.AutoSize = true;
            this.RIPEMD160.Location = new System.Drawing.Point(7, 86);
            this.RIPEMD160.Name = "RIPEMD160";
            this.RIPEMD160.Size = new System.Drawing.Size(125, 25);
            this.RIPEMD160.TabIndex = 2;
            this.RIPEMD160.TabStop = true;
            this.RIPEMD160.Text = "RIPEMD160";
            this.RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // HashAlgorithm
            // 
            this.HashAlgorithm.AutoSize = true;
            this.HashAlgorithm.Location = new System.Drawing.Point(7, 56);
            this.HashAlgorithm.Name = "HashAlgorithm";
            this.HashAlgorithm.Size = new System.Drawing.Size(140, 25);
            this.HashAlgorithm.TabIndex = 1;
            this.HashAlgorithm.TabStop = true;
            this.HashAlgorithm.Text = "HashAlgorithm";
            this.HashAlgorithm.UseVisualStyleBackColor = true;
            // 
            // CRC32
            // 
            this.CRC32.AutoSize = true;
            this.CRC32.Location = new System.Drawing.Point(7, 26);
            this.CRC32.Name = "CRC32";
            this.CRC32.Size = new System.Drawing.Size(85, 25);
            this.CRC32.TabIndex = 0;
            this.CRC32.TabStop = true;
            this.CRC32.Text = "CRC32";
            this.CRC32.UseVisualStyleBackColor = true;
            // 
            // fileOUT
            // 
            this.fileOUT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileOUT.Location = new System.Drawing.Point(499, 57);
            this.fileOUT.Name = "fileOUT";
            this.fileOUT.Size = new System.Drawing.Size(45, 26);
            this.fileOUT.TabIndex = 22;
            this.fileOUT.Text = "...";
            this.fileOUT.UseVisualStyleBackColor = true;
            this.fileOUT.Click += new System.EventHandler(this.fileOUT_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileOpen.Location = new System.Drawing.Point(499, 18);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(45, 26);
            this.fileOpen.TabIndex = 21;
            this.fileOpen.Text = "...";
            this.fileOpen.UseVisualStyleBackColor = true;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(140, 58);
            this.textBox_fileOUT.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(352, 20);
            this.textBox_fileOUT.TabIndex = 20;
            // 
            // textBox_fileOpen
            // 
            this.textBox_fileOpen.Location = new System.Drawing.Point(140, 18);
            this.textBox_fileOpen.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fileOpen.Name = "textBox_fileOpen";
            this.textBox_fileOpen.Size = new System.Drawing.Size(352, 20);
            this.textBox_fileOpen.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вихідний файл";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Вхідний файл";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 275);
            this.Controls.Add(this.Cipher);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileOUT);
            this.Controls.Add(this.fileOpen);
            this.Controls.Add(this.textBox_fileOUT);
            this.Controls.Add(this.textBox_fileOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Циклічний надлишковий код";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Cipher;
        private System.Windows.Forms.LinkLabel Author;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelFileOUT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFileOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SHA_512;
        private System.Windows.Forms.RadioButton SHA_384;
        private System.Windows.Forms.RadioButton SHA_256;
        private System.Windows.Forms.RadioButton SHA_1;
        private System.Windows.Forms.RadioButton MD5;
        private System.Windows.Forms.RadioButton RIPEMD160;
        private System.Windows.Forms.RadioButton HashAlgorithm;
        private System.Windows.Forms.RadioButton CRC32;
        private System.Windows.Forms.Button fileOUT;
        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


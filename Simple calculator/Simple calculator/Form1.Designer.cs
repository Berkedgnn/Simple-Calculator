namespace Simple_calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmbr1 = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.nmbr2 = new System.Windows.Forms.Button();
            this.nmbr3 = new System.Windows.Forms.Button();
            this.nmbr4 = new System.Windows.Forms.Button();
            this.nmbr5 = new System.Windows.Forms.Button();
            this.nmbr6 = new System.Windows.Forms.Button();
            this.nmbr7 = new System.Windows.Forms.Button();
            this.nmbr8 = new System.Windows.Forms.Button();
            this.nmbr9 = new System.Windows.Forms.Button();
            this.cross_op = new System.Windows.Forms.Button();
            this.minus_op = new System.Windows.Forms.Button();
            this.plus_op = new System.Windows.Forms.Button();
            this.division_op = new System.Windows.Forms.Button();
            this.nmbr0 = new System.Windows.Forms.Button();
            this.equal_op = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nmbr1
            // 
            this.nmbr1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr1.Location = new System.Drawing.Point(27, 141);
            this.nmbr1.Name = "nmbr1";
            this.nmbr1.Size = new System.Drawing.Size(99, 71);
            this.nmbr1.TabIndex = 0;
            this.nmbr1.Text = "1";
            this.nmbr1.UseVisualStyleBackColor = false;
            this.nmbr1.Click += new System.EventHandler(this.button1_Click);
            // 
            // screen
            // 
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(27, 30);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(390, 59);
            this.screen.TabIndex = 1;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmbr2
            // 
            this.nmbr2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr2.Location = new System.Drawing.Point(132, 142);
            this.nmbr2.Name = "nmbr2";
            this.nmbr2.Size = new System.Drawing.Size(100, 70);
            this.nmbr2.TabIndex = 2;
            this.nmbr2.Text = "2";
            this.nmbr2.UseVisualStyleBackColor = false;
            this.nmbr2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nmbr3
            // 
            this.nmbr3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr3.Location = new System.Drawing.Point(238, 142);
            this.nmbr3.Name = "nmbr3";
            this.nmbr3.Size = new System.Drawing.Size(100, 71);
            this.nmbr3.TabIndex = 3;
            this.nmbr3.Text = "3";
            this.nmbr3.UseVisualStyleBackColor = false;
            this.nmbr3.Click += new System.EventHandler(this.nmbr3_Click);
            // 
            // nmbr4
            // 
            this.nmbr4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr4.Location = new System.Drawing.Point(27, 217);
            this.nmbr4.Name = "nmbr4";
            this.nmbr4.Size = new System.Drawing.Size(99, 69);
            this.nmbr4.TabIndex = 4;
            this.nmbr4.Text = "4";
            this.nmbr4.UseVisualStyleBackColor = false;
            this.nmbr4.Click += new System.EventHandler(this.nmbr4_Click);
            // 
            // nmbr5
            // 
            this.nmbr5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr5.Location = new System.Drawing.Point(132, 218);
            this.nmbr5.Name = "nmbr5";
            this.nmbr5.Size = new System.Drawing.Size(100, 69);
            this.nmbr5.TabIndex = 5;
            this.nmbr5.Text = "5";
            this.nmbr5.UseVisualStyleBackColor = false;
            this.nmbr5.Click += new System.EventHandler(this.nmbr5_Click);
            // 
            // nmbr6
            // 
            this.nmbr6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr6.Location = new System.Drawing.Point(238, 219);
            this.nmbr6.Name = "nmbr6";
            this.nmbr6.Size = new System.Drawing.Size(100, 69);
            this.nmbr6.TabIndex = 6;
            this.nmbr6.Text = "6";
            this.nmbr6.UseVisualStyleBackColor = false;
            this.nmbr6.Click += new System.EventHandler(this.nmbr6_Click);
            // 
            // nmbr7
            // 
            this.nmbr7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr7.Location = new System.Drawing.Point(27, 292);
            this.nmbr7.Name = "nmbr7";
            this.nmbr7.Size = new System.Drawing.Size(99, 71);
            this.nmbr7.TabIndex = 7;
            this.nmbr7.Text = "7";
            this.nmbr7.UseVisualStyleBackColor = false;
            this.nmbr7.Click += new System.EventHandler(this.nmbr7_Click);
            // 
            // nmbr8
            // 
            this.nmbr8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr8.Location = new System.Drawing.Point(132, 292);
            this.nmbr8.Name = "nmbr8";
            this.nmbr8.Size = new System.Drawing.Size(100, 71);
            this.nmbr8.TabIndex = 8;
            this.nmbr8.Text = "8";
            this.nmbr8.UseVisualStyleBackColor = false;
            this.nmbr8.Click += new System.EventHandler(this.nmbr8_Click);
            // 
            // nmbr9
            // 
            this.nmbr9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr9.Location = new System.Drawing.Point(238, 294);
            this.nmbr9.Name = "nmbr9";
            this.nmbr9.Size = new System.Drawing.Size(100, 71);
            this.nmbr9.TabIndex = 9;
            this.nmbr9.Text = "9";
            this.nmbr9.UseVisualStyleBackColor = false;
            this.nmbr9.Click += new System.EventHandler(this.nmbr9_Click);
            // 
            // cross_op
            // 
            this.cross_op.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cross_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_op.Location = new System.Drawing.Point(344, 294);
            this.cross_op.Name = "cross_op";
            this.cross_op.Size = new System.Drawing.Size(73, 71);
            this.cross_op.TabIndex = 12;
            this.cross_op.Text = "x";
            this.cross_op.UseVisualStyleBackColor = false;
            this.cross_op.Click += new System.EventHandler(this.cross_op_Click);
            // 
            // minus_op
            // 
            this.minus_op.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minus_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_op.Location = new System.Drawing.Point(344, 220);
            this.minus_op.Name = "minus_op";
            this.minus_op.Size = new System.Drawing.Size(73, 68);
            this.minus_op.TabIndex = 11;
            this.minus_op.Text = "-";
            this.minus_op.UseVisualStyleBackColor = false;
            this.minus_op.Click += new System.EventHandler(this.minus_op_Click);
            // 
            // plus_op
            // 
            this.plus_op.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.plus_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_op.Location = new System.Drawing.Point(344, 143);
            this.plus_op.Name = "plus_op";
            this.plus_op.Size = new System.Drawing.Size(73, 71);
            this.plus_op.TabIndex = 10;
            this.plus_op.Text = "+";
            this.plus_op.UseVisualStyleBackColor = false;
            this.plus_op.Click += new System.EventHandler(this.plus_op_Click);
            // 
            // division_op
            // 
            this.division_op.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.division_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division_op.Location = new System.Drawing.Point(344, 369);
            this.division_op.Name = "division_op";
            this.division_op.Size = new System.Drawing.Size(73, 71);
            this.division_op.TabIndex = 13;
            this.division_op.Text = "/";
            this.division_op.UseVisualStyleBackColor = false;
            this.division_op.Click += new System.EventHandler(this.division_op_Click);
            // 
            // nmbr0
            // 
            this.nmbr0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmbr0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbr0.Location = new System.Drawing.Point(27, 369);
            this.nmbr0.Name = "nmbr0";
            this.nmbr0.Size = new System.Drawing.Size(99, 71);
            this.nmbr0.TabIndex = 14;
            this.nmbr0.Text = "0";
            this.nmbr0.UseVisualStyleBackColor = false;
            this.nmbr0.Click += new System.EventHandler(this.nmbr0_Click);
            // 
            // equal_op
            // 
            this.equal_op.BackColor = System.Drawing.Color.SlateGray;
            this.equal_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_op.Location = new System.Drawing.Point(27, 446);
            this.equal_op.Name = "equal_op";
            this.equal_op.Size = new System.Drawing.Size(390, 54);
            this.equal_op.TabIndex = 15;
            this.equal_op.Text = "=";
            this.equal_op.UseVisualStyleBackColor = false;
            this.equal_op.Click += new System.EventHandler(this.equal_op_Click);
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr.Location = new System.Drawing.Point(238, 97);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(179, 40);
            this.clr.TabIndex = 16;
            this.clr.Text = "CLR";
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Location = new System.Drawing.Point(238, 369);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(100, 71);
            this.sqrt.TabIndex = 17;
            this.sqrt.Text = "√ ";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.Location = new System.Drawing.Point(132, 97);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(100, 40);
            this.ce.TabIndex = 18;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.Gray;
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comma.Location = new System.Drawing.Point(132, 369);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(100, 71);
            this.comma.TabIndex = 19;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 526);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.equal_op);
            this.Controls.Add(this.nmbr0);
            this.Controls.Add(this.division_op);
            this.Controls.Add(this.cross_op);
            this.Controls.Add(this.minus_op);
            this.Controls.Add(this.plus_op);
            this.Controls.Add(this.nmbr9);
            this.Controls.Add(this.nmbr8);
            this.Controls.Add(this.nmbr7);
            this.Controls.Add(this.nmbr6);
            this.Controls.Add(this.nmbr5);
            this.Controls.Add(this.nmbr4);
            this.Controls.Add(this.nmbr3);
            this.Controls.Add(this.nmbr2);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.nmbr1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sımple_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nmbr1;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button nmbr2;
        private System.Windows.Forms.Button nmbr3;
        private System.Windows.Forms.Button nmbr4;
        private System.Windows.Forms.Button nmbr5;
        private System.Windows.Forms.Button nmbr6;
        private System.Windows.Forms.Button nmbr7;
        private System.Windows.Forms.Button nmbr8;
        private System.Windows.Forms.Button nmbr9;
        private System.Windows.Forms.Button cross_op;
        private System.Windows.Forms.Button minus_op;
        private System.Windows.Forms.Button plus_op;
        private System.Windows.Forms.Button division_op;
        private System.Windows.Forms.Button nmbr0;
        private System.Windows.Forms.Button equal_op;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button comma;
    }
}


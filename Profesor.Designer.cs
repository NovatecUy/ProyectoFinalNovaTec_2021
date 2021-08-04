namespace PNtec
{
    partial class Profesor
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
            this.btningreso = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btningreso
            // 
            this.btningreso.Location = new System.Drawing.Point(328, 401);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(213, 70);
            this.btningreso.TabIndex = 0;
            this.btningreso.Text = "Ingresar";
            this.btningreso.UseVisualStyleBackColor = true;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(359, 133);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(138, 22);
            this.txt1.TabIndex = 1;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(359, 217);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(138, 22);
            this.txt4.TabIndex = 2;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(359, 189);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(138, 22);
            this.txt3.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(358, 161);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(138, 22);
            this.txt2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "CI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Justificadas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Injustificadas";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(359, 341);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 22);
            this.dtpfecha.TabIndex = 14;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(357, 276);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(138, 22);
            this.txt6.TabIndex = 18;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(358, 304);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(138, 22);
            this.txt7.TabIndex = 17;
            this.txt7.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(358, 248);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(138, 22);
            this.txt5.TabIndex = 15;
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 516);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btningreso);
            this.Name = "Profesor";
            this.Text = "Profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningreso;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt5;
    }
}
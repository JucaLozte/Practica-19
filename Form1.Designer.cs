namespace Practica_19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(308, 25);
            label1.TabIndex = 0;
            label1.Text = "Inserte 4 calificaciones para saber si";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 100);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 1;
            label2.Text = "Calificación 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 150);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 2;
            label3.Text = "Calificación 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 200);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 3;
            label4.Text = "Calificación 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 250);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 4;
            label5.Text = "Calificación 4:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(180, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(180, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(180, 197);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(180, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 49);
            label6.Name = "label6";
            label6.Size = new Size(249, 25);
            label6.TabIndex = 9;
            label6.Text = "el alumno aprobó o reprobó";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(61, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Evaluar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(221, 319);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(135, 376);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(374, 439);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Evaluación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
namespace WinForms_login_mod
{
    partial class Registro
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
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            groupBox5 = new GroupBox();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(71, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(269, 68);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Usuario";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(13, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(239, 27);
            textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 175);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 27);
            textBox5.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(70, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 68);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Correo electronico ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 27);
            textBox2.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(239, 331);
            button1.Name = "button1";
            button1.Size = new Size(110, 34);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.BlueViolet;
            button2.ForeColor = Color.White;
            button2.Location = new Point(49, 331);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 4;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(70, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 68);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contraseña";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(13, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 27);
            textBox3.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(58, 104);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(416, 417);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Registro";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(535, 628);
            Controls.Add(groupBox5);
            Name = "Registro";
            Text = "Reg";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox5;
    }
}
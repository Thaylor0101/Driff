namespace WinForms_login_mod
{
    partial class AddTaskForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 581);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(333, 386);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.BlueViolet;
            button2.ForeColor = Color.White;
            button2.Location = new Point(74, 386);
            button2.Name = "button2";
            button2.Size = new Size(92, 34);
            button2.TabIndex = 11;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(52, 137);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(382, 68);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Titulo";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(13, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(341, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 27);
            textBox3.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textBox4);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(52, 238);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(382, 68);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Descripción";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(13, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 27);
            textBox4.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 46);
            label2.Name = "label2";
            label2.Size = new Size(195, 41);
            label2.TabIndex = 0;
            label2.Text = "Msg_addTask";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(555, 638);
            Controls.Add(groupBox1);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
    }
}
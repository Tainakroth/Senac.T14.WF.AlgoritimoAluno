namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Verdana", 13F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 250);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Conta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 51);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 0;
            label1.Text = "Numero da conta";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FloralWhite;
            textBox1.Location = new Point(15, 90);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 42);
            textBox1.TabIndex = 1;
            textBox1.Text = "1484455";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 51);
            label2.Name = "label2";
            label2.Size = new Size(219, 32);
            label2.TabIndex = 2;
            label2.Text = "Titular da conta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 135);
            label3.Name = "label3";
            label3.Size = new Size(209, 32);
            label3.TabIndex = 3;
            label3.Text = "Saldo da conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 135);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 4;
            label4.Text = "Tipo da conta";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(393, 39);
            textBox2.TabIndex = 5;
            textBox2.Text = "taina kroth";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 39);
            textBox3.TabIndex = 6;
            textBox3.Text = "8.999";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(393, 39);
            textBox4.TabIndex = 7;
            textBox4.Text = "Corrente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}

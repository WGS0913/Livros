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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            painel2 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            txtLogin = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            txtSenha = new TextBox();
            btnSenha = new PictureBox();
            label7 = new Label();
            btnFechar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSenha).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(168, 483);
            label5.Name = "label5";
            label5.Size = new Size(110, 13);
            label5.TabIndex = 12;
            label5.Text = "Wesley Gomes Silva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(168, 461);
            label4.Name = "label4";
            label4.Size = new Size(105, 13);
            label4.TabIndex = 11;
            label4.Text = "Desenvolvido por :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(200, 376);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 10;
            label3.Text = "de livros";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.online_learning;
            pictureBox2.Location = new Point(73, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 197);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(87, 346);
            label2.Name = "label2";
            label2.Size = new Size(203, 30);
            label2.TabIndex = 8;
            label2.Text = "Sistema Gerenciador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(154, 316);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 7;
            label1.Text = "Bem vindo ao";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // painel2
            // 
            painel2.Controls.Add(button1);
            painel2.Controls.Add(panel4);
            painel2.Controls.Add(panel3);
            painel2.Controls.Add(label7);
            painel2.Controls.Add(btnFechar);
            painel2.Dock = DockStyle.Fill;
            painel2.ForeColor = SystemColors.ButtonHighlight;
            painel2.Location = new Point(300, 0);
            painel2.Name = "painel2";
            painel2.Size = new Size(450, 530);
            painel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(6, 378);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 11;
            button1.Text = "Acessar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtLogin);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(0, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 45);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(44, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 1);
            panel5.TabIndex = 12;
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(44, 7);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(394, 22);
            txtLogin.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(txtSenha);
            panel3.Controls.Add(btnSenha);
            panel3.Location = new Point(0, 313);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 45);
            panel3.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(44, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 1);
            panel2.TabIndex = 12;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(44, 7);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(397, 22);
            txtSenha.TabIndex = 11;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnSenha
            // 
            btnSenha.Image = Properties.Resources.padlock_unlock;
            btnSenha.Location = new Point(6, 9);
            btnSenha.Name = "btnSenha";
            btnSenha.Size = new Size(32, 32);
            btnSenha.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSenha.TabIndex = 10;
            btnSenha.TabStop = false;
            btnSenha.MouseDown += btnSenha_MouseDown;
            btnSenha.MouseUp += btnSenha_MouseUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(6, 213);
            label7.Name = "label7";
            label7.Size = new Size(156, 30);
            label7.TabIndex = 9;
            label7.Text = "Faça seu Login";
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = SystemColors.HotTrack;
            btnFechar.Location = new Point(410, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 40);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(painel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painel2.ResumeLayout(false);
            painel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel painel2;
        private Button btnFechar;
        private Label label7;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private PictureBox btnSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button button1;
        private Panel panel2;
        private Panel panel5;
    }
}
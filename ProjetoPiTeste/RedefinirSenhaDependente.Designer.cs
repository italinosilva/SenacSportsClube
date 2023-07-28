namespace ProjetoPiTeste
{
    partial class RedefinirSenhaDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedefinirSenhaDependente));
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientActiveCaption;
            textBox4.Location = new Point(54, 333);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 19;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 313);
            label5.Name = "label5";
            label5.Size = new Size(117, 17);
            label5.TabIndex = 18;
            label5.Text = "Confirmar Senha";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(55, 362);
            button1.Name = "button1";
            button1.Size = new Size(153, 50);
            button1.TabIndex = 17;
            button1.Text = "Gerar nova \r\nsenha";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.GradientActiveCaption;
            textBox3.Location = new Point(54, 287);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 16;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(54, 267);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 15;
            label4.Text = "Nova senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 23);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 174);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 13;
            label3.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 121);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 11;
            label2.Text = "CPF:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(216, 24);
            label1.Name = "label1";
            label1.Size = new Size(376, 24);
            label1.TabIndex = 21;
            label1.Text = "Redefinição de senha para o  Dependente";
            // 
            // RedefinirSenhaDependente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "RedefinirSenhaDependente";
            Text = "RedefinirSenhaDependente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}
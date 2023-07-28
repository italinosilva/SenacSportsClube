namespace ProjetoPiTeste
{
    partial class Evento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evento));
            label1 = new Label();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tempus Sans ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 35);
            label1.TabIndex = 0;
            label1.Text = "Eventos";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Location = new Point(224, 405);
            button3.Name = "button3";
            button3.Size = new Size(157, 38);
            button3.TabIndex = 13;
            button3.Text = "Desfazer cadastro";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleTurquoise;
            button6.Location = new Point(437, 402);
            button6.Name = "button6";
            button6.Size = new Size(117, 40);
            button6.TabIndex = 16;
            button6.Text = "Inscreva - se ";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Tomato;
            button7.Location = new Point(619, 402);
            button7.Name = "button7";
            button7.Size = new Size(155, 40);
            button7.TabIndex = 17;
            button7.Text = "Desfazer cadastro ";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(44, 404);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 18;
            button1.Text = "Inscreva - se ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(437, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 266);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(44, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 266);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 62);
            label2.Name = "label2";
            label2.Size = new Size(255, 24);
            label2.TabIndex = 21;
            label2.Text = "Campeonato Infantil de Futsal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Viner Hand ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(495, 62);
            label3.Name = "label3";
            label3.Size = new Size(232, 24);
            label3.TabIndex = 22;
            label3.Text = "Campeonato Juvenil de Vôlei";
            // 
            // Evento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(829, 527);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "Evento";
            Text = "Evento";
            Load += Evento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}
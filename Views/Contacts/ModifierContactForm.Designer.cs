namespace Mon_Secret.Views.Contacts
{
    partial class ModifierContactForm
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnModifier = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textModifierNom = new TextBox();
            textModifierPrenom = new TextBox();
            textModifierTelephone = new TextBox();
            textModifierEmail = new TextBox();
            textModifierAdresse = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pencil2;
            pictureBox1.Location = new Point(22, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(43, 320);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 1;
            button1.Text = "Annuler";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(255, 128, 0);
            btnModifier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(269, 320);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 30);
            btnModifier.TabIndex = 2;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Modifier Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 59);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(192, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(192, 149);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Téléphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(192, 201);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(192, 252);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 8;
            label6.Text = "Adresse";
            // 
            // textModifierNom
            // 
            textModifierNom.Location = new Point(269, 59);
            textModifierNom.Name = "textModifierNom";
            textModifierNom.Size = new Size(100, 23);
            textModifierNom.TabIndex = 9;
            // 
            // textModifierPrenom
            // 
            textModifierPrenom.Location = new Point(269, 98);
            textModifierPrenom.Name = "textModifierPrenom";
            textModifierPrenom.Size = new Size(100, 23);
            textModifierPrenom.TabIndex = 10;
            // 
            // textModifierTelephone
            // 
            textModifierTelephone.Location = new Point(269, 146);
            textModifierTelephone.Name = "textModifierTelephone";
            textModifierTelephone.Size = new Size(100, 23);
            textModifierTelephone.TabIndex = 11;
            // 
            // textModifierEmail
            // 
            textModifierEmail.Location = new Point(269, 193);
            textModifierEmail.Name = "textModifierEmail";
            textModifierEmail.Size = new Size(100, 23);
            textModifierEmail.TabIndex = 12;
            // 
            // textModifierAdresse
            // 
            textModifierAdresse.Location = new Point(269, 249);
            textModifierAdresse.Name = "textModifierAdresse";
            textModifierAdresse.Size = new Size(100, 23);
            textModifierAdresse.TabIndex = 13;
            // 
            // ModifierContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 374);
            Controls.Add(textModifierAdresse);
            Controls.Add(textModifierEmail);
            Controls.Add(textModifierTelephone);
            Controls.Add(textModifierPrenom);
            Controls.Add(textModifierNom);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnModifier);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifierContactForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ModifierContactForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button btnModifier;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textModifierNom;
        private TextBox textModifierPrenom;
        private TextBox textModifierTelephone;
        private TextBox textModifierEmail;
        private TextBox textModifierAdresse;
    }
}
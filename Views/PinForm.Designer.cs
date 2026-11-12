namespace Mon_Secret.Views
{
    partial class PinForm
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
            label1 = new Label();
            label2 = new Label();
            txtPin = new TextBox();
            btnAnnuler = new Button();
            btnValide = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_silver_blue_shield_with_white_padlock_vector_png_image_92678233;
            pictureBox1.Location = new Point(151, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 96);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 1;
            label1.Text = "Accès aux secrets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 130);
            label2.Name = "label2";
            label2.Size = new Size(217, 15);
            label2.TabIndex = 2;
            label2.Text = "Saisissez votre code PIN pour continuer";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(134, 177);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(100, 23);
            txtPin.TabIndex = 3;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = SystemColors.ActiveBorder;
            btnAnnuler.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnuler.Location = new Point(60, 234);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 29);
            btnAnnuler.TabIndex = 4;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // btnValide
            // 
            btnValide.BackColor = Color.DodgerBlue;
            btnValide.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValide.ForeColor = Color.White;
            btnValide.Location = new Point(236, 232);
            btnValide.Name = "btnValide";
            btnValide.Size = new Size(75, 29);
            btnValide.TabIndex = 4;
            btnValide.Text = "Valider";
            btnValide.UseVisualStyleBackColor = false;
            btnValide.Click += btnValide_Click;
            // 
            // PinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 271);
            Controls.Add(btnValide);
            Controls.Add(btnAnnuler);
            Controls.Add(txtPin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PinForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PinForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtPin;
        private Button btnAnnuler;
        private Button btnValide;
    }
}
namespace HomeAfairs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.citizenshipCombo = new System.Windows.Forms.ComboBox();
            this.IdValidationText = new System.Windows.Forms.Label();
            this.resultsText = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(350, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-39, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(484, 65);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(284, 20);
            this.nameText.TabIndex = 3;
            this.nameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your ID: ";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(484, 100);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(284, 20);
            this.idText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose your Citizenship:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Green;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(524, 174);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(101, 35);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // citizenshipCombo
            // 
            this.citizenshipCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citizenshipCombo.FormattingEnabled = true;
            this.citizenshipCombo.Items.AddRange(new object[] {
            "Citizen",
            "Permanent Resident",
            "Visitor"});
            this.citizenshipCombo.Location = new System.Drawing.Point(551, 130);
            this.citizenshipCombo.Name = "citizenshipCombo";
            this.citizenshipCombo.Size = new System.Drawing.Size(217, 21);
            this.citizenshipCombo.TabIndex = 8;
            // 
            // IdValidationText
            // 
            this.IdValidationText.AutoSize = true;
            this.IdValidationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdValidationText.Location = new System.Drawing.Point(481, 223);
            this.IdValidationText.Name = "IdValidationText";
            this.IdValidationText.Size = new System.Drawing.Size(184, 13);
            this.IdValidationText.TabIndex = 9;
            this.IdValidationText.Text = "Valid ID: Citizen is 35 years old";
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(428, 250);
            this.resultsText.Multiline = true;
            this.resultsText.Name = "resultsText";
            this.resultsText.Size = new System.Drawing.Size(340, 121);
            this.resultsText.TabIndex = 10;
            this.resultsText.TextChanged += new System.EventHandler(this.resultsText_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(495, 381);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 35);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate profile";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.IdValidationText);
            this.Controls.Add(this.citizenshipCombo);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.ComboBox citizenshipCombo;
        private System.Windows.Forms.Label IdValidationText;
        private System.Windows.Forms.TextBox resultsText;
        private System.Windows.Forms.Button btnGenerate;
    }
}


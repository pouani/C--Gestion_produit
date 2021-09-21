namespace Gestion_Produits
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ErrorName = new System.Windows.Forms.Label();
            this.ErrorEmail = new System.Windows.Forms.Label();
            this.ErrorAge = new System.Windows.Forms.Label();
            this.ErrorPsw = new System.Windows.Forms.Label();
            this.ErrorPswC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "S\'ENREGISTRER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mot de Passe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Confirmer Mot de Passe";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(216, 225);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(300, 22);
            this.txtAge.TabIndex = 2;
            this.txtAge.TextChanged += new System.EventHandler(this.TxtAge_TextChanged);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAge_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.Location = new System.Drawing.Point(216, 341);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(300, 22);
            this.txtConfPassword.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(54, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(236, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(306, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(210, 39);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Annuler";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(424, 463);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Se connecter";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // ErrorName
            // 
            this.ErrorName.AutoSize = true;
            this.ErrorName.ForeColor = System.Drawing.Color.Red;
            this.ErrorName.Location = new System.Drawing.Point(213, 134);
            this.ErrorName.Name = "ErrorName";
            this.ErrorName.Size = new System.Drawing.Size(0, 17);
            this.ErrorName.TabIndex = 5;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.AutoSize = true;
            this.ErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.ErrorEmail.Location = new System.Drawing.Point(213, 190);
            this.ErrorEmail.Name = "ErrorEmail";
            this.ErrorEmail.Size = new System.Drawing.Size(0, 17);
            this.ErrorEmail.TabIndex = 5;
            // 
            // ErrorAge
            // 
            this.ErrorAge.AutoSize = true;
            this.ErrorAge.ForeColor = System.Drawing.Color.Red;
            this.ErrorAge.Location = new System.Drawing.Point(213, 250);
            this.ErrorAge.Name = "ErrorAge";
            this.ErrorAge.Size = new System.Drawing.Size(0, 17);
            this.ErrorAge.TabIndex = 5;
            // 
            // ErrorPsw
            // 
            this.ErrorPsw.AutoSize = true;
            this.ErrorPsw.ForeColor = System.Drawing.Color.Red;
            this.ErrorPsw.Location = new System.Drawing.Point(213, 310);
            this.ErrorPsw.Name = "ErrorPsw";
            this.ErrorPsw.Size = new System.Drawing.Size(0, 17);
            this.ErrorPsw.TabIndex = 5;
            // 
            // ErrorPswC
            // 
            this.ErrorPswC.AutoSize = true;
            this.ErrorPswC.ForeColor = System.Drawing.Color.Red;
            this.ErrorPswC.Location = new System.Drawing.Point(216, 366);
            this.ErrorPswC.Name = "ErrorPswC";
            this.ErrorPswC.Size = new System.Drawing.Size(0, 17);
            this.ErrorPswC.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 489);
            this.Controls.Add(this.ErrorPswC);
            this.Controls.Add(this.ErrorPsw);
            this.Controls.Add(this.ErrorAge);
            this.Controls.Add(this.ErrorEmail);
            this.Controls.Add(this.ErrorName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label ErrorName;
        private System.Windows.Forms.Label ErrorEmail;
        private System.Windows.Forms.Label ErrorAge;
        private System.Windows.Forms.Label ErrorPsw;
        private System.Windows.Forms.Label ErrorPswC;
    }
}


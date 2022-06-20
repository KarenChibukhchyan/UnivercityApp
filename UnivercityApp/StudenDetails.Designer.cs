
namespace UnivercityApp
{
    partial class StudenDetails
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
            this.firstNameTextLbl = new System.Windows.Forms.Label();
            this.lastNameTextLbl = new System.Windows.Forms.Label();
            this.ageTextLbl = new System.Windows.Forms.Label();
            this.idTextLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // firstNameTextLbl
            //
            this.firstNameTextLbl.AutoSize = true;
            this.firstNameTextLbl.Location = new System.Drawing.Point(79, 40);
            this.firstNameTextLbl.Name = "firstNameTextLbl";
            this.firstNameTextLbl.Size = new System.Drawing.Size(41, 13);
            this.firstNameTextLbl.TabIndex = 0;
            this.firstNameTextLbl.Text = "Name: ";
            //
            // lastNameTextLbl
            //
            this.lastNameTextLbl.AutoSize = true;
            this.lastNameTextLbl.Location = new System.Drawing.Point(79, 71);
            this.lastNameTextLbl.Name = "lastNameTextLbl";
            this.lastNameTextLbl.Size = new System.Drawing.Size(67, 13);
            this.lastNameTextLbl.TabIndex = 1;
            this.lastNameTextLbl.Text = "SURNAME: ";
            //
            // ageTextLbl
            //
            this.ageTextLbl.AutoSize = true;
            this.ageTextLbl.Location = new System.Drawing.Point(79, 105);
            this.ageTextLbl.Name = "ageTextLbl";
            this.ageTextLbl.Size = new System.Drawing.Size(35, 13);
            this.ageTextLbl.TabIndex = 2;
            this.ageTextLbl.Text = "AGE: ";
            //
            // idTextLbl
            //
            this.idTextLbl.AutoSize = true;
            this.idTextLbl.Location = new System.Drawing.Point(79, 142);
            this.idTextLbl.Name = "idTextLbl";
            this.idTextLbl.Size = new System.Drawing.Size(24, 13);
            this.idTextLbl.TabIndex = 3;
            this.idTextLbl.Text = "ID: ";
            //
            // firstNameLbl
            //
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(165, 40);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(0, 13);
            this.firstNameLbl.TabIndex = 4;
            //
            // lastNameLbl
            //
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(165, 71);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(0, 13);
            this.lastNameLbl.TabIndex = 5;
            //
            // ageLbl
            //
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(165, 105);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(0, 13);
            this.ageLbl.TabIndex = 6;
            //
            // idLbl
            //
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(165, 142);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(0, 13);
            this.idLbl.TabIndex = 7;
            //
            // StudenDetails
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.idTextLbl);
            this.Controls.Add(this.ageTextLbl);
            this.Controls.Add(this.lastNameTextLbl);
            this.Controls.Add(this.firstNameTextLbl);
            this.Name = "StudenDetails";
            this.Text = "StudenDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudenDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label ageTextLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label firstNameTextLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label idTextLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label lastNameTextLbl;

        #endregion
    }
}
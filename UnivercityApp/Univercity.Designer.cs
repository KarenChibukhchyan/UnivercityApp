
namespace UnivercityApp
{
    partial class Univercity
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
            this.studentGv = new System.Windows.Forms.DataGridView();
            this.studentsLbl = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.addStudentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.studentGv)).BeginInit();
            this.SuspendLayout();
            //
            // studentGv
            //
            this.studentGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGv.Location = new System.Drawing.Point(34, 256);
            this.studentGv.Name = "studentGv";
            this.studentGv.Size = new System.Drawing.Size(439, 150);
            this.studentGv.TabIndex = 0;
            this.studentGv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.studentGv_CellMouseClick);
            //
            // studentsLbl
            //
            this.studentsLbl.AutoSize = true;
            this.studentsLbl.Location = new System.Drawing.Point(31, 240);
            this.studentsLbl.Name = "studentsLbl";
            this.studentsLbl.Size = new System.Drawing.Size(66, 13);
            this.studentsLbl.TabIndex = 1;
            this.studentsLbl.Text = "STUDENTS";
            //
            // firstNameBox
            //
            this.firstNameBox.Location = new System.Drawing.Point(113, 46);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 3;
            //
            // lastNameBox
            //
            this.lastNameBox.Location = new System.Drawing.Point(113, 85);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 4;
            //
            // ageBox
            //
            this.ageBox.Location = new System.Drawing.Point(113, 124);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 5;
            //
            // firstNameLbl
            //
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(31, 46);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(38, 13);
            this.firstNameLbl.TabIndex = 6;
            this.firstNameLbl.Text = "NAME";
            //
            // lastNameLbl
            //
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(31, 85);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(72, 13);
            this.lastNameLbl.TabIndex = 7;
            this.lastNameLbl.Text = "LASTANAME";
            //
            // ageLbl
            //
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(31, 124);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(29, 13);
            this.ageLbl.TabIndex = 8;
            this.ageLbl.Text = "AGE";
            //
            // addStudentBtn
            //
            this.addStudentBtn.Location = new System.Drawing.Point(275, 46);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.addStudentBtn.TabIndex = 9;
            this.addStudentBtn.Text = "ADD";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            //
            // Univercity
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.studentsLbl);
            this.Controls.Add(this.studentGv);
            this.Name = "Univercity";
            this.Text = "Univercity";
            ((System.ComponentModel.ISupportInitialize) (this.studentGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.DataGridView studentGv;
        private System.Windows.Forms.Label studentsLbl;

        #endregion
    }
}


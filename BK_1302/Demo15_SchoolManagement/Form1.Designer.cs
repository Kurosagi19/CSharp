﻿namespace Demo15_SchoolManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSchoolName = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbbChoose = new System.Windows.Forms.ComboBox();
            this.dtgSchool = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbSchoolName
            // 
            this.lbSchoolName.AutoSize = true;
            this.lbSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSchoolName.Location = new System.Drawing.Point(15, 310);
            this.lbSchoolName.Name = "lbSchoolName";
            this.lbSchoolName.Size = new System.Drawing.Size(125, 24);
            this.lbSchoolName.TabIndex = 1;
            this.lbSchoolName.Text = "School Name";
            this.lbSchoolName.Click += new System.EventHandler(this.lbSchoolName_Click);
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolName.Location = new System.Drawing.Point(146, 310);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(150, 26);
            this.txtSchoolName.TabIndex = 2;
            this.txtSchoolName.TextChanged += new System.EventHandler(this.txtSchoolName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(100, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(269, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(357, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherName.Location = new System.Drawing.Point(15, 342);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(137, 24);
            this.lbTeacherName.TabIndex = 7;
            this.lbTeacherName.Text = "Teacher Name";
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(146, 342);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(150, 26);
            this.txtTeacherName.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(181, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbbChoose
            // 
            this.cbbChoose.FormattingEnabled = true;
            this.cbbChoose.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbbChoose.Location = new System.Drawing.Point(340, 342);
            this.cbbChoose.Name = "cbbChoose";
            this.cbbChoose.Size = new System.Drawing.Size(132, 21);
            this.cbbChoose.TabIndex = 10;
            this.cbbChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtgSchool
            // 
            this.dtgSchool.AllowUserToAddRows = false;
            this.dtgSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSchool.Location = new System.Drawing.Point(56, 49);
            this.dtgSchool.Name = "dtgSchool";
            this.dtgSchool.Size = new System.Drawing.Size(662, 178);
            this.dtgSchool.TabIndex = 11;
            this.dtgSchool.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSchool_CellClick);
            this.dtgSchool.SelectionChanged += new System.EventHandler(this.dtgSchool_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgSchool);
            this.Controls.Add(this.cbbChoose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.lbTeacherName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.lbSchoolName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSchoolName;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTeacherName;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbbChoose;
        private System.Windows.Forms.DataGridView dtgSchool;
    }
}


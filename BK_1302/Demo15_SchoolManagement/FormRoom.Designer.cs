namespace Demo15_SchoolManagement
{
    partial class FormRoom
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.lbFloor = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.dtgRoom = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.lbRoomName = new System.Windows.Forms.Label();
            this.lbBuildingID = new System.Windows.Forms.Label();
            this.txtBuildingID = new System.Windows.Forms.TextBox();
            this.btnBuilding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(468, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 35);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(234, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(122, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFloor
            // 
            this.txtFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloor.Location = new System.Drawing.Point(551, 242);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(134, 26);
            this.txtFloor.TabIndex = 33;
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloor.Location = new System.Drawing.Point(411, 244);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(54, 24);
            this.lbFloor.TabIndex = 32;
            this.lbFloor.Text = "Floor";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(416, 311);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(134, 26);
            this.txtRoomID.TabIndex = 31;
            // 
            // lbRoomID
            // 
            this.lbRoomID.AutoSize = true;
            this.lbRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomID.Location = new System.Drawing.Point(276, 315);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(83, 24);
            this.lbRoomID.TabIndex = 30;
            this.lbRoomID.Text = "Room ID";
            // 
            // dtgRoom
            // 
            this.dtgRoom.AllowUserToAddRows = false;
            this.dtgRoom.BackgroundColor = System.Drawing.Color.White;
            this.dtgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoom.Location = new System.Drawing.Point(60, 29);
            this.dtgRoom.Name = "dtgRoom";
            this.dtgRoom.Size = new System.Drawing.Size(662, 206);
            this.dtgRoom.TabIndex = 29;
            this.dtgRoom.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRoom_CellMouseClick);
            this.dtgRoom.SelectionChanged += new System.EventHandler(this.dtgRoom_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(355, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(246, 276);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(137, 26);
            this.txtRoomNumber.TabIndex = 27;
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNumber.Location = new System.Drawing.Point(102, 276);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(135, 24);
            this.lbRoomNumber.TabIndex = 26;
            this.lbRoomNumber.Text = "Room Number";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(703, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 35);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(582, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(246, 244);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(137, 26);
            this.txtRoomName.TabIndex = 22;
            // 
            // lbRoomName
            // 
            this.lbRoomName.AutoSize = true;
            this.lbRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomName.Location = new System.Drawing.Point(102, 244);
            this.lbRoomName.Name = "lbRoomName";
            this.lbRoomName.Size = new System.Drawing.Size(117, 24);
            this.lbRoomName.TabIndex = 21;
            this.lbRoomName.Text = "Room Name";
            // 
            // lbBuildingID
            // 
            this.lbBuildingID.AutoSize = true;
            this.lbBuildingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuildingID.Location = new System.Drawing.Point(411, 278);
            this.lbBuildingID.Name = "lbBuildingID";
            this.lbBuildingID.Size = new System.Drawing.Size(100, 24);
            this.lbBuildingID.TabIndex = 38;
            this.lbBuildingID.Text = "Building ID";
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingID.Location = new System.Drawing.Point(551, 279);
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.Size = new System.Drawing.Size(134, 26);
            this.txtBuildingID.TabIndex = 39;
            // 
            // btnBuilding
            // 
            this.btnBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuilding.Location = new System.Drawing.Point(294, 362);
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.Size = new System.Drawing.Size(206, 35);
            this.btnBuilding.TabIndex = 40;
            this.btnBuilding.Text = "Building Management";
            this.btnBuilding.UseVisualStyleBackColor = true;
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuilding);
            this.Controls.Add(this.txtBuildingID);
            this.Controls.Add(this.lbBuildingID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.lbFloor);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.lbRoomID);
            this.Controls.Add(this.dtgRoom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lbRoomNumber);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lbRoomName);
            this.Name = "FormRoom";
            this.Text = "BK Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.DataGridView dtgRoom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbBuildingID;
        private System.Windows.Forms.TextBox txtBuildingID;
        private System.Windows.Forms.Button btnBuilding;
    }
}
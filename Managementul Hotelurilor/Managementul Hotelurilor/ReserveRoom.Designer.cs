namespace Managementul_Hotelurilor
{
    partial class ReserveRoom
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
            this.tb_RoomType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_FamilyOriented = new System.Windows.Forms.TextBox();
            this.tb_RoomID = new System.Windows.Forms.TextBox();
            this.tb_Hotel = new System.Windows.Forms.TextBox();
            this.dateComming_picker = new System.Windows.Forms.DateTimePicker();
            this.dateLeaving_picker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_CommitReservation = new System.Windows.Forms.Button();
            this.Error_LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_RoomType
            // 
            this.tb_RoomType.Location = new System.Drawing.Point(29, 28);
            this.tb_RoomType.Name = "tb_RoomType";
            this.tb_RoomType.ReadOnly = true;
            this.tb_RoomType.Size = new System.Drawing.Size(114, 20);
            this.tb_RoomType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Family Oriented";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hotel";
            // 
            // tb_FamilyOriented
            // 
            this.tb_FamilyOriented.Location = new System.Drawing.Point(165, 28);
            this.tb_FamilyOriented.Name = "tb_FamilyOriented";
            this.tb_FamilyOriented.ReadOnly = true;
            this.tb_FamilyOriented.Size = new System.Drawing.Size(114, 20);
            this.tb_FamilyOriented.TabIndex = 6;
            // 
            // tb_RoomID
            // 
            this.tb_RoomID.Location = new System.Drawing.Point(29, 91);
            this.tb_RoomID.Name = "tb_RoomID";
            this.tb_RoomID.ReadOnly = true;
            this.tb_RoomID.Size = new System.Drawing.Size(114, 20);
            this.tb_RoomID.TabIndex = 7;
            // 
            // tb_Hotel
            // 
            this.tb_Hotel.Location = new System.Drawing.Point(165, 91);
            this.tb_Hotel.Name = "tb_Hotel";
            this.tb_Hotel.ReadOnly = true;
            this.tb_Hotel.Size = new System.Drawing.Size(114, 20);
            this.tb_Hotel.TabIndex = 8;
            // 
            // dateComming_picker
            // 
            this.dateComming_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateComming_picker.Location = new System.Drawing.Point(29, 226);
            this.dateComming_picker.Name = "dateComming_picker";
            this.dateComming_picker.Size = new System.Drawing.Size(114, 20);
            this.dateComming_picker.TabIndex = 9;
            // 
            // dateLeaving_picker
            // 
            this.dateLeaving_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLeaving_picker.Location = new System.Drawing.Point(165, 226);
            this.dateLeaving_picker.Name = "dateLeaving_picker";
            this.dateLeaving_picker.Size = new System.Drawing.Size(114, 20);
            this.dateLeaving_picker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reservation Start day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reservation End Date";
            // 
            // b_CommitReservation
            // 
            this.b_CommitReservation.Location = new System.Drawing.Point(104, 283);
            this.b_CommitReservation.Name = "b_CommitReservation";
            this.b_CommitReservation.Size = new System.Drawing.Size(107, 23);
            this.b_CommitReservation.TabIndex = 13;
            this.b_CommitReservation.Text = "Make Reservation";
            this.b_CommitReservation.UseVisualStyleBackColor = true;
            this.b_CommitReservation.Click += new System.EventHandler(this.B_CommitReservation_Click);
            // 
            // Error_LABEL
            // 
            this.Error_LABEL.AutoSize = true;
            this.Error_LABEL.ForeColor = System.Drawing.Color.Red;
            this.Error_LABEL.Location = new System.Drawing.Point(26, 147);
            this.Error_LABEL.Name = "Error_LABEL";
            this.Error_LABEL.Size = new System.Drawing.Size(35, 13);
            this.Error_LABEL.TabIndex = 14;
            this.Error_LABEL.Text = "label7";
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 342);
            this.Controls.Add(this.Error_LABEL);
            this.Controls.Add(this.b_CommitReservation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateLeaving_picker);
            this.Controls.Add(this.dateComming_picker);
            this.Controls.Add(this.tb_Hotel);
            this.Controls.Add(this.tb_RoomID);
            this.Controls.Add(this.tb_FamilyOriented);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_RoomType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReserveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Room";
            this.Load += new System.EventHandler(this.ReserveRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_RoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_FamilyOriented;
        private System.Windows.Forms.TextBox tb_RoomID;
        private System.Windows.Forms.TextBox tb_Hotel;
        private System.Windows.Forms.DateTimePicker dateComming_picker;
        private System.Windows.Forms.DateTimePicker dateLeaving_picker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_CommitReservation;
        private System.Windows.Forms.Label Error_LABEL;
    }
}
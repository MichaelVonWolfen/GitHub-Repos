namespace Managementul_Hotelurilor
{
    partial class Form_Reservations
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
            this.GV_OcupiedRooms = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_OcupiedRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // GV_OcupiedRooms
            // 
            this.GV_OcupiedRooms.AllowUserToAddRows = false;
            this.GV_OcupiedRooms.AllowUserToDeleteRows = false;
            this.GV_OcupiedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_OcupiedRooms.Location = new System.Drawing.Point(12, 12);
            this.GV_OcupiedRooms.Name = "GV_OcupiedRooms";
            this.GV_OcupiedRooms.ReadOnly = true;
            this.GV_OcupiedRooms.Size = new System.Drawing.Size(577, 735);
            this.GV_OcupiedRooms.TabIndex = 0;
            this.GV_OcupiedRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Form_Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 759);
            this.Controls.Add(this.GV_OcupiedRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms already ocupied";
            this.Load += new System.EventHandler(this.Form_Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_OcupiedRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GV_OcupiedRooms;
    }
}
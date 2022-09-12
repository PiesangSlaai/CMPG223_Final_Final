
namespace CMPG223_Shop_System
{
    partial class Maintain_Orders
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
            this.myGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gp_Delete = new System.Windows.Forms.GroupBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.gp_Filter = new System.Windows.Forms.GroupBox();
            this.lbl_DateOfTransaction = new System.Windows.Forms.Label();
            this.txt_Location = new System.Windows.Forms.TextBox();
            this.txt_ConsoleName = new System.Windows.Forms.TextBox();
            this.txt_OrderName = new System.Windows.Forms.TextBox();
            this.txt_GameName = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_GameName = new System.Windows.Forms.Label();
            this.lbl_ConsoleName = new System.Windows.Forms.Label();
            this.lbl_OrderName = new System.Windows.Forms.Label();
            this.dtp_DateOfTrans = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).BeginInit();
            this.gp_Delete.SuspendLayout();
            this.gp_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // myGridView
            // 
            this.myGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGridView.Location = new System.Drawing.Point(28, 156);
            this.myGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myGridView.Name = "myGridView";
            this.myGridView.RowHeadersWidth = 62;
            this.myGridView.Size = new System.Drawing.Size(867, 675);
            this.myGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 23.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maintain Developers";
            // 
            // gp_Delete
            // 
            this.gp_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gp_Delete.Controls.Add(this.txtOrderID);
            this.gp_Delete.Controls.Add(this.btnDelete);
            this.gp_Delete.Controls.Add(this.lbl_Order);
            this.gp_Delete.Controls.Add(this.lbl_Search);
            this.gp_Delete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.gp_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gp_Delete.Location = new System.Drawing.Point(936, 156);
            this.gp_Delete.Name = "gp_Delete";
            this.gp_Delete.Size = new System.Drawing.Size(530, 219);
            this.gp_Delete.TabIndex = 3;
            this.gp_Delete.TabStop = false;
            this.gp_Delete.Text = "Delete:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOrderID.Location = new System.Drawing.Point(287, 86);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(216, 35);
            this.txtOrderID.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_arrow_24px;
            this.btnDelete.Location = new System.Drawing.Point(178, 136);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 62);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Order.Location = new System.Drawing.Point(85, 86);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(103, 30);
            this.lbl_Order.TabIndex = 2;
            this.lbl_Order.Text = "Order ID:";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Search.Location = new System.Drawing.Point(199, 31);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(114, 30);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Search by:";
            // 
            // gp_Filter
            // 
            this.gp_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gp_Filter.Controls.Add(this.lbl_DateOfTransaction);
            this.gp_Filter.Controls.Add(this.txt_Location);
            this.gp_Filter.Controls.Add(this.txt_ConsoleName);
            this.gp_Filter.Controls.Add(this.txt_OrderName);
            this.gp_Filter.Controls.Add(this.txt_GameName);
            this.gp_Filter.Controls.Add(this.lbl_Location);
            this.gp_Filter.Controls.Add(this.lbl_GameName);
            this.gp_Filter.Controls.Add(this.lbl_ConsoleName);
            this.gp_Filter.Controls.Add(this.lbl_OrderName);
            this.gp_Filter.Controls.Add(this.dtp_DateOfTrans);
            this.gp_Filter.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.gp_Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gp_Filter.Location = new System.Drawing.Point(936, 390);
            this.gp_Filter.Name = "gp_Filter";
            this.gp_Filter.Size = new System.Drawing.Size(530, 441);
            this.gp_Filter.TabIndex = 4;
            this.gp_Filter.TabStop = false;
            this.gp_Filter.Text = "Filter by:";
            // 
            // lbl_DateOfTransaction
            // 
            this.lbl_DateOfTransaction.AutoSize = true;
            this.lbl_DateOfTransaction.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_DateOfTransaction.Location = new System.Drawing.Point(85, 374);
            this.lbl_DateOfTransaction.Name = "lbl_DateOfTransaction";
            this.lbl_DateOfTransaction.Size = new System.Drawing.Size(209, 30);
            this.lbl_DateOfTransaction.TabIndex = 13;
            this.lbl_DateOfTransaction.Text = "Date of Transaction:";
            // 
            // txt_Location
            // 
            this.txt_Location.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Location.Location = new System.Drawing.Point(287, 284);
            this.txt_Location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Size = new System.Drawing.Size(216, 35);
            this.txt_Location.TabIndex = 5;
            this.txt_Location.TextChanged += new System.EventHandler(this.txt_Location_TextChanged);
            // 
            // txt_ConsoleName
            // 
            this.txt_ConsoleName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ConsoleName.Location = new System.Drawing.Point(287, 199);
            this.txt_ConsoleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ConsoleName.Name = "txt_ConsoleName";
            this.txt_ConsoleName.Size = new System.Drawing.Size(216, 35);
            this.txt_ConsoleName.TabIndex = 4;
            this.txt_ConsoleName.TextChanged += new System.EventHandler(this.txt_ConsoleName_TextChanged);
            // 
            // txt_OrderName
            // 
            this.txt_OrderName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_OrderName.Location = new System.Drawing.Point(287, 46);
            this.txt_OrderName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OrderName.Name = "txt_OrderName";
            this.txt_OrderName.Size = new System.Drawing.Size(216, 35);
            this.txt_OrderName.TabIndex = 2;
            this.txt_OrderName.TextChanged += new System.EventHandler(this.txt_OrderName_TextChanged);
            // 
            // txt_GameName
            // 
            this.txt_GameName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_GameName.Location = new System.Drawing.Point(287, 127);
            this.txt_GameName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GameName.Name = "txt_GameName";
            this.txt_GameName.Size = new System.Drawing.Size(216, 35);
            this.txt_GameName.TabIndex = 3;
            this.txt_GameName.TextChanged += new System.EventHandler(this.txt_GameName_TextChanged);
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Location.Location = new System.Drawing.Point(85, 287);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(104, 30);
            this.lbl_Location.TabIndex = 9;
            this.lbl_Location.Text = "Location:";
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.AutoSize = true;
            this.lbl_GameName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_GameName.Location = new System.Drawing.Point(85, 127);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(139, 30);
            this.lbl_GameName.TabIndex = 8;
            this.lbl_GameName.Text = "Game Name:";
            // 
            // lbl_ConsoleName
            // 
            this.lbl_ConsoleName.AutoSize = true;
            this.lbl_ConsoleName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ConsoleName.Location = new System.Drawing.Point(85, 199);
            this.lbl_ConsoleName.Name = "lbl_ConsoleName";
            this.lbl_ConsoleName.Size = new System.Drawing.Size(161, 30);
            this.lbl_ConsoleName.TabIndex = 7;
            this.lbl_ConsoleName.Text = "Console Name:";
            // 
            // lbl_OrderName
            // 
            this.lbl_OrderName.AutoSize = true;
            this.lbl_OrderName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_OrderName.Location = new System.Drawing.Point(85, 51);
            this.lbl_OrderName.Name = "lbl_OrderName";
            this.lbl_OrderName.Size = new System.Drawing.Size(139, 30);
            this.lbl_OrderName.TabIndex = 6;
            this.lbl_OrderName.Text = "Order Name:";
            // 
            // dtp_DateOfTrans
            // 
            this.dtp_DateOfTrans.Location = new System.Drawing.Point(287, 369);
            this.dtp_DateOfTrans.Name = "dtp_DateOfTrans";
            this.dtp_DateOfTrans.Size = new System.Drawing.Size(216, 35);
            this.dtp_DateOfTrans.TabIndex = 6;
            this.dtp_DateOfTrans.ValueChanged += new System.EventHandler(this.dtp_DateOfTrans_ValueChanged);
            // 
            // Maintain_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1478, 880);
            this.Controls.Add(this.gp_Filter);
            this.Controls.Add(this.gp_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myGridView);
            this.Name = "Maintain_Orders";
            this.Text = "Maintain_Orders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Maintain_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).EndInit();
            this.gp_Delete.ResumeLayout(false);
            this.gp_Delete.PerformLayout();
            this.gp_Filter.ResumeLayout(false);
            this.gp_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gp_Delete;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.GroupBox gp_Filter;
        private System.Windows.Forms.DateTimePicker dtp_DateOfTrans;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbl_DateOfTransaction;
        private System.Windows.Forms.TextBox txt_Location;
        private System.Windows.Forms.TextBox txt_ConsoleName;
        private System.Windows.Forms.TextBox txt_OrderName;
        private System.Windows.Forms.TextBox txt_GameName;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_GameName;
        private System.Windows.Forms.Label lbl_ConsoleName;
        private System.Windows.Forms.Label lbl_OrderName;
    }
}
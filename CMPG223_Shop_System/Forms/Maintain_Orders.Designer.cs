
namespace CMPG223_Shop_System.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_Order = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gp_Delete = new System.Windows.Forms.GroupBox();
            this.lbl_OrderID = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gp_FilterBy = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ConsoleID = new System.Windows.Forms.Label();
            this.lbl_GameID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gp_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gp_FilterBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maintain Orders";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(204, 40);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(109, 28);
            this.lbl_Search.TabIndex = 2;
            this.lbl_Search.Text = "Search by:";
            // 
            // txt_Order
            // 
            this.txt_Order.Location = new System.Drawing.Point(313, 91);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Size = new System.Drawing.Size(223, 33);
            this.txt_Order.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 33);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // gp_Delete
            // 
            this.gp_Delete.Controls.Add(this.btnDelete);
            this.gp_Delete.Controls.Add(this.lbl_OrderID);
            this.gp_Delete.Controls.Add(this.lbl_Search);
            this.gp_Delete.Controls.Add(this.txt_Order);
            this.gp_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gp_Delete.Location = new System.Drawing.Point(953, 87);
            this.gp_Delete.Name = "gp_Delete";
            this.gp_Delete.Size = new System.Drawing.Size(611, 236);
            this.gp_Delete.TabIndex = 5;
            this.gp_Delete.TabStop = false;
            this.gp_Delete.Text = "Delete";
            // 
            // lbl_OrderID
            // 
            this.lbl_OrderID.AutoSize = true;
            this.lbl_OrderID.Location = new System.Drawing.Point(137, 91);
            this.lbl_OrderID.Name = "lbl_OrderID";
            this.lbl_OrderID.Size = new System.Drawing.Size(98, 28);
            this.lbl_OrderID.TabIndex = 4;
            this.lbl_OrderID.Text = "Order ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(46, 87);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(867, 675);
            this.dataGridView2.TabIndex = 6;
            // 
            // gp_FilterBy
            // 
            this.gp_FilterBy.Controls.Add(this.textBox5);
            this.gp_FilterBy.Controls.Add(this.textBox4);
            this.gp_FilterBy.Controls.Add(this.textBox3);
            this.gp_FilterBy.Controls.Add(this.label8);
            this.gp_FilterBy.Controls.Add(this.label7);
            this.gp_FilterBy.Controls.Add(this.lbl_ConsoleID);
            this.gp_FilterBy.Controls.Add(this.lbl_GameID);
            this.gp_FilterBy.Controls.Add(this.lblOrderID);
            this.gp_FilterBy.Controls.Add(this.textBox2);
            this.gp_FilterBy.Controls.Add(this.dateTimePicker1);
            this.gp_FilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gp_FilterBy.Location = new System.Drawing.Point(953, 329);
            this.gp_FilterBy.Name = "gp_FilterBy";
            this.gp_FilterBy.Size = new System.Drawing.Size(602, 433);
            this.gp_FilterBy.TabIndex = 6;
            this.gp_FilterBy.TabStop = false;
            this.gp_FilterBy.Text = "Filter by:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 33);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(327, 204);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 33);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 33);
            this.textBox3.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date Of Transaction:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Location:";
            // 
            // lbl_ConsoleID
            // 
            this.lbl_ConsoleID.AutoSize = true;
            this.lbl_ConsoleID.Location = new System.Drawing.Point(165, 209);
            this.lbl_ConsoleID.Name = "lbl_ConsoleID";
            this.lbl_ConsoleID.Size = new System.Drawing.Size(118, 28);
            this.lbl_ConsoleID.TabIndex = 6;
            this.lbl_ConsoleID.Text = "Console ID:";
            // 
            // lbl_GameID
            // 
            this.lbl_GameID.AutoSize = true;
            this.lbl_GameID.Location = new System.Drawing.Point(165, 145);
            this.lbl_GameID.Name = "lbl_GameID";
            this.lbl_GameID.Size = new System.Drawing.Size(98, 28);
            this.lbl_GameID.TabIndex = 5;
            this.lbl_GameID.Text = "Game ID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(165, 71);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(98, 28);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "Order ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 33);
            this.textBox2.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.Image = global::CMPG223_Shop_System.Properties.Resources.icons8_arrow_24px;
            this.btnDelete.Location = new System.Drawing.Point(170, 145);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(300, 68);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Maintain_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.gp_FilterBy);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.gp_Delete);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Maintain_Orders";
            this.Text = "Maintain_Orders";
            this.gp_Delete.ResumeLayout(false);
            this.gp_Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gp_FilterBy.ResumeLayout(false);
            this.gp_FilterBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Order;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gp_Delete;
        private System.Windows.Forms.Label lbl_OrderID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gp_FilterBy;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_ConsoleID;
        private System.Windows.Forms.Label lbl_GameID;
        private System.Windows.Forms.Button btnDelete;
    }
}
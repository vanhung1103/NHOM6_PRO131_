namespace _3_PL.Views
{
    partial class Frm_Bill
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
            label2 = new Label();
            label1 = new Label();
            txt_search = new TextBox();
            txt_total = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dtg_show = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_mahd = new TextBox();
            txt_productname = new TextBox();
            txt_discount = new TextBox();
            txt_des = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dtp_createdate = new DateTimePicker();
            cbx_voucher = new ComboBox();
            cbx_billdetail = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 25);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 26;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 183);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 25;
            label1.Text = "Tổng";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(332, 22);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(370, 31);
            txt_search.TabIndex = 24;
            // 
            // txt_total
            // 
            txt_total.Location = new Point(55, 231);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(209, 31);
            txt_total.TabIndex = 23;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(879, 229);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(879, 151);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(879, 68);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(12, 362);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 62;
            dtg_show.RowTemplate.Height = 33;
            dtg_show.Size = new Size(964, 225);
            dtg_show.TabIndex = 19;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 89);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 27;
            label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 89);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 28;
            label4.Text = "Ngày tạo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(604, 89);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 29;
            label5.Text = "Tên sản phẩm";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(623, 192);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 30;
            label6.Text = "Mô tả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 192);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 31;
            label7.Text = "Discount";
            // 
            // txt_mahd
            // 
            txt_mahd.Location = new Point(55, 129);
            txt_mahd.Name = "txt_mahd";
            txt_mahd.Size = new Size(209, 31);
            txt_mahd.TabIndex = 32;
            // 
            // txt_productname
            // 
            txt_productname.Location = new Point(623, 141);
            txt_productname.Name = "txt_productname";
            txt_productname.Size = new Size(209, 31);
            txt_productname.TabIndex = 33;
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(308, 232);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(209, 31);
            txt_discount.TabIndex = 34;
            // 
            // txt_des
            // 
            txt_des.Location = new Point(623, 232);
            txt_des.Name = "txt_des";
            txt_des.Size = new Size(209, 31);
            txt_des.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 292);
            label8.Name = "label8";
            label8.Size = new Size(139, 25);
            label8.TabIndex = 37;
            label8.Text = "Hóa đơn chi tiết";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 292);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 38;
            label9.Text = "Voucher";
            // 
            // dtp_createdate
            // 
            dtp_createdate.Location = new Point(308, 139);
            dtp_createdate.Name = "dtp_createdate";
            dtp_createdate.Size = new Size(283, 31);
            dtp_createdate.TabIndex = 39;
            // 
            // cbx_voucher
            // 
            cbx_voucher.FormattingEnabled = true;
            cbx_voucher.Location = new Point(150, 307);
            cbx_voucher.Name = "cbx_voucher";
            cbx_voucher.Size = new Size(206, 33);
            cbx_voucher.TabIndex = 41;
            // 
            // cbx_billdetail
            // 
            cbx_billdetail.FormattingEnabled = true;
            cbx_billdetail.Location = new Point(623, 307);
            cbx_billdetail.Name = "cbx_billdetail";
            cbx_billdetail.Size = new Size(209, 33);
            cbx_billdetail.TabIndex = 42;
            // 
            // Frm_Bill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 609);
            Controls.Add(cbx_billdetail);
            Controls.Add(cbx_voucher);
            Controls.Add(dtp_createdate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txt_des);
            Controls.Add(txt_discount);
            Controls.Add(txt_productname);
            Controls.Add(txt_mahd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(txt_total);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_show);
            Name = "Frm_Bill";
            Text = "Frm_Bill";
            Load += Frm_Bill_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_total;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtg_show;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_mahd;
        private TextBox txt_productname;
        private TextBox txt_discount;
        private TextBox txt_des;
        private Label label8;
        private Label label9;
        private DateTimePicker dtp_createdate;
        private ComboBox cbx_voucher;
        private ComboBox cbx_billdetail;
    }
}
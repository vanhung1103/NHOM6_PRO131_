namespace _3_PL.Views
{
    partial class Frm_BillDetail
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
            tbx_mahd = new TextBox();
            dtg_show = new DataGridView();
            tbx_price = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbx_image = new TextBox();
            label5 = new Label();
            tbx_quantity = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            cbx_productname = new ComboBox();
            cbx_bill = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 43);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 26;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 25;
            label1.Text = "Mã hóa đơn CT";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(282, 37);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(370, 31);
            txt_search.TabIndex = 24;
            // 
            // tbx_mahd
            // 
            tbx_mahd.Location = new Point(33, 158);
            tbx_mahd.Name = "tbx_mahd";
            tbx_mahd.Size = new Size(229, 31);
            tbx_mahd.TabIndex = 23;
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new Point(12, 301);
            dtg_show.Name = "dtg_show";
            dtg_show.RowHeadersWidth = 62;
            dtg_show.RowTemplate.Height = 33;
            dtg_show.Size = new Size(751, 225);
            dtg_show.TabIndex = 19;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // tbx_price
            // 
            tbx_price.Location = new Point(33, 244);
            tbx_price.Name = "tbx_price";
            tbx_price.Size = new Size(229, 31);
            tbx_price.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 201);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 27;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 196);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 29;
            label4.Text = "Image";
            // 
            // tbx_image
            // 
            tbx_image.Location = new Point(303, 244);
            tbx_image.Name = "tbx_image";
            tbx_image.Size = new Size(229, 31);
            tbx_image.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(590, 110);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 31;
            label5.Text = "Tên sản phẩm";
            // 
            // tbx_quantity
            // 
            tbx_quantity.Location = new Point(303, 158);
            tbx_quantity.Name = "tbx_quantity";
            tbx_quantity.Size = new Size(229, 31);
            tbx_quantity.TabIndex = 30;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(803, 301);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 20;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(803, 384);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 21;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(803, 462);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cbx_productname
            // 
            cbx_productname.FormattingEnabled = true;
            cbx_productname.Location = new Point(667, 167);
            cbx_productname.Name = "cbx_productname";
            cbx_productname.Size = new Size(198, 33);
            cbx_productname.TabIndex = 32;
            // 
            // cbx_bill
            // 
            cbx_bill.FormattingEnabled = true;
            cbx_bill.Location = new Point(667, 242);
            cbx_bill.Name = "cbx_bill";
            cbx_bill.Size = new Size(209, 33);
            cbx_bill.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(590, 215);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 34;
            label6.Text = "Bill";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 110);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 35;
            label7.Text = "Quantity";
            // 
            // Frm_BillDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 539);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbx_bill);
            Controls.Add(cbx_productname);
            Controls.Add(label5);
            Controls.Add(tbx_quantity);
            Controls.Add(label4);
            Controls.Add(tbx_image);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(tbx_price);
            Controls.Add(tbx_mahd);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_show);
            Name = "Frm_BillDetail";
            Text = "Frm_BillDetail";
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private TextBox tbx_mahd;
        private DataGridView dtg_show;
        private TextBox tbx_price;
        private Label label3;
        private Label label4;
        private TextBox tbx_image;
        private Label label5;
        private TextBox tbx_quantity;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cbx_productname;
        private ComboBox cbx_bill;
        private Label label6;
        private Label label7;
    }
}
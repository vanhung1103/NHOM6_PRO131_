namespace _3_PL.Views
{
    partial class Frm_Size
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
            txt_name = new TextBox();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            dtg_color = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_color).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 48);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 18;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(434, 180);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(196, 76);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(370, 31);
            txt_search.TabIndex = 16;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(453, 211);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(150, 31);
            txt_name.TabIndex = 15;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(646, 369);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(646, 291);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(646, 208);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 12;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // dtg_color
            // 
            dtg_color.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_color.Location = new Point(42, 178);
            dtg_color.Name = "dtg_color";
            dtg_color.RowHeadersWidth = 62;
            dtg_color.RowTemplate.Height = 33;
            dtg_color.Size = new Size(360, 225);
            dtg_color.TabIndex = 11;
            // 
            // Frm_Size
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_search);
            Controls.Add(txt_name);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dtg_color);
            Name = "Frm_Size";
            Text = "Frm_Size";
            ((System.ComponentModel.ISupportInitialize)dtg_color).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_name;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private DataGridView dtg_color;
    }
}
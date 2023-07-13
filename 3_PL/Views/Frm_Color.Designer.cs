namespace _3_PL.Views
{
    partial class Frm_Color
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
            dtg_color = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_search = new TextBox();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtg_color).BeginInit();
            SuspendLayout();
            // 
            // dtg_color
            // 
            dtg_color.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_color.Location = new Point(45, 180);
            dtg_color.Name = "dtg_color";
            dtg_color.RowHeadersWidth = 62;
            dtg_color.RowTemplate.Height = 33;
            dtg_color.Size = new Size(360, 225);
            dtg_color.TabIndex = 0;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(649, 210);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(649, 293);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(112, 34);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(649, 371);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(199, 78);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(370, 31);
            txt_search.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 182);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(456, 213);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(150, 31);
            txt_name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 50);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 10;
            label2.Text = "Search";
            label2.Click += label2_Click;
            // 
            // Frm_Color
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
            Name = "Frm_Color";
            Text = "Frm_Color";
            ((System.ComponentModel.ISupportInitialize)dtg_color).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_color;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_search;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
    }
}
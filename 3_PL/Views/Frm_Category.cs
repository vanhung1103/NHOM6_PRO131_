using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class Frm_Category : Form
    {
        ICategoryServices cateform;
        Category loaisanphams;
        public Frm_Category()
        {
            InitializeComponent();
            cateform = new CategoryServices();
            loaisanphams = new Category();
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            dtg_cate.Rows.Clear();
            dtg_cate.ColumnCount = 2;
            dtg_cate.Columns[0].Name = "Id";
            dtg_cate.Columns[1].Name = "Name";
            foreach (var x in cateform.GetCategories())
            {
                dtg_cate.Rows.Add(x.Id, x.Name);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (loaisanphams != null)
            {
                cateform.DeleteCategory(loaisanphams.Id);
                LoadData();
                MessageBox.Show("Xoa thanh cong", "Xoa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (loaisanphams != null)
            {
                loaisanphams.Name = txt_name.Text;
                cateform.UpdateCategory(loaisanphams);
                LoadData();
                MessageBox.Show("Sua thanh cong", "Sua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var them = new Category()
            {
                Id = Guid.NewGuid(),
                Name = txt_name.Text,
            };
            if (them.Name == loaisanphams.Name)
            {
                MessageBox.Show("Da ton tai");
            }
            else
            {
                if (cateform.AddCategory(them) != null)
                {
                    LoadData();
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Error", "Loi", MessageBoxButtons.OK);
                }
            }
        
    }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text.Trim();
            var filteredSuppliers = cateform.GetCategories().Where(x => x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dtg_cate.Rows.Clear();
            foreach (var x in filteredSuppliers)
            {
                dtg_cate.Rows.Add(x.Id, x.Name);
            }
        }

        private void dtg_color_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (selectedRow >= 0 && selectedRow < dtg_cate.Rows.Count)
            {
                DataGridViewRow row = dtg_cate.Rows[selectedRow];
                var selectedId = Guid.Parse(row.Cells[0].Value.ToString());
                loaisanphams = cateform.GetCategoryID(selectedId);
                txt_name.Text = loaisanphams.Name;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

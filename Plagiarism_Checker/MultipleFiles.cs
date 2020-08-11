using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plagiarism_Checker
{
    public partial class MultipleFiles : Form
    {
        private file[] targetFiles;
        private List<string> filePaths;
        

        public MultipleFiles(List<string> filePaths)
        {
            InitializeComponent();
            this.filePaths = filePaths;

            targetFiles= new file[filePaths.Count];


            DataGridView gv = createGridView();
            mf_pnl.Controls.Add(gv);
           // this.Controls.Add(gv);
        }


        private void comparator()
        {



            for(int i=0;i<targetFiles.Length;i++)
            {
                for(int j = 0; j < targetFiles.Length; j++)
                {
                   // targetFiles[i].Compare
                }
            }




        }








        private void MultipleFiles_Load(object sender, EventArgs e)
        {

        }

        private DataGridView createGridView()
        {
            DataGridView gv = new DataGridView();
            //gv.Size.Width = 200;
            //gv.Size.Height = 500;

            int _count = filePaths.Count;

            for (int i=0; i< _count; i++ )
            {
                DataGridTextBoxColumn column = new DataGridTextBoxColumn();
                 column.HeaderText = new FileInfo(filePaths[i]).Name;
                gv.Columns.Add("C"+i, new FileInfo(filePaths[i]).Name);
                gv.Columns[i].HeaderCell.Style.Font = new Font("Tahoma",12,FontStyle.Bold);
             }

            for (int i = 0; i < _count; i++)
            {
                 DataGridViewRow row = new DataGridViewRow();
                 row.HeaderCell.Value = new FileInfo(filePaths[i]).Name;
                gv.Rows.Add(row);
                gv.Rows[i].HeaderCell.Style.Font=new Font("Tahoma", 12, FontStyle.Bold);
            }

            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gv.Dock = DockStyle.Fill;
            gv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            gv.AllowUserToOrderColumns = false;
           //    gv.EditMode = DataGridViewEditMode.EditProgrammatically;

            gv.ReadOnly = true;
            gv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gv.MultiSelect = false;

            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            gv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Wheat;
            gv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            gv.RowHeadersDefaultCellStyle.BackColor = Color.Gray;
            gv.RowHeadersDefaultCellStyle.ForeColor = Color.Wheat;



            //  gv.RowHeadersDefaultCellStyle=DataGridViewRowHeadersWidthSizeMode.
            return gv;

        }







    }
}

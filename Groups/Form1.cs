using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'dataSet1.Groups' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.groupsTableAdapter.Fill(this.dataSet1.Groups);

        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrontBtn_Click(object sender, EventArgs e)
        {
            this.groupsBindingSource.MovePrevious();
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            this.groupsBindingSource.MoveNext();
        }

        private void TopBtn_Click(object sender, EventArgs e)
        {
            this.groupsBindingSource.MoveFirst();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            this.groupsBindingSource.MoveLast();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sms.Accounts
{
    public partial class frmFeeStructure : Form
    {
        public frmFeeStructure()
        {
            InitializeComponent();
        }

        private void frmFeeStructure_Load(object sender, EventArgs e)
        {
            loadFeeStructure();
            loadTotals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtVote.Text == "")
            {

            }
            {
                string sql = "insert into FeesStructure values ('" + txtYear.Text + "','" + txtVote.Text + "','" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txtTotals.Text + "','" + txtP1.Text + "','" + txtP2.Text + "','" + txtP3.Text + "','"+ txtPT.Text +"')";
                OpenTable.NonQuery(sql);
                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFeeStructure();
                loadTotals();
            }
        }
        void loadTotals()
        {
            string sqlls = "select SUM( cast(TermI as float)) as TermI,SUM( cast(TermII as float)) as TermII,SUM( cast(TermIII as float)) as TermII,( SUM( cast(TermI as float))+ SUM( cast(TermII as float))+ SUM( cast(TermIII as float)) ) as Totals,year from FeesStructure where YEAR=2017  group by YEAR";
            DataTable dts = OpenTable.Query(sqlls);
            txtTermI.Text =dts.Rows[0][0].ToString();
            txtTermII.Text = dts.Rows[0][1].ToString();
            txtTermIII.Text = dts.Rows[0][2].ToString();
            txtTotalFee.Text = dts.Rows[0][3].ToString();
        }
        void loadFeeStructure()
        {
            string sql = "select * from FeesStructure";
            DataTable dt = OpenTable.Query(sql);
            int x = dt.Rows.Count;
            if (dt.Rows.Count > 0)
            {
                StudentsList.Items.Clear();
                for (int k = 0; k < x; k++)
                {
                    int mm = k + 1;
                    string m = mm.ToString();
                    ListViewItem lvi = new ListViewItem(m);
                   
                    lvi.SubItems.Add(dt.Rows[k][2].ToString());
                    lvi.SubItems.Add(dt.Rows[k][3].ToString());
                    lvi.SubItems.Add(dt.Rows[k][4].ToString());
                    lvi.SubItems.Add(dt.Rows[k][5].ToString());
                    lvi.SubItems.Add(dt.Rows[k][6].ToString());
                    lvi.SubItems.Add(dt.Rows[k][7].ToString());
                    lvi.SubItems.Add(dt.Rows[k][8].ToString());
                    lvi.SubItems.Add(dt.Rows[k][9].ToString());
                    lvi.SubItems.Add(dt.Rows[k][10].ToString());
                    lvi.SubItems.Add(dt.Rows[k][1].ToString());
                    StudentsList.Items.Add(lvi);
                }
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = (Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text) + Convert.ToInt32(txt3.Text));
                txtTotals.Text = x.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            int x = (Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text) + Convert.ToInt32(txt3.Text));
            txtTotals.Text = x.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            try
            {
           int x = (Convert.ToInt32(txt1.Text) +Convert.ToInt32(txt2.Text) + Convert.ToInt32(txt3.Text));
           txtTotals.Text = x.ToString();
    }
            catch (Exception ex)
            {

            }
        }

        private void StudentsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
            txtVote.Text = StudentsList.SelectedItems[0].SubItems[1].Text;
            txt1.Text = StudentsList.SelectedItems[0].SubItems[2].Text;
            txt2.Text = StudentsList.SelectedItems[0].SubItems[3].Text;
            txt3.Text = StudentsList.SelectedItems[0].SubItems[4].Text;
            txtTotals.Text = StudentsList.SelectedItems[0].SubItems[5].Text;
            txtP1.Text = StudentsList.SelectedItems[0].SubItems[6].Text;
            txtP2.Text = StudentsList.SelectedItems[0].SubItems[7].Text;
            txtP3.Text = StudentsList.SelectedItems[0].SubItems[8].Text;
            txtPT.Text = StudentsList.SelectedItems[0].SubItems[9].Text;
            txtYear.Text = StudentsList.SelectedItems[0].SubItems[10].Text;
            txtYYear.Text = StudentsList.SelectedItems[0].SubItems[10].Text;
            txtVVote.Text=StudentsList.SelectedItems[0].SubItems[1].Text;
            //x.txtStatus.Text = StudentsList.SelectedItems[0].SubItems[10].Text;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Delete?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String sql = "delete from FeesStructure where year='"+ txtYYear.Text +"' and VoteHeads='"+ txtVVote.Text +"'";
                OpenTable.NonQuery(sql);
                MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFeeStructure();
            }
            else
            {
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string sql = "Update FeesStructure set [Year]='" + txtYear.Text + "',[VoteHeads]='" + txtVote.Text + "',[TermI]='" + txt1.Text + "',[TermII]='" + txt2.Text + "',[TermIII]='" + txt3.Text + "',[Totals]='" + txtTotals.Text + "',[T1]='" + txtP1.Text + "',[T2]='" + txtP2.Text + "',[T3]='" + txtP3.Text + "',[TT]='" + txtPT.Text + "' where year ='"+ txtYYear.Text +"' and VoteHeads='"+ txtVVote.Text  +"'";
            OpenTable.NonQuery(sql);
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadFeeStructure();
        }

        private void txtYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

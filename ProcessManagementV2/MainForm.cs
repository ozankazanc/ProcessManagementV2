using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManagementV2
{
    public partial class MainForm : Form
    {
        static string conString = "Server=.;Initial Catalog=master;Integrated Security=SSPI";
        string query;
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        bool HasErrorMessage = false;
        string _hostName;
        int _ssid;
        int rowCount;
        public MainForm()
        {
            InitializeComponent();
            connection = new SqlConnection(conString);
        }
        
        public int Result(string hostName = null, int ssid = -1)
        {
            try
            {
                if (hostName == null && ssid == -1)
                {
                    //GetAllProcess, GetBlocking
                }
                if (ssid != -1)
                {
                    query = $"SELECT session_id AS SPID, host_name, login_name, nt_domain, nt_user_name, login_time, status FROM sys.dm_exec_sessions WHERE session_id='{ssid}' AND is_user_process = 1";
                }
                if (hostName != null)
                {
                    query = $"SELECT session_id AS SPID, host_name, login_name, nt_domain, nt_user_name, login_time, status FROM sys.dm_exec_sessions WHERE host_name='{hostName}' AND is_user_process = 1";
                    //query = "SELECT * FROM sys.dm_exec_sessions WHERE host_name = 'DESKTOP-VHCME38'";
                }

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable process_s = new DataTable();
                    dataAdapter.Fill(process_s);
                    dgProcessList.DataSource = process_s;
                    rowCount = process_s.Rows.Count;
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                HasErrorMessage = true;
                rowCount = 0;
            }
            return rowCount;
        }

        private void BtnSearchHostName_Click(object sender, EventArgs e)
        {
            _hostName = txHostName.Text;
            if (!String.IsNullOrEmpty(txHostName.Text))
            {
                Result(hostName: _hostName);
                if (HasErrorMessage == false)
                {
                    if (rowCount <= 0)
                    {
                        MessageBox.Show("Listelenecek process bulunamadı.", "Bilgilendirme");
                    }
                }
                else
                {
                    HasErrorMessage = true; // Show error message with result method in catch block
                }
            }
        }
        private void BtnSearchSpid_Click(object sender, EventArgs e)
        {
            try
            {
                _ssid = Convert.ToInt32(txSpid.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Doğru değeri girdiğinizden emin olun.");
            }
            if (!String.IsNullOrEmpty(txSpid.Text))
            {
                Result(ssid: _ssid);
                if (HasErrorMessage == false)
                {
                    if (rowCount <= 0)
                    {
                        MessageBox.Show("Listelenecek process bulunamadı.", "Bilgilendirme");
                    }
                }
                else
                {
                    HasErrorMessage = false; // Show error message with result method in catch block
                }
            }
        }

        private void BtnGetAllProcess_Click(object sender, EventArgs e)
        {
            
            query = "SELECT session_id AS SPID, host_name, login_name, nt_domain, nt_user_name, login_time, status FROM sys.dm_exec_sessions WHERE is_user_process = 1";
            Result();
            if (HasErrorMessage == false)
            {
                if (rowCount <= 0)
                {
                    MessageBox.Show("Listelenecek process bulunamadı.", "Bilgilendirme");
                }
            }
            else
            {
                HasErrorMessage = false; // Show error message with result method in catch block
            }
        }

        private void BtnShowConString_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ConnectionString: {conString}");
        }

        private void BtnChangeConString_Click(object sender, EventArgs e)
        {
            string changeConString = txConString.Text;
            if (!String.IsNullOrEmpty(changeConString))
            {
                conString = changeConString;
            }
            
        }
        private void BtnGetBlockingQuery_Click(object sender, EventArgs e)
        {
            query= 
                "Select sessionTbl.host_name," +
                "requestTbl.blocking_session_id," +
                "requestTbl.status," +
                "requestTbl.command," +
                "sessionTbl.session_id AS SPID," +
                "sessionTbl.login_name," +
                "sessionTbl.nt_domain," +
                "sessionTbl.nt_user_name," +
                "sessionTbl.login_time," +
                "sessionTbl.status as SessionStatus" +
                " from sys.dm_exec_sessions sessionTbl " +
                "inner join sys.dm_exec_requests requestTbl " +
                "ON sessionTbl.session_id = requestTbl.session_id " +
                "where sessionTbl.session_id > 50 AND requestTbl.blocking_session_id <> 0;";
            //query = "SELECT session_id,host_name, login_name, nt_domain, nt_user_name, login_time, status,@@SPID as SPID FROM sys.dm_exec_sessions WHERE is_user_process = 1";
            Result();
            if (HasErrorMessage == false)
            {
                if (rowCount <= 0)
                {
                    MessageBox.Show("Listelenecek process bulunamadı.", "Bilgilendirme");
                }
            }
            else
            {
                HasErrorMessage = false; // Show error message with result method in catch block
            }
        }

        private void BtnKill_Click(object sender, EventArgs e)
        {
            //DOLDURULACAK
        }

        private void dgProcessList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(rowCount>0)
            {
                txBlockHostName.Text = dgProcessList.CurrentRow.Cells["host_name"].Value.ToString();
                txBlockSPID.Text = dgProcessList.CurrentRow.Cells["SPID"].Value.ToString();
                try
                {
                    txBlockingSPID.Text = dgProcessList.CurrentRow.Cells["blocking_session_id"].Value.ToString();
                }
                catch(System.ArgumentException)
                {
                    txBlockingSPID.Clear();
                }
            }
            else
            {
                txBlockHostName.Clear();
                txBlockSPID.Clear();
                txBlockingSPID.Clear();
            }

            if (!String.IsNullOrEmpty(txBlockSPID.Text) && String.IsNullOrEmpty(txBlockingSPID.Text))
            {
                txBlockSPID.BackColor = Color.OrangeRed;
                txBlockingSPID.BackColor = Color.White;
            }
            else
            {
                txBlockSPID.BackColor = Color.White;
                txBlockingSPID.BackColor = Color.OrangeRed;
            }
        }

        

       
    }
}

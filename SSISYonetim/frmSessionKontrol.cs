using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SSISYonetim.Models.SessionView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSISYonetim
{
    public partial class frmSessionKontrol : Form
    {
        public frmSessionKontrol()
        {
            InitializeComponent();
        }

        public frmAnasayfa frmAnasayfa;
        public string EkranNo = "";
        int Secili_sessionID = 0;
        int SeciliSatirSayi = 0;
        private void frmSessionKontrol_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void frmSessionKontrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAnasayfa.DiziFormlar.Remove(this);
            frmAnasayfa.DiziFormTag.Remove("session_kontrol");
            frmAnasayfa.TabCikar("session_kontrol");
        }
        private void SessionGetir()
        {
            using (var db = new BISReportsDBContext())
            {
                try
                {
                    var list = db.VwDwhSessionKontrol
                                 .OrderBy(o => o.Status).ThenByDescending(t => t.ConnectTime)
                                 .ToList();
                    if (chkTextSorgu.Checked)
                    {
                        if (txtText.Text == "")
                        {
                            MessageBox.Show("Text - Sorgu Ara checkbox seçili fakat geçerli bir text girmediniz.");
                        }
                        else
                        {
                            string txtTextSorgu = txtText.Text;
                            list = list.OrderBy(o => o.Status).ThenByDescending(t => t.ConnectTime)
                                       .Where(w => w.Text.Contains(txtTextSorgu))
                                       .ToList();
                            dgvSessionKontrol.DataSource = list;
                            chkDoldur(list);
                        }
                    }
                    if (chkStatus.Checked && !chkLoginName.Checked)
                    {
                        if (cmbStatus.Text == "")
                        {
                            MessageBox.Show("Status Ara checkbox seçili fakat geçerli bir Status seçmediniz.");
                        }
                        else
                        {
                            string txtStatu = cmbStatus.SelectedItem.ToString();
                            txtStatu = txtStatu.Replace("{", "").Replace("}", "").Replace("Status =", "").Trim();
                            list = list.OrderBy(o => o.Status).ThenByDescending(t => t.ConnectTime)
                                       .Where(w => w.Status.Contains(txtStatu))
                                       .ToList();
                            dgvSessionKontrol.DataSource = list;
                            chkDoldur(list);
                        }
                    }
                    if (chkLoginName.Checked && !chkStatus.Checked)
                    {
                        if (cmbLoginName.Text == "")
                        {
                            MessageBox.Show("Login Name Ara checkbox seçili fakat geçerli bir LoginName seçmediniz.");
                        }
                        else
                        {
                            string txtLogin = cmbLoginName.SelectedItem.ToString();
                            txtLogin = txtLogin.Replace("{", "").Replace("}", "").Replace("LoginName =", "").Trim();
                            list = list.OrderBy(o => o.Status).ThenByDescending(t => t.ConnectTime)
                                       .Where(w => w.LoginName.Contains(txtLogin))
                                       .ToList();
                            dgvSessionKontrol.DataSource = list;
                            chkDoldur(list);
                        }
                    }
                    if (chkStatus.Checked && chkLoginName.Checked)
                    {
                        if (cmbStatus.Text == "")
                        {
                            MessageBox.Show("Status Ara ve LoginName Ara checkbox seçili fakat geçerli bir arama kriteri seçmediniz.");
                        }
                        else
                        {
                            string txtStatu = cmbStatus.SelectedItem.ToString();
                            txtStatu = txtStatu.Replace("{", "").Replace("}", "").Replace("Status =", "").Trim();

                            string txtLogin = cmbLoginName.SelectedItem.ToString();
                            txtLogin = txtLogin.Replace("{", "").Replace("}", "").Replace("LoginName =", "").Trim();

                            list = list.OrderBy(o => o.Status).ThenByDescending(t => t.ConnectTime)
                                       .Where(w => w.Status.Contains(txtStatu) && w.LoginName.Contains(txtLogin))
                                       .ToList();
                            dgvSessionKontrol.DataSource = list;
                            chkDoldur(list);
                        }
                    }
                    if (!chkStatus.Checked && !chkLoginName.Checked)
                    {
                        dgvSessionKontrol.DataSource = list;
                        chkDoldur(list);
                    }

                    //cmbStatus.Items.AddRange
                    //(
                    //    list.GroupBy(g => g.Status, (key, g) => new { Status = key })
                    //        .Select(s => s)
                    //        .ToArray()
                    //);
                    //var listStatus = list.GroupBy(g => g.Status).Select(s => s).ToList(); // Bu Kodda Çalışıyor..

                    foreach (DataGridViewRow row in dgvSessionKontrol.Rows)
                    {
                        row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    }
                    lblSatirSayi.Text = dgvSessionKontrol.Rows.Count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        void chkTemizle()
        {
            chkLoginName.Checked = false;
            chkStatus.Checked = false;
        }
        void chkDoldur(List<VwDwhSessionKontrol> list)
        {
            cmbStatus.Items.Clear();
            cmbLoginName.Items.Clear();

            cmbStatus.Items.AddRange
                    (
                        list.GroupBy(g => g.Status, (key, g) => new { Status = key })
                            .Select(s => s)
                            .ToArray()
                    );
            cmbLoginName.Items.AddRange
                    (
                        list.GroupBy(g => g.LoginName, (key, g) => new { LoginName = key })
                            .Select(s => s)
                            .ToArray()
                    );
        }
        private void btnSessionKontrolListele_Click(object sender, EventArgs e)
        {
            SessionGetir();
            chkTemizle();
            //SeciliSatirSayi = 0;
        }

        List<long> seciliList = new List<long>();
        public List<long> SecilileriTespitEt()
        {
            foreach (DataGridViewRow row in dgvSessionKontrol.Rows)
            {
                bool chkSecili = Convert.ToBoolean(row.Cells["Sec"].Value);
                if (chkSecili)
                {
                    //var seciliSession = new SeciliSession();
                    //seciliSession.sessionID = Convert.ToInt32(row.Cells["ID"].Value);

                    Secili_sessionID = Convert.ToInt32(row.Cells["SessionId"].Value);
                    seciliList.Add(Secili_sessionID);

                    SeciliSatirSayi++;
                }
            }
            return seciliList;
        }
        private void btnSeciliKill_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeciliSatirSayi > 0)
                {                    
                    foreach (var item in seciliList)
                    {
                        Secili_sessionID = Convert.ToInt32(item.ToString());
                        using (var db = new BISReportsDBContext())
                        {
                            int result = 0;
                            string SessionKill = "exec Dwh_SessionKontrol @sessionid";

                            List<SqlParameter> param = new List<SqlParameter>
                            {
                                new SqlParameter {ParameterName = "@sessionid", Value = Secili_sessionID}
                            };

                            result = db.Database.ExecuteSqlRaw(SessionKill, param.ToArray());
                            if (result != 0)
                            {
                                MessageBox.Show("Session "+ Secili_sessionID +" is killed...");
                            }
                            else
                            {
                                MessageBox.Show("Session " + Secili_sessionID + " is not killed...");
                            }
                        }
                    }
                    SessionGetir();
                }
                else
                {
                    MessageBox.Show("Hiç bir seçim yapmadınız.\n\r\n\rLütfen seçim yaparak tekrar deneyiniz.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvSessionKontrol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSessionKontrol.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvSessionKontrol_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SeciliSatirSayi = 0;
            seciliList.Clear();
            SecilileriTespitEt();
        }
    }
}

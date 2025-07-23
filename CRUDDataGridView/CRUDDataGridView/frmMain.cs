using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDDataGridView
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        NORTHWNDEntities db;
        private void frmMain_Load(object sender, EventArgs e)
        {
            db = new NORTHWNDEntities();
            db.Customers.Load();
            customerBindingSource.DataSource = db.Customers.Local;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            customerBindingSource.AddNew();
        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Changes saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerBindingSource.RemoveCurrent();
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var changes = db.ChangeTracker.Entries()
                .Where(x=> x.State != EntityState.Unchanged).ToList();
            foreach (var item in changes)
            {
                switch(item.State)
                {
                    case EntityState.Added:
                        item.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        item.CurrentValues.SetValues(item.OriginalValues);
                        item.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        item.State = EntityState.Unchanged;
                        break;
                }
                customerBindingSource.ResetBindings(false);

            }
        }
    }
}
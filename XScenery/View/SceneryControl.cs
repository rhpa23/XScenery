using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XScenery.View
{
    public partial class SceneryControl : UserControl
    {
        public delegate void ClickButton(object sender, EventArgs args);
        public event ClickButton OnClickUp;
        public event ClickButton OnClickDown;
        public event ClickButton OnClickEdit;

        public bool EnableScenery
        {
            get { return ckBoxScenery.Checked; }
            set { ckBoxScenery.Checked = value; }
        }

        public string NameScenery
        {
            get { return txBoxScenery.Text; }
        }

        public SceneryControl()
        {
            InitializeComponent();
        }

        public SceneryControl(bool enabled, string name) : base()
        {
            InitializeComponent();
            ckBoxScenery.Checked = enabled;
            txBoxScenery.Text = name;
            ckBoxScenery.Text = name;

            txBoxScenery.Visible = string.IsNullOrEmpty(name);
        }

        private void pBoxUp_Click(object sender, EventArgs e)
        {
            if (OnClickUp != null)
                OnClickUp(this, e);
        }

        private void pBoxDown_Click(object sender, EventArgs e)
        {
            if (OnClickDown != null)
                OnClickDown(this, e);
        }

        private void pBoxEdit_Click(object sender, EventArgs e)
        {
            txBoxScenery.Visible = true;
            txBoxScenery.Focus();
            if (OnClickEdit != null)
                OnClickEdit(this, e);
        }

        private void txBoxScenery_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txBoxScenery.Text))
            {
                ckBoxScenery.Text = txBoxScenery.Text;
                txBoxScenery.Visible = false;
            }
            
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XScenery.Util;
using XScenery.View;

namespace XScenery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadSceneries()
        {
            string packFile = txBoxFolder.Text + "\\Custom Scenery\\" + "scenery_packs.ini";

            if (!File.Exists(packFile))
            {
                MessageBox.Show(this, "Unable to find scenery pack file in: " + packFile, "File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                using (var readText = new StreamReader(packFile))
                {
                    string line;
                    while ((line = readText.ReadLine()) != null)
                    {
                        if (line.StartsWith("SCENERY_PACK"))
                        {
                            bool enable = !line.StartsWith("SCENERY_PACK_DISABLED");
                            string name = line.Substring(line.IndexOf("/"));
                            var sceneryCtr = new SceneryControl(enable, name.Replace("/", ""));
                            SetEventsButtons(sceneryCtr);
                            tableLayoutPanel1.Controls.Add(sceneryCtr);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Cannot load info from scenery pack file. Verify if the folowing file is a valid X-Plane scenery pack: " + packFile, 
                    "Load File", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private bool SaveSceneries()
        {
            bool saved = true;
            string packFile = txBoxFolder.Text + "\\Custom Scenery\\" + "scenery_packs.ini";
            try
            {
                var fileText = new StringBuilder();
                using (var readText = new StreamReader(packFile))
                {
                    string line;
                    while ((line = readText.ReadLine()) != null)
                    {
                        if (!line.StartsWith("SCENERY_PACK"))
                        {
                            fileText.AppendLine(line);
                        }
                    }
                }

                foreach (SceneryControl control in tableLayoutPanel1.Controls)
                {
                    if (!string.IsNullOrEmpty(control.NameScenery.Trim()))
                    {
                        string sceneryTag = control.EnableScenery ? "SCENERY_PACK" : "SCENERY_PACK_DISABLED";
                        fileText.AppendLine(sceneryTag + " Custom Scenery/" + control.NameScenery + "/");
                    }
                }

                using (var outfile = new StreamWriter(packFile))
                {
                    outfile.Write(fileText.ToString());
                }

            }
            catch (Exception)
            {
                saved = false;
                MessageBox.Show(this, "Cannot save scenery pack file. Verify if the folowing file is a valid X-Plane scenery pack: " + packFile,
                    "Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saved;
        }

        private void SetEventsButtons(SceneryControl sceneryCtr)
        {
            sceneryCtr.OnClickUp += sceneryCtr_OnClickUp;
            sceneryCtr.OnClickDown += sceneryCtr_OnClickDown;
            sceneryCtr.OnClickEdit += sceneryCtr_OnClickEdit;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("XScenery.ini"))
            {
                using (var readfile = new StreamReader("XScenery.ini"))
                {
                    string path = readfile.ReadLine();
                    txBoxFolder.Text = path;
                    LoadSceneries();
                    btnUndoAll.Enabled = btnSave.Enabled = true;
                }
            }
        }

        void sceneryCtr_OnClickEdit(object sender, EventArgs args)
        {
            
        }

        void sceneryCtr_OnClickDown(object sender, EventArgs args)
        {
            var i = tableLayoutPanel1.Controls.GetChildIndex((SceneryControl)sender);
            tableLayoutPanel1.Controls.SetChildIndex((SceneryControl) sender, i + 1);
        }

        void sceneryCtr_OnClickUp(object sender, EventArgs args)
        {
            var i = tableLayoutPanel1.Controls.GetChildIndex((SceneryControl)sender);
            if (i-1 >= 0)
                tableLayoutPanel1.Controls.SetChildIndex((SceneryControl)sender, i - 1);
        }

        private void pBoxAdd_Click(object sender, EventArgs e)
        {
            var sceneryCtr = new SceneryControl(true, "");
            tableLayoutPanel1.Controls.Add(sceneryCtr);
            SetEventsButtons(sceneryCtr);
            sceneryCtr.Focus();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                txBoxFolder.Text = folderDialog.SelectedPath;
                LoadSceneries();

                using (var outfile = new StreamWriter("XScenery.ini"))
                {
                    outfile.Write(folderDialog.SelectedPath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Save scenery pack file?",
                                "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (SaveSceneries())
                    MessageBox.Show(this, "Scenery pack file saved.",
                                "File Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnUndoAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "This will reload your scenery pack file discarding all changes. You want to do this?",
                                "Reload", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tableLayoutPanel1.Controls.Clear();
                LoadSceneries();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (SceneryControl control in tableLayoutPanel1.Controls)
            {
                control.EnableScenery = checkBox1.Checked;
            }
        }
    }
}

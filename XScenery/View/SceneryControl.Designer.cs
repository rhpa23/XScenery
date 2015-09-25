namespace XScenery.View
{
    partial class SceneryControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ckBoxScenery = new System.Windows.Forms.CheckBox();
            this.txBoxScenery = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxDown = new System.Windows.Forms.PictureBox();
            this.pBoxUp = new System.Windows.Forms.PictureBox();
            this.pBoxEdit = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ckBoxScenery
            // 
            this.ckBoxScenery.AutoSize = true;
            this.ckBoxScenery.Location = new System.Drawing.Point(4, 7);
            this.ckBoxScenery.Name = "ckBoxScenery";
            this.ckBoxScenery.Size = new System.Drawing.Size(15, 14);
            this.ckBoxScenery.TabIndex = 0;
            this.toolTip.SetToolTip(this.ckBoxScenery, "Uncheck to disable");
            this.ckBoxScenery.UseVisualStyleBackColor = true;
            // 
            // txBoxScenery
            // 
            this.txBoxScenery.Location = new System.Drawing.Point(23, 5);
            this.txBoxScenery.Name = "txBoxScenery";
            this.txBoxScenery.Size = new System.Drawing.Size(558, 20);
            this.txBoxScenery.TabIndex = 1;
            this.txBoxScenery.Leave += new System.EventHandler(this.txBoxScenery_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XScenery.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxDown
            // 
            this.pBoxDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxDown.Image = global::XScenery.Properties.Resources.down;
            this.pBoxDown.Location = new System.Drawing.Point(639, 5);
            this.pBoxDown.Name = "pBoxDown";
            this.pBoxDown.Size = new System.Drawing.Size(16, 16);
            this.pBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxDown.TabIndex = 5;
            this.pBoxDown.TabStop = false;
            this.pBoxDown.Click += new System.EventHandler(this.pBoxDown_Click);
            // 
            // pBoxUp
            // 
            this.pBoxUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxUp.Image = global::XScenery.Properties.Resources.up;
            this.pBoxUp.Location = new System.Drawing.Point(615, 5);
            this.pBoxUp.Name = "pBoxUp";
            this.pBoxUp.Size = new System.Drawing.Size(16, 16);
            this.pBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxUp.TabIndex = 4;
            this.pBoxUp.TabStop = false;
            this.pBoxUp.Click += new System.EventHandler(this.pBoxUp_Click);
            // 
            // pBoxEdit
            // 
            this.pBoxEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxEdit.Image = global::XScenery.Properties.Resources.edit;
            this.pBoxEdit.Location = new System.Drawing.Point(587, 5);
            this.pBoxEdit.Name = "pBoxEdit";
            this.pBoxEdit.Size = new System.Drawing.Size(15, 16);
            this.pBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBoxEdit.TabIndex = 2;
            this.pBoxEdit.TabStop = false;
            this.pBoxEdit.Click += new System.EventHandler(this.pBoxEdit_Click);
            // 
            // SceneryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBoxDown);
            this.Controls.Add(this.pBoxUp);
            this.Controls.Add(this.pBoxEdit);
            this.Controls.Add(this.txBoxScenery);
            this.Controls.Add(this.ckBoxScenery);
            this.Name = "SceneryControl";
            this.Size = new System.Drawing.Size(663, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBoxScenery;
        private System.Windows.Forms.TextBox txBoxScenery;
        private System.Windows.Forms.PictureBox pBoxEdit;
        private System.Windows.Forms.PictureBox pBoxUp;
        private System.Windows.Forms.PictureBox pBoxDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

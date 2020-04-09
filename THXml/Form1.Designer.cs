using System.Windows.Forms;

namespace THXml
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prkid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.prktxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loaddata = new System.Windows.Forms.Button();
            this.xoadata = new System.Windows.Forms.Button();
            this.suadata = new System.Windows.Forms.Button();
            this.themdata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prkid,
            this.id,
            this.name,
            this.add});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(210, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // prkid
            // 
            this.prkid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prkid.HeaderText = "PrkID";
            this.prkid.MinimumWidth = 6;
            this.prkid.Name = "prkid";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.add.HeaderText = "Address";
            this.add.MinimumWidth = 6;
            this.add.Name = "add";
            // 
            // idtxt
            // 
            this.idtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idtxt.Location = new System.Drawing.Point(462, 103);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(277, 22);
            this.idtxt.TabIndex = 1;
            // 
            // addtxt
            // 
            this.addtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addtxt.Location = new System.Drawing.Point(923, 179);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(283, 22);
            this.addtxt.TabIndex = 2;
            // 
            // phonetxt
            // 
            this.phonetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phonetxt.Location = new System.Drawing.Point(923, 98);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(283, 22);
            this.phonetxt.TabIndex = 3;
            // 
            // emailtxt
            // 
            this.emailtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailtxt.Location = new System.Drawing.Point(923, 32);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(283, 22);
            this.emailtxt.TabIndex = 4;
            // 
            // nametxt
            // 
            this.nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametxt.Location = new System.Drawing.Point(462, 179);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(277, 22);
            this.nametxt.TabIndex = 5;
            // 
            // prktxt
            // 
            this.prktxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prktxt.Location = new System.Drawing.Point(462, 37);
            this.prktxt.Name = "prktxt";
            this.prktxt.Size = new System.Drawing.Size(277, 22);
            this.prktxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "PrkID";
            // 
            // loaddata
            // 
            this.loaddata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loaddata.Location = new System.Drawing.Point(103, 85);
            this.loaddata.Name = "loaddata";
            this.loaddata.Size = new System.Drawing.Size(126, 59);
            this.loaddata.TabIndex = 13;
            this.loaddata.Text = "Load File";
            this.loaddata.UseVisualStyleBackColor = true;
            this.loaddata.Click += new System.EventHandler(this.loaddata_Click);
            // 
            // xoadata
            // 
            this.xoadata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoadata.Location = new System.Drawing.Point(44, 454);
            this.xoadata.Name = "xoadata";
            this.xoadata.Size = new System.Drawing.Size(117, 59);
            this.xoadata.TabIndex = 15;
            this.xoadata.Text = "Xóa";
            this.xoadata.UseVisualStyleBackColor = true;
            this.xoadata.Click += new System.EventHandler(this.xoadata_Click);
            // 
            // suadata
            // 
            this.suadata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.suadata.Location = new System.Drawing.Point(44, 353);
            this.suadata.Name = "suadata";
            this.suadata.Size = new System.Drawing.Size(117, 58);
            this.suadata.TabIndex = 16;
            this.suadata.Text = "Sửa";
            this.suadata.UseVisualStyleBackColor = true;
            this.suadata.Click += new System.EventHandler(this.suadata_Click);
            // 
            // themdata
            // 
            this.themdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.themdata.Location = new System.Drawing.Point(44, 246);
            this.themdata.Name = "themdata";
            this.themdata.Size = new System.Drawing.Size(117, 60);
            this.themdata.TabIndex = 17;
            this.themdata.Text = "Thêm";
            this.themdata.UseVisualStyleBackColor = true;
            this.themdata.Click += new System.EventHandler(this.themdata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 550);
            this.Controls.Add(this.themdata);
            this.Controls.Add(this.suadata);
            this.Controls.Add(this.xoadata);
            this.Controls.Add(this.loaddata);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prktxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.addtxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox prktxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loaddata;
        private System.Windows.Forms.Button xoadata;
        private System.Windows.Forms.Button suadata;
        private System.Windows.Forms.Button themdata;
        private DataGridViewTextBoxColumn prkid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn add;

        public Button Loaddata { get => this.loaddata; set => this.loaddata = value; }
    }
}


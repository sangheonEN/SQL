namespace Oracle_Class
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.uiPieChart1 = new Sunny.UI.UIPieChart();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiButton_select = new Sunny.UI.UIButton();
            this.uiButton_insert = new Sunny.UI.UIButton();
            this.uiButton_drop = new Sunny.UI.UIButton();
            this.uiButton_create = new Sunny.UI.UIButton();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackgroundImage = global::Oracle_Class.Properties.Resources.images;
            this.cxFlatPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cxFlatPictureBox1.Image = global::Oracle_Class.Properties.Resources.images;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(3, 0);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(1184, 549);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 1;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiBarChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiBarChart1.Location = new System.Drawing.Point(766, 21);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.Option = null;
            this.uiBarChart1.Size = new System.Drawing.Size(410, 178);
            this.uiBarChart1.TabIndex = 3;
            this.uiBarChart1.Text = "uiBarChart1";
            // 
            // uiPieChart1
            // 
            this.uiPieChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiPieChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPieChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiPieChart1.Location = new System.Drawing.Point(766, 205);
            this.uiPieChart1.Name = "uiPieChart1";
            this.uiPieChart1.Option = null;
            this.uiPieChart1.Size = new System.Drawing.Size(410, 276);
            this.uiPieChart1.TabIndex = 7;
            this.uiPieChart1.Text = "uiPieChart1";
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(-4, 62);
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1187, 589);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cxFlatPictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1187, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.uiLabel1);
            this.tabPage2.Controls.Add(this.uiDataGridView1);
            this.tabPage2.Controls.Add(this.uiButton_create);
            this.tabPage2.Controls.Add(this.uiButton_drop);
            this.tabPage2.Controls.Add(this.uiButton_insert);
            this.tabPage2.Controls.Add(this.uiButton_select);
            this.tabPage2.Controls.Add(this.uiPieChart1);
            this.tabPage2.Controls.Add(this.uiBarChart1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1187, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            // 
            // uiButton_select
            // 
            this.uiButton_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_select.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_select.Location = new System.Drawing.Point(533, 194);
            this.uiButton_select.Name = "uiButton_select";
            this.uiButton_select.Size = new System.Drawing.Size(214, 35);
            this.uiButton_select.TabIndex = 8;
            this.uiButton_select.Text = "Select";
            // 
            // uiButton_insert
            // 
            this.uiButton_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_insert.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_insert.Location = new System.Drawing.Point(533, 248);
            this.uiButton_insert.Name = "uiButton_insert";
            this.uiButton_insert.Size = new System.Drawing.Size(214, 35);
            this.uiButton_insert.TabIndex = 9;
            this.uiButton_insert.Text = "Insert";
            // 
            // uiButton_drop
            // 
            this.uiButton_drop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_drop.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_drop.Location = new System.Drawing.Point(533, 136);
            this.uiButton_drop.Name = "uiButton_drop";
            this.uiButton_drop.Size = new System.Drawing.Size(214, 35);
            this.uiButton_drop.TabIndex = 10;
            this.uiButton_drop.Text = "Drop";
            // 
            // uiButton_create
            // 
            this.uiButton_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton_create.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton_create.Location = new System.Drawing.Point(533, 80);
            this.uiButton_create.Name = "uiButton_create";
            this.uiButton_create.Size = new System.Drawing.Size(214, 35);
            this.uiButton_create.TabIndex = 11;
            this.uiButton_create.Text = "Create";
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(16, 80);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(498, 378);
            this.uiDataGridView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDataGridView1.TabIndex = 12;
            this.uiDataGridView1.TagString = null;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(16, 46);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(51, 21);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "Table";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 640);
            this.Controls.Add(this.uiTabControl1);
            this.Name = "Form1";
            this.Text = "MES";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UIPieChart uiPieChart1;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton uiButton_select;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton uiButton_create;
        private Sunny.UI.UIButton uiButton_drop;
        private Sunny.UI.UIButton uiButton_insert;
    }
}


namespace _20200824_student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_select = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.comboBox_grade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_sql_select_insert = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(493, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(542, 25);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(155, 63);
            this.button_select.TabIndex = 1;
            this.button_select.Text = "select_gridview에서나오게";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(542, 194);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(155, 63);
            this.button_insert.TabIndex = 2;
            this.button_insert.Text = "insert_지정된인덱스로 추가";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(88, 345);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(88, 384);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(100, 21);
            this.textBox_age.TabIndex = 4;
            // 
            // comboBox_grade
            // 
            this.comboBox_grade.FormattingEnabled = true;
            this.comboBox_grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_grade.Location = new System.Drawing.Point(276, 346);
            this.comboBox_grade.Name = "comboBox_grade";
            this.comboBox_grade.Size = new System.Drawing.Size(121, 20);
            this.comboBox_grade.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "학년";
            // 
            // button_sql_select_insert
            // 
            this.button_sql_select_insert.Location = new System.Drawing.Point(542, 108);
            this.button_sql_select_insert.Name = "button_sql_select_insert";
            this.button_sql_select_insert.Size = new System.Drawing.Size(155, 63);
            this.button_sql_select_insert.TabIndex = 9;
            this.button_sql_select_insert.Text = "max인덱스_추가하면서 insert";
            this.button_sql_select_insert.UseVisualStyleBackColor = true;
            this.button_sql_select_insert.Click += new System.EventHandler(this.button_sql_select_insert_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(542, 278);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(155, 51);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(542, 345);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(155, 51);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_sql_select_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_grade);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.ComboBox comboBox_grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_sql_select_insert;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
    }
}


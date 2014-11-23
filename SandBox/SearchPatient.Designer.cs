namespace SandBox
{
    partial class search_Patient
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
            this.search_pat_name = new System.Windows.Forms.TextBox();
            this.search_pat_age = new System.Windows.Forms.TextBox();
            this.search_pat_sex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search_pat = new System.Windows.Forms.Button();
            this.patListview = new System.Windows.Forms.ListBox();
            this.btn_select_pat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search_pat_name
            // 
            this.search_pat_name.Location = new System.Drawing.Point(276, 45);
            this.search_pat_name.Name = "search_pat_name";
            this.search_pat_name.Size = new System.Drawing.Size(100, 21);
            this.search_pat_name.TabIndex = 0;
            // 
            // search_pat_age
            // 
            this.search_pat_age.Location = new System.Drawing.Point(276, 97);
            this.search_pat_age.Name = "search_pat_age";
            this.search_pat_age.Size = new System.Drawing.Size(100, 21);
            this.search_pat_age.TabIndex = 1;
            // 
            // search_pat_sex
            // 
            this.search_pat_sex.Location = new System.Drawing.Point(276, 151);
            this.search_pat_sex.Name = "search_pat_sex";
            this.search_pat_sex.Size = new System.Drawing.Size(100, 21);
            this.search_pat_sex.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "성별";
            // 
            // btn_search_pat
            // 
            this.btn_search_pat.Location = new System.Drawing.Point(251, 203);
            this.btn_search_pat.Name = "btn_search_pat";
            this.btn_search_pat.Size = new System.Drawing.Size(75, 23);
            this.btn_search_pat.TabIndex = 6;
            this.btn_search_pat.Text = "찾기";
            this.btn_search_pat.UseVisualStyleBackColor = true;
            this.btn_search_pat.Click += new System.EventHandler(this.btn_search_pat_Click);
            // 
            // patListview
            // 
            this.patListview.FormattingEnabled = true;
            this.patListview.ItemHeight = 12;
            this.patListview.Location = new System.Drawing.Point(178, 263);
            this.patListview.Name = "patListview";
            this.patListview.Size = new System.Drawing.Size(238, 64);
            this.patListview.TabIndex = 7;
            // 
            // btn_select_pat
            // 
            this.btn_select_pat.Location = new System.Drawing.Point(251, 334);
            this.btn_select_pat.Name = "btn_select_pat";
            this.btn_select_pat.Size = new System.Drawing.Size(75, 23);
            this.btn_select_pat.TabIndex = 8;
            this.btn_select_pat.Text = "선택";
            this.btn_select_pat.UseVisualStyleBackColor = true;
            this.btn_select_pat.Click += new System.EventHandler(this.btn_select_pat_Click);
            // 
            // search_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 369);
            this.Controls.Add(this.btn_select_pat);
            this.Controls.Add(this.patListview);
            this.Controls.Add(this.btn_search_pat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_pat_sex);
            this.Controls.Add(this.search_pat_age);
            this.Controls.Add(this.search_pat_name);
            this.Name = "search_Patient";
            this.Text = "Search Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_pat_name;
        private System.Windows.Forms.TextBox search_pat_age;
        private System.Windows.Forms.TextBox search_pat_sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search_pat;
        private System.Windows.Forms.ListBox patListview;
        private System.Windows.Forms.Button btn_select_pat;
    }
}
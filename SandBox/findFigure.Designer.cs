namespace SandBox
{
    partial class findFigure
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_finfig_sec = new System.Windows.Forms.ComboBox();
            this.comboBox_finfig_div = new System.Windows.Forms.ComboBox();
            this.comboBox_finfig_cate = new System.Windows.Forms.ComboBox();
            this.btn_search_fig = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.btn_select_fig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "소분류";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "중분류";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "대분류";
            // 
            // comboBox_finfig_sec
            // 
            this.comboBox_finfig_sec.FormattingEnabled = true;
            this.comboBox_finfig_sec.Items.AddRange(new object[] {
            "친구",
            "부부",
            "가족",
            "축구",
            "야구",
            "학생",
            "곰",
            "사자",
            "코끼리",
            "파리",
            "매미",
            "아파트",
            "개인주택",
            "초가집",
            "소방서",
            "경찰서",
            "학교",
            "경복궁",
            "스포츠카",
            "여객선",
            "나무배",
            "거북선",
            "제우스",
            "헤라클래스",
            "인어공주",
            "소파",
            "침대",
            "낫",
            "도끼",
            "컵",
            "밥그릇",
            "국그릇",
            "전자렌지",
            "세탁기",
            "텔레비전",
            "파란불",
            "빨간불",
            "주사기",
            "링거",
            "총",
            "대포",
            "장갑차"});
            this.comboBox_finfig_sec.Location = new System.Drawing.Point(269, 46);
            this.comboBox_finfig_sec.Name = "comboBox_finfig_sec";
            this.comboBox_finfig_sec.Size = new System.Drawing.Size(121, 20);
            this.comboBox_finfig_sec.TabIndex = 36;
            // 
            // comboBox_finfig_div
            // 
            this.comboBox_finfig_div.FormattingEnabled = true;
            this.comboBox_finfig_div.Items.AddRange(new object[] {
            "역사적인물",
            "취미",
            "직업",
            "관계",
            "스포츠",
            "인생의시기형상",
            "수중동물",
            "유사이전동물",
            "실제하는동물",
            "동물원동물",
            "농장동물",
            "곤충",
            "집종류",
            "종교적건물",
            "공공건물",
            "역사적건물",
            "나뭇잎",
            "조개껍질",
            "비행기",
            "자동차",
            "선박",
            "십자가",
            "예수탄생장면",
            "천사",
            "성경책",
            "해골",
            "부처상",
            "요술",
            "고대그리스 성지의 것",
            "피라미드",
            "신화인물",
            "문",
            "울타리",
            "기차선로",
            "장애물 표지판",
            "마술적인것",
            "용",
            "유니콘",
            "반인반마",
            "괴물",
            "캐릭터",
            "가구",
            "농기",
            "그릇류",
            "가전제품",
            "죽은것",
            "산것",
            "해",
            "달",
            "별",
            "무지개",
            "구름",
            "동굴",
            "터널",
            "화산",
            "불",
            "탑",
            "보석상자",
            "묘비",
            "눈사람",
            "술",
            "병원용품",
            "무기"});
            this.comboBox_finfig_div.Location = new System.Drawing.Point(141, 46);
            this.comboBox_finfig_div.Name = "comboBox_finfig_div";
            this.comboBox_finfig_div.Size = new System.Drawing.Size(121, 20);
            this.comboBox_finfig_div.TabIndex = 35;
            // 
            // comboBox_finfig_cate
            // 
            this.comboBox_finfig_cate.FormattingEnabled = true;
            this.comboBox_finfig_cate.Items.AddRange(new object[] {
            "인간과 관련된 물건",
            "동물",
            "건물",
            "자연물",
            "운송수단",
            "초자연적인것",
            "울타리,표지판",
            "환상적인것",
            "가정용품",
            "초목",
            "조경과 전시물",
            "기타품"});
            this.comboBox_finfig_cate.Location = new System.Drawing.Point(13, 47);
            this.comboBox_finfig_cate.Name = "comboBox_finfig_cate";
            this.comboBox_finfig_cate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_finfig_cate.TabIndex = 34;
            // 
            // btn_search_fig
            // 
            this.btn_search_fig.Location = new System.Drawing.Point(419, 43);
            this.btn_search_fig.Name = "btn_search_fig";
            this.btn_search_fig.Size = new System.Drawing.Size(75, 23);
            this.btn_search_fig.TabIndex = 41;
            this.btn_search_fig.Text = "검색";
            this.btn_search_fig.UseVisualStyleBackColor = true;
            this.btn_search_fig.Click += new System.EventHandler(this.btn_search_fig_Click);
            // 
            // listView1
            // 
            this.listView1.FormattingEnabled = true;
            this.listView1.ItemHeight = 12;
            this.listView1.Location = new System.Drawing.Point(54, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 28);
            this.listView1.TabIndex = 42;
            // 
            // btn_select_fig
            // 
            this.btn_select_fig.Location = new System.Drawing.Point(389, 106);
            this.btn_select_fig.Name = "btn_select_fig";
            this.btn_select_fig.Size = new System.Drawing.Size(90, 23);
            this.btn_select_fig.TabIndex = 43;
            this.btn_select_fig.Text = "피규어 선택";
            this.btn_select_fig.UseVisualStyleBackColor = true;
            this.btn_select_fig.Click += new System.EventHandler(this.btn_select_fig_Click);
            // 
            // findFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 202);
            this.Controls.Add(this.btn_select_fig);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_search_fig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_finfig_sec);
            this.Controls.Add(this.comboBox_finfig_div);
            this.Controls.Add(this.comboBox_finfig_cate);
            this.Name = "findFigure";
            this.Text = "findFigure";
            this.Load += new System.EventHandler(this.findFigure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_finfig_sec;
        private System.Windows.Forms.ComboBox comboBox_finfig_div;
        private System.Windows.Forms.ComboBox comboBox_finfig_cate;
        private System.Windows.Forms.Button btn_search_fig;
        private System.Windows.Forms.ListBox listView1;
        private System.Windows.Forms.Button btn_select_fig;
    }
}
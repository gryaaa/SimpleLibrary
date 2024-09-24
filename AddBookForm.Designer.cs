namespace LibraryPractice
{
    partial class AddBookForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tagsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.YearLabel = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.pageCount = new System.Windows.Forms.TextBox();
            this.tagsBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tagsPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.06047F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.93953F));
            this.tableLayoutPanel1.Controls.Add(this.author, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.name, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.19802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 395);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tagsPanel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.17949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.82051F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 311);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Теги";
            // 
            // tagsPanel
            // 
            this.tagsPanel.Controls.Add(this.tagsBox);
            this.tagsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagsPanel.Location = new System.Drawing.Point(3, 40);
            this.tagsPanel.Name = "tagsPanel";
            this.tagsPanel.Size = new System.Drawing.Size(329, 268);
            this.tagsPanel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.YearLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelGenre, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.year, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.genre, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pageCount, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.81395F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.18605F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(261, 311);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YearLabel.Location = new System.Drawing.Point(3, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(124, 106);
            this.YearLabel.TabIndex = 2;
            this.YearLabel.Text = "Год";
            this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGenre.Location = new System.Drawing.Point(3, 106);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(124, 83);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Жанр";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Количество страниц";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(3, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 23);
            this.name.TabIndex = 4;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(270, 3);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 23);
            this.author.TabIndex = 5;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(133, 3);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 23);
            this.year.TabIndex = 5;
            // 
            // genre
            // 
            this.genre.Location = new System.Drawing.Point(133, 109);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 23);
            this.genre.TabIndex = 6;
            // 
            // pageCount
            // 
            this.pageCount.Location = new System.Drawing.Point(133, 192);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(100, 23);
            this.pageCount.TabIndex = 7;
            // 
            // tagsBox
            // 
            this.tagsBox.Location = new System.Drawing.Point(3, 3);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(302, 186);
            this.tagsBox.TabIndex = 0;
            this.tagsBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tagsPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel tagsPanel;
        
        private TableLayoutPanel tableLayoutPanel3;
        private Label YearLabel;
        private Label labelGenre;
        private Label label6;
        private TextBox author;
        private RichTextBox tagsBox;
        private TextBox year;
        private TextBox genre;
        private TextBox pageCount;
        private TextBox name;
        private Button button1;
    }
}
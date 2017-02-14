namespace Grabber
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultBox = new System.Windows.Forms.CheckedListBox();
            this.collections = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logs = new System.Windows.Forms.ListBox();
            this.getCollection = new System.Windows.Forms.Button();
            this.mediaType = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.rows = new System.Windows.Forms.TextBox();
            this.startProcesss = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.RichTextBox();
            this.startDownload = new System.Windows.Forms.Button();
            this.stopDownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.currentPosition = new System.Windows.Forms.Label();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.CheckOnClick = true;
            this.resultBox.FormattingEnabled = true;
            this.resultBox.Location = new System.Drawing.Point(288, 28);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(262, 439);
            this.resultBox.TabIndex = 1;
            this.resultBox.ThreeDCheckBoxes = true;
            this.resultBox.SelectedIndexChanged += new System.EventHandler(this.resultBox_SelectedIndexChanged);
            this.resultBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultBox_MouseDoubleClick);
            // 
            // collections
            // 
            this.collections.FormattingEnabled = true;
            this.collections.Location = new System.Drawing.Point(12, 54);
            this.collections.Name = "collections";
            this.collections.Size = new System.Drawing.Size(270, 420);
            this.collections.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Archive.org Collections:";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(12, 542);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(623, 20);
            this.query.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result Query:";
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.Location = new System.Drawing.Point(556, 293);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(374, 173);
            this.logs.TabIndex = 6;
            // 
            // getCollection
            // 
            this.getCollection.Location = new System.Drawing.Point(141, 509);
            this.getCollection.Name = "getCollection";
            this.getCollection.Size = new System.Drawing.Size(141, 23);
            this.getCollection.TabIndex = 7;
            this.getCollection.Text = "Prepare Query";
            this.getCollection.UseVisualStyleBackColor = true;
            this.getCollection.Click += new System.EventHandler(this.getCollection_Click);
            // 
            // mediaType
            // 
            this.mediaType.FormattingEnabled = true;
            this.mediaType.Items.AddRange(new object[] {
            "All mediatypes",
            "audio",
            "collection",
            "data",
            "image",
            "movies",
            "texts",
            "web"});
            this.mediaType.Location = new System.Drawing.Point(13, 511);
            this.mediaType.Name = "mediaType";
            this.mediaType.Size = new System.Drawing.Size(82, 21);
            this.mediaType.TabIndex = 10;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 29);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(269, 20);
            this.searchBox.TabIndex = 11;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(101, 511);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(35, 20);
            this.rows.TabIndex = 12;
            this.rows.Text = "15";
            // 
            // startProcesss
            // 
            this.startProcesss.Enabled = false;
            this.startProcesss.Location = new System.Drawing.Point(650, 540);
            this.startProcesss.Name = "startProcesss";
            this.startProcesss.Size = new System.Drawing.Size(75, 23);
            this.startProcesss.TabIndex = 13;
            this.startProcesss.Text = "Start";
            this.startProcesss.UseVisualStyleBackColor = true;
            this.startProcesss.Click += new System.EventHandler(this.startProcesss_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(556, 29);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(374, 258);
            this.infoBox.TabIndex = 14;
            this.infoBox.Text = "";
            // 
            // startDownload
            // 
            this.startDownload.Location = new System.Drawing.Point(448, 473);
            this.startDownload.Name = "startDownload";
            this.startDownload.Size = new System.Drawing.Size(99, 23);
            this.startDownload.TabIndex = 15;
            this.startDownload.Text = "Start Download";
            this.startDownload.UseVisualStyleBackColor = true;
            this.startDownload.Click += new System.EventHandler(this.startDownload_Click);
            // 
            // stopDownload
            // 
            this.stopDownload.Location = new System.Drawing.Point(448, 502);
            this.stopDownload.Name = "stopDownload";
            this.stopDownload.Size = new System.Drawing.Size(99, 23);
            this.stopDownload.TabIndex = 16;
            this.stopDownload.Text = "Stop Download";
            this.stopDownload.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(618, 484);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // currentPosition
            // 
            this.currentPosition.AutoSize = true;
            this.currentPosition.Location = new System.Drawing.Point(564, 491);
            this.currentPosition.Name = "currentPosition";
            this.currentPosition.Size = new System.Drawing.Size(30, 13);
            this.currentPosition.TabIndex = 18;
            this.currentPosition.Text = "0 / 0";
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(63, 484);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(219, 20);
            this.searchQuery.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "*Double click opens Url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 574);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.currentPosition);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stopDownload);
            this.Controls.Add(this.startDownload);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.startProcesss);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.mediaType);
            this.Controls.Add(this.getCollection);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.query);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.collections);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive.org Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox resultBox;
        private System.Windows.Forms.ListBox collections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.Button getCollection;
        private System.Windows.Forms.ComboBox mediaType;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox rows;
        private System.Windows.Forms.Button startProcesss;
        private System.Windows.Forms.RichTextBox infoBox;
        private System.Windows.Forms.Button startDownload;
        private System.Windows.Forms.Button stopDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label currentPosition;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


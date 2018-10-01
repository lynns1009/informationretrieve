namespace InformationRetrieval
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
            this.LoadSource = new System.Windows.Forms.Button();
            this.SaveIndex = new System.Windows.Forms.Button();
            this.CreateIndex = new System.Windows.Forms.Button();
            this.SourcePath = new System.Windows.Forms.Label();
            this.IndexPath = new System.Windows.Forms.Label();
            this.IndexingTime = new System.Windows.Forms.Label();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.SearchQueryButton = new System.Windows.Forms.Button();
            this.SearchingTimeLabel = new System.Windows.Forms.Label();
            this.ProcessedQuery = new System.Windows.Forms.Label();
            this.PreprocessCheckBox = new System.Windows.Forms.CheckBox();
            this.RetrievedPageNumber = new System.Windows.Forms.Button();
            this.DOCIDlabel = new System.Windows.Forms.Label();
            this.AUTHORlabel = new System.Windows.Forms.Label();
            this.TITLElabel = new System.Windows.Forms.Label();
            this.BIBLIOGRAPHYlabel = new System.Windows.Forms.Label();
            this.ABSTRACTLabel = new System.Windows.Forms.Label();
            this.ResultFileNameLabel = new System.Windows.Forms.Label();
            this.InsertIDLabel = new System.Windows.Forms.Label();
            this.SaveResultButton = new System.Windows.Forms.Button();
            this.DOCIDtextBox = new System.Windows.Forms.TextBox();
            this.AUTHORtextBox = new System.Windows.Forms.TextBox();
            this.TITLEtextBox = new System.Windows.Forms.TextBox();
            this.BIBLIOGRAPHYtextBox = new System.Windows.Forms.TextBox();
            this.ABSTRACTrichTextBox = new System.Windows.Forms.RichTextBox();
            this.ProcessedQueryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultFileNameTextBox = new System.Windows.Forms.TextBox();
            this.InsertIDTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.listview1 = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DocID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bibliography = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abstract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PageComboBox = new System.Windows.Forms.ComboBox();
            this.NumberOfRetrievedDoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadSource
            // 
            this.LoadSource.Location = new System.Drawing.Point(12, 12);
            this.LoadSource.Name = "LoadSource";
            this.LoadSource.Size = new System.Drawing.Size(106, 23);
            this.LoadSource.TabIndex = 0;
            this.LoadSource.Text = "Load Sources";
            this.LoadSource.UseVisualStyleBackColor = true;
            this.LoadSource.Click += new System.EventHandler(this.LoadSource_Click);
            // 
            // SaveIndex
            // 
            this.SaveIndex.Location = new System.Drawing.Point(12, 41);
            this.SaveIndex.Name = "SaveIndex";
            this.SaveIndex.Size = new System.Drawing.Size(106, 23);
            this.SaveIndex.TabIndex = 1;
            this.SaveIndex.Text = "Save Index";
            this.SaveIndex.UseVisualStyleBackColor = true;
            this.SaveIndex.Click += new System.EventHandler(this.SaveIndex_Click);
            // 
            // CreateIndex
            // 
            this.CreateIndex.Location = new System.Drawing.Point(12, 70);
            this.CreateIndex.Name = "CreateIndex";
            this.CreateIndex.Size = new System.Drawing.Size(106, 23);
            this.CreateIndex.TabIndex = 2;
            this.CreateIndex.Text = "Create Index";
            this.CreateIndex.UseVisualStyleBackColor = true;
            this.CreateIndex.Click += new System.EventHandler(this.CreateIndex_Click);
            // 
            // SourcePath
            // 
            this.SourcePath.AutoSize = true;
            this.SourcePath.Location = new System.Drawing.Point(141, 17);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(102, 13);
            this.SourcePath.TabIndex = 3;
            this.SourcePath.Text = "Please load sources";
            // 
            // IndexPath
            // 
            this.IndexPath.AutoSize = true;
            this.IndexPath.Location = new System.Drawing.Point(141, 46);
            this.IndexPath.Name = "IndexPath";
            this.IndexPath.Size = new System.Drawing.Size(144, 13);
            this.IndexPath.TabIndex = 4;
            this.IndexPath.Text = "Please select save dictionary";
            // 
            // IndexingTime
            // 
            this.IndexingTime.AutoSize = true;
            this.IndexingTime.Location = new System.Drawing.Point(141, 74);
            this.IndexingTime.Name = "IndexingTime";
            this.IndexingTime.Size = new System.Drawing.Size(73, 13);
            this.IndexingTime.TabIndex = 5;
            this.IndexingTime.Text = "Indexing Time";
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(12, 106);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(63, 13);
            this.QueryLabel.TabIndex = 6;
            this.QueryLabel.Text = "Enter Query";
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(88, 106);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(297, 20);
            this.QueryTextBox.TabIndex = 7;
            // 
            // SearchQueryButton
            // 
            this.SearchQueryButton.Location = new System.Drawing.Point(15, 144);
            this.SearchQueryButton.Name = "SearchQueryButton";
            this.SearchQueryButton.Size = new System.Drawing.Size(120, 23);
            this.SearchQueryButton.TabIndex = 8;
            this.SearchQueryButton.Text = "Search the Query";
            this.SearchQueryButton.UseVisualStyleBackColor = true;
            this.SearchQueryButton.Click += new System.EventHandler(this.SearchQueryButton_Click);
            // 
            // SearchingTimeLabel
            // 
            this.SearchingTimeLabel.AutoSize = true;
            this.SearchingTimeLabel.Location = new System.Drawing.Point(141, 149);
            this.SearchingTimeLabel.Name = "SearchingTimeLabel";
            this.SearchingTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.SearchingTimeLabel.TabIndex = 9;
            this.SearchingTimeLabel.Text = "Searching Time ...";
            // 
            // ProcessedQuery
            // 
            this.ProcessedQuery.AutoSize = true;
            this.ProcessedQuery.Location = new System.Drawing.Point(12, 187);
            this.ProcessedQuery.Name = "ProcessedQuery";
            this.ProcessedQuery.Size = new System.Drawing.Size(88, 13);
            this.ProcessedQuery.TabIndex = 10;
            this.ProcessedQuery.Text = "Processed Query";
            // 
            // PreprocessCheckBox
            // 
            this.PreprocessCheckBox.AutoSize = true;
            this.PreprocessCheckBox.Location = new System.Drawing.Point(185, 187);
            this.PreprocessCheckBox.Name = "PreprocessCheckBox";
            this.PreprocessCheckBox.Size = new System.Drawing.Size(103, 17);
            this.PreprocessCheckBox.TabIndex = 11;
            this.PreprocessCheckBox.Text = "Porter Stemming";
            this.PreprocessCheckBox.UseVisualStyleBackColor = true;
            // 
            // RetrievedPageNumber
            // 
            this.RetrievedPageNumber.Location = new System.Drawing.Point(12, 524);
            this.RetrievedPageNumber.Name = "RetrievedPageNumber";
            this.RetrievedPageNumber.Size = new System.Drawing.Size(88, 23);
            this.RetrievedPageNumber.TabIndex = 14;
            this.RetrievedPageNumber.Text = "Pages List";
            this.RetrievedPageNumber.UseVisualStyleBackColor = true;
            // 
            // DOCIDlabel
            // 
            this.DOCIDlabel.AutoSize = true;
            this.DOCIDlabel.Location = new System.Drawing.Point(517, 22);
            this.DOCIDlabel.Name = "DOCIDlabel";
            this.DOCIDlabel.Size = new System.Drawing.Size(44, 13);
            this.DOCIDlabel.TabIndex = 16;
            this.DOCIDlabel.Text = "DOC ID";
            // 
            // AUTHORlabel
            // 
            this.AUTHORlabel.AutoSize = true;
            this.AUTHORlabel.Location = new System.Drawing.Point(695, 22);
            this.AUTHORlabel.Name = "AUTHORlabel";
            this.AUTHORlabel.Size = new System.Drawing.Size(53, 13);
            this.AUTHORlabel.TabIndex = 17;
            this.AUTHORlabel.Text = "AUTHOR";
            // 
            // TITLElabel
            // 
            this.TITLElabel.AutoSize = true;
            this.TITLElabel.Location = new System.Drawing.Point(517, 67);
            this.TITLElabel.Name = "TITLElabel";
            this.TITLElabel.Size = new System.Drawing.Size(37, 13);
            this.TITLElabel.TabIndex = 18;
            this.TITLElabel.Text = "TITLE";
            // 
            // BIBLIOGRAPHYlabel
            // 
            this.BIBLIOGRAPHYlabel.AutoSize = true;
            this.BIBLIOGRAPHYlabel.Location = new System.Drawing.Point(517, 107);
            this.BIBLIOGRAPHYlabel.Name = "BIBLIOGRAPHYlabel";
            this.BIBLIOGRAPHYlabel.Size = new System.Drawing.Size(86, 13);
            this.BIBLIOGRAPHYlabel.TabIndex = 19;
            this.BIBLIOGRAPHYlabel.Text = "BIBLIOGRAPHY";
            // 
            // ABSTRACTLabel
            // 
            this.ABSTRACTLabel.AutoSize = true;
            this.ABSTRACTLabel.Location = new System.Drawing.Point(517, 177);
            this.ABSTRACTLabel.Name = "ABSTRACTLabel";
            this.ABSTRACTLabel.Size = new System.Drawing.Size(64, 13);
            this.ABSTRACTLabel.TabIndex = 20;
            this.ABSTRACTLabel.Text = "ABSTRACT";
            // 
            // ResultFileNameLabel
            // 
            this.ResultFileNameLabel.AutoSize = true;
            this.ResultFileNameLabel.Location = new System.Drawing.Point(493, 467);
            this.ResultFileNameLabel.Name = "ResultFileNameLabel";
            this.ResultFileNameLabel.Size = new System.Drawing.Size(135, 13);
            this.ResultFileNameLabel.TabIndex = 21;
            this.ResultFileNameLabel.Text = "Save as (Result File Name)";
            // 
            // InsertIDLabel
            // 
            this.InsertIDLabel.AutoSize = true;
            this.InsertIDLabel.Location = new System.Drawing.Point(493, 510);
            this.InsertIDLabel.Name = "InsertIDLabel";
            this.InsertIDLabel.Size = new System.Drawing.Size(35, 13);
            this.InsertIDLabel.TabIndex = 22;
            this.InsertIDLabel.Text = "Query";
            // 
            // SaveResultButton
            // 
            this.SaveResultButton.Location = new System.Drawing.Point(801, 542);
            this.SaveResultButton.Name = "SaveResultButton";
            this.SaveResultButton.Size = new System.Drawing.Size(75, 23);
            this.SaveResultButton.TabIndex = 23;
            this.SaveResultButton.Text = "Save";
            this.SaveResultButton.UseVisualStyleBackColor = true;
            this.SaveResultButton.Click += new System.EventHandler(this.SaveResultButton_Click);
            // 
            // DOCIDtextBox
            // 
            this.DOCIDtextBox.Location = new System.Drawing.Point(574, 22);
            this.DOCIDtextBox.Name = "DOCIDtextBox";
            this.DOCIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.DOCIDtextBox.TabIndex = 24;
            // 
            // AUTHORtextBox
            // 
            this.AUTHORtextBox.Location = new System.Drawing.Point(767, 22);
            this.AUTHORtextBox.Name = "AUTHORtextBox";
            this.AUTHORtextBox.Size = new System.Drawing.Size(100, 20);
            this.AUTHORtextBox.TabIndex = 25;
            // 
            // TITLEtextBox
            // 
            this.TITLEtextBox.Location = new System.Drawing.Point(574, 67);
            this.TITLEtextBox.Name = "TITLEtextBox";
            this.TITLEtextBox.Size = new System.Drawing.Size(290, 20);
            this.TITLEtextBox.TabIndex = 26;
            // 
            // BIBLIOGRAPHYtextBox
            // 
            this.BIBLIOGRAPHYtextBox.Location = new System.Drawing.Point(520, 136);
            this.BIBLIOGRAPHYtextBox.Name = "BIBLIOGRAPHYtextBox";
            this.BIBLIOGRAPHYtextBox.Size = new System.Drawing.Size(347, 20);
            this.BIBLIOGRAPHYtextBox.TabIndex = 27;
            // 
            // ABSTRACTrichTextBox
            // 
            this.ABSTRACTrichTextBox.Location = new System.Drawing.Point(515, 198);
            this.ABSTRACTrichTextBox.Name = "ABSTRACTrichTextBox";
            this.ABSTRACTrichTextBox.Size = new System.Drawing.Size(347, 246);
            this.ABSTRACTrichTextBox.TabIndex = 28;
            this.ABSTRACTrichTextBox.Text = "";
            // 
            // ProcessedQueryRichTextBox
            // 
            this.ProcessedQueryRichTextBox.Location = new System.Drawing.Point(15, 210);
            this.ProcessedQueryRichTextBox.Name = "ProcessedQueryRichTextBox";
            this.ProcessedQueryRichTextBox.Size = new System.Drawing.Size(370, 37);
            this.ProcessedQueryRichTextBox.TabIndex = 29;
            this.ProcessedQueryRichTextBox.Text = "";
            // 
            // ResultFileNameTextBox
            // 
            this.ResultFileNameTextBox.Location = new System.Drawing.Point(634, 464);
            this.ResultFileNameTextBox.Name = "ResultFileNameTextBox";
            this.ResultFileNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.ResultFileNameTextBox.TabIndex = 30;
            // 
            // InsertIDTextBox
            // 
            this.InsertIDTextBox.Location = new System.Drawing.Point(634, 507);
            this.InsertIDTextBox.Name = "InsertIDTextBox";
            this.InsertIDTextBox.Size = new System.Drawing.Size(177, 20);
            this.InsertIDTextBox.TabIndex = 31;
            // 
            // listview1
            // 
            this.listview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.DocID,
            this.Title,
            this.Author,
            this.Bibliography,
            this.Abstract});
            this.listview1.FullRowSelect = true;
            this.listview1.GridLines = true;
            this.listview1.Location = new System.Drawing.Point(15, 263);
            this.listview1.Name = "listview1";
            this.listview1.Size = new System.Drawing.Size(370, 207);
            this.listview1.TabIndex = 32;
            this.listview1.UseCompatibleStateImageBehavior = false;
            this.listview1.View = System.Windows.Forms.View.Details;
            this.listview1.SelectedIndexChanged += new System.EventHandler(this.listview1_SelectedIndexChanged_1);
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            this.Rank.Width = 44;
            // 
            // DocID
            // 
            this.DocID.Text = "DocID";
            this.DocID.Width = 45;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            // 
            // Author
            // 
            this.Author.Text = "Author";
            // 
            // Bibliography
            // 
            this.Bibliography.Text = "Bibliography";
            this.Bibliography.Width = 72;
            // 
            // Abstract
            // 
            this.Abstract.Text = "Abstract";
            this.Abstract.Width = 86;
            // 
            // PageComboBox
            // 
            this.PageComboBox.FormattingEnabled = true;
            this.PageComboBox.Location = new System.Drawing.Point(119, 526);
            this.PageComboBox.Name = "PageComboBox";
            this.PageComboBox.Size = new System.Drawing.Size(157, 21);
            this.PageComboBox.TabIndex = 33;
            this.PageComboBox.Text = "page 1";
            this.PageComboBox.SelectedIndexChanged += new System.EventHandler(this.PageComboBox_SelectedIndexChanged);
            // 
            // NumberOfRetrievedDoc
            // 
            this.NumberOfRetrievedDoc.AutoSize = true;
            this.NumberOfRetrievedDoc.Location = new System.Drawing.Point(12, 490);
            this.NumberOfRetrievedDoc.Name = "NumberOfRetrievedDoc";
            this.NumberOfRetrievedDoc.Size = new System.Drawing.Size(130, 13);
            this.NumberOfRetrievedDoc.TabIndex = 34;
            this.NumberOfRetrievedDoc.Text = "Number Of Retrieved Doc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 577);
            this.Controls.Add(this.NumberOfRetrievedDoc);
            this.Controls.Add(this.PageComboBox);
            this.Controls.Add(this.listview1);
            this.Controls.Add(this.InsertIDTextBox);
            this.Controls.Add(this.ResultFileNameTextBox);
            this.Controls.Add(this.ProcessedQueryRichTextBox);
            this.Controls.Add(this.ABSTRACTrichTextBox);
            this.Controls.Add(this.BIBLIOGRAPHYtextBox);
            this.Controls.Add(this.TITLEtextBox);
            this.Controls.Add(this.AUTHORtextBox);
            this.Controls.Add(this.DOCIDtextBox);
            this.Controls.Add(this.SaveResultButton);
            this.Controls.Add(this.InsertIDLabel);
            this.Controls.Add(this.ResultFileNameLabel);
            this.Controls.Add(this.ABSTRACTLabel);
            this.Controls.Add(this.BIBLIOGRAPHYlabel);
            this.Controls.Add(this.TITLElabel);
            this.Controls.Add(this.AUTHORlabel);
            this.Controls.Add(this.DOCIDlabel);
            this.Controls.Add(this.RetrievedPageNumber);
            this.Controls.Add(this.PreprocessCheckBox);
            this.Controls.Add(this.ProcessedQuery);
            this.Controls.Add(this.SearchingTimeLabel);
            this.Controls.Add(this.SearchQueryButton);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.IndexingTime);
            this.Controls.Add(this.IndexPath);
            this.Controls.Add(this.SourcePath);
            this.Controls.Add(this.CreateIndex);
            this.Controls.Add(this.SaveIndex);
            this.Controls.Add(this.LoadSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadSource;
        private System.Windows.Forms.Button SaveIndex;
        private System.Windows.Forms.Button CreateIndex;
        private System.Windows.Forms.Label SourcePath;
        private System.Windows.Forms.Label IndexPath;
        private System.Windows.Forms.Label IndexingTime;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button SearchQueryButton;
        private System.Windows.Forms.Label SearchingTimeLabel;
        private System.Windows.Forms.Label ProcessedQuery;
        private System.Windows.Forms.CheckBox PreprocessCheckBox;
        private System.Windows.Forms.Button RetrievedPageNumber;
        private System.Windows.Forms.Label DOCIDlabel;
        private System.Windows.Forms.Label AUTHORlabel;
        private System.Windows.Forms.Label TITLElabel;
        private System.Windows.Forms.Label BIBLIOGRAPHYlabel;
        private System.Windows.Forms.Label ABSTRACTLabel;
        private System.Windows.Forms.Label ResultFileNameLabel;
        private System.Windows.Forms.Label InsertIDLabel;
        private System.Windows.Forms.Button SaveResultButton;
        private System.Windows.Forms.TextBox DOCIDtextBox;
        private System.Windows.Forms.TextBox AUTHORtextBox;
        private System.Windows.Forms.TextBox TITLEtextBox;
        private System.Windows.Forms.TextBox BIBLIOGRAPHYtextBox;
        private System.Windows.Forms.RichTextBox ABSTRACTrichTextBox;
        private System.Windows.Forms.RichTextBox ProcessedQueryRichTextBox;
        private System.Windows.Forms.TextBox ResultFileNameTextBox;
        private System.Windows.Forms.TextBox InsertIDTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ListView listview1;
        private System.Windows.Forms.ComboBox PageComboBox;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader DocID;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Bibliography;
        private System.Windows.Forms.ColumnHeader Abstract;
        private System.Windows.Forms.Label NumberOfRetrievedDoc;
    }
}


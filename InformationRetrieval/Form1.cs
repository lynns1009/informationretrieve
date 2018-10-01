using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationRetrieval
{
    public partial class Form1 : Form
    {
        List<SourceDocument> sourceDocumentCollection;
        CustomSimilarity customSimilarity;

        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";
        const string ID_FN = "ID";
        const string TITLE_FN = "Title";

        Boolean indexCreated;
        Boolean searchDone;

        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        Lucene.Net.Search.IndexSearcher searcher;
        Lucene.Net.QueryParsers.QueryParser parser;
        TextAnalyser textAnalyser;

        public string[] searchResultList;
        public string[] preprocessedQueryList;

        TopDocs results;
        int maxDisplay = 10;

        public Form1()
        {
            InitializeComponent();
            searchResultList = new string[1];
            textAnalyser = new TextAnalyser();
            indexCreated = false;
            searchDone = false;
            customSimilarity = new CustomSimilarity();
        }
        public void CreateNewIndex(string path)
        {
            luceneIndexDirectory = FSDirectory.Open(path);
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);

            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
            writer.SetSimilarity(customSimilarity);
            indexCreated = false;
        }

        public void IndexText(string titleText, string text, string id)
        {
            Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field title = new Field(TITLE_FN, titleText, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
            Lucene.Net.Documents.Field idField = new Field("id", id, Field.Store.YES, Field.Index.NOT_ANALYZED);
            Lucene.Net.Documents.Document doc = new Document();
            doc.Add(field);
            doc.Add(title);
            doc.Add(idField);
            writer.AddDocument(doc);
        }

        public void AddIndex()
        {
            foreach (SourceDocument var in sourceDocumentCollection)
            {
                IndexText(var.Title, var.ToString(), var.DocId.ToString());
            }
        }

        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }

        public void CreateAnalyser()
        {
            analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(VERSION);
        }

        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
            searcher.Similarity = customSimilarity;
        }

        public void CreateParser()
        {
            parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
        }

        public void CleanUpSearch()
        {
            searcher.Dispose();
        }

        public TopDocs SearchIndex(string querytext)
        {
            try
            {
                querytext = querytext.ToLower();
                Query query = parser.Parse(querytext);
                TopDocs results = searcher.Search(query, 1400);
                ProcessedQueryRichTextBox.Text = query.ToString();
                NumberOfRetrievedDoc.Text = "Number Of Retrieved Doc: " + (results.TotalHits).ToString();
                int i = 0;
                int rank = 0;
                foreach (ScoreDoc scoreDoc in results.ScoreDocs)
                {
                    rank++;
                    Array.Resize<string>(ref searchResultList, i + 1);
                    Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                    string myFieldValue = doc.Get(TEXT_FN).ToString();
                    searchResultList[i] = "\t" + scoreDoc.Doc + "\t" + rank + "\t" + scoreDoc.Score + "\t";
                    i++;
                }
                return results;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incompatible Query. Please enter a new query");
                ex.ToString();
            }
            return null;
        }


        //load all documents
        public void LoadFiles(string path)
        {
            FileFunction fileFunction = new FileFunction();
            sourceDocumentCollection = fileFunction.ProcessAllDoc(path);
        }

        public SourceDocument FindDocument(string id)
        {
            int docId = int.Parse(id);
            foreach (SourceDocument sourceDocument in sourceDocumentCollection)
            {
                if (sourceDocument.DocId == docId)
                {
                    return sourceDocument;
                }
            }
            return null;
        }

        private void LoadSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            SourcePath.Text = folderBrowserDialog1.SelectedPath;
        }

      
        private void SaveIndex_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            IndexPath.Text = folderBrowserDialog2.SelectedPath;
        }

        private void CreateIndex_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            LoadFiles(SourcePath.Text);
            CreateNewIndex(IndexPath.Text);
            AddIndex();
            stopwatch.Stop();
            IndexingTime.Text = "Indexing takes " + stopwatch.ElapsedMilliseconds.ToString() + " milisecond";
            stopwatch.Reset();
            CleanUpIndexer();
            indexCreated = true;
        }

        public void DisplayResults(TopDocs results, int pagingIndex, int maxDisplay)
        {
            listview1.Items.Clear();
            int offset = pagingIndex * maxDisplay;
            int realDisplay = Math.Min(maxDisplay, results.ScoreDocs.Length - offset);
            int rank = offset;
            for (int j = offset; j < offset + realDisplay; j++)
            {
                ScoreDoc scoreDoc = results.ScoreDocs[j];
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                string id = doc.Get("id").ToString();
                SourceDocument sourceDocment = FindDocument(id);
                ListViewItem item = new ListViewItem(rank.ToString());
                item.SubItems.Add(sourceDocment.DocId.ToString());
                item.SubItems.Add(sourceDocment.Title);
                item.SubItems.Add(sourceDocment.Author);
                item.SubItems.Add(sourceDocment.Bibliography);
                item.SubItems.Add(sourceDocment.ArticleAbstract);
                listview1.Items.Add(item);
            }
        }

        public void UpdatePage(int numofPage)
        {
            for (int i = 1; i <= numofPage; i++)
            {
                PageComboBox.Items.Add(i);
            }
        }

        public void SearchFunction(String query)
        {

            if (PreprocessCheckBox.Checked)
            {
                preprocessedQueryList = textAnalyser.OutputTokens(QueryTextBox.Text);
            }
            else
            {
                preprocessedQueryList = new String[1];
                preprocessedQueryList[0] = QueryTextBox.Text;
            }

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            string finalQuery = "";
            foreach (string item in preprocessedQueryList)
            {
                finalQuery = finalQuery + item + " ";
            }
            QueryTextBox.Text = finalQuery;
            CreateSearcher();
            CreateParser();
            results = SearchIndex(QueryTextBox.Text);
            //calculating paging index................
            int numOfPage = (int)Math.Ceiling((double)results.ScoreDocs.Length / (double)maxDisplay);
            DisplayResults(results, 0, maxDisplay);
            stopwatch.Stop();
            SearchingTimeLabel.Text = "Searching takes " + stopwatch.ElapsedMilliseconds.ToString() + " milisecond";
            stopwatch.Reset();

            //update paging footer
            PageComboBox.Items.Clear();
            try
            {
                PageComboBox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                //   MessageBox.Show("Error Occured. Please Try again");
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < numOfPage; i++)
            {
                PageComboBox.Items.Add("Page " + (i + 1));
            }
        }

        private void SearchQueryButton_Click(object sender, EventArgs e)
        {
            if (indexCreated)
            {
                if (!(string.IsNullOrEmpty(QueryTextBox.Text)) && QueryTextBox.Text.Trim().Length > 0)
                {
                    SearchFunction(QueryTextBox.Text);
                    searchDone = true;
                }
                else
                {
                    MessageBox.Show("Please enter the query");
                }
            }
            else
            {
                MessageBox.Show("Create Index First");
            }
        }

        private void PageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayResults(results, PageComboBox.SelectedIndex, maxDisplay);
        }


        private void SaveResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchDone)
                {
                    if ((string.IsNullOrEmpty(ResultFileNameTextBox.Text)) || (string.IsNullOrEmpty(InsertIDTextBox.Text)))
                    {
                        MessageBox.Show("Enter FileName and Query first");
                    }
                    else
                    {
                        string fileName = ResultFileNameTextBox.Text + ".txt";
                        string ID_SavedFile = InsertIDTextBox.Text;
                        using (StreamWriter textWriter = new StreamWriter(fileName, true))
                        {
                            foreach (string var in searchResultList)
                            {
                                textWriter.Write(ID_SavedFile + "\t");
                                textWriter.Write(var);
                                textWriter.WriteLine();
                            }
                        }
                        MessageBox.Show("File Created");
                    }
                }
                else
                {
                    MessageBox.Show("Search Something First");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured.Please fill all fields and retry.");
                Console.WriteLine(ex.ToString());
            }
        }

        public void ProcessAndSearchTest(String query)
        {

            if (PreprocessCheckBox.Checked)
            {
                preprocessedQueryList = textAnalyser.OutputTokens(query);
            }
            else
            {
                preprocessedQueryList = new String[1];
                preprocessedQueryList[0] = QueryTextBox.Text;
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            string finalQuery = "";

            foreach (string item in preprocessedQueryList)
            {
                finalQuery = finalQuery + item + " ";
            }
            QueryTextBox.Text = finalQuery;

            CreateSearcher();
            CreateParser();

            results = SearchIndex(QueryTextBox.Text);
            //calculating paging index
            int numOfPage = (int)Math.Ceiling((double)results.ScoreDocs.Length / (double)maxDisplay);
            // DisplayResults(results, 0, maxDisplay);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            SearchingTimeLabel.Text = "Searching Time: " + elapsedMs.ToString() + " milisecond";

            //update paging footer
            PageComboBox.Items.Clear();
            try
            {
                PageComboBox.SelectedIndex = 1;

            }
            catch (Exception ex)
            {
                //   MessageBox.Show("Error Occured. Please Try again");
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < numOfPage; i++)
            {
                PageComboBox.Items.Add("Page " + (i + 1));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listview1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listview1.SelectedItems.Count > 0)
            {
                ListViewItem item = listview1.SelectedItems[0];
                DOCIDtextBox.Text = item.SubItems[1].Text;
                AUTHORtextBox.Text = item.SubItems[3].Text;
                TITLEtextBox.Text = item.SubItems[2].Text;
                BIBLIOGRAPHYtextBox.Text = item.SubItems[4].Text;
                ABSTRACTrichTextBox.Text = item.SubItems[5].Text;
            }
        }
    }
}

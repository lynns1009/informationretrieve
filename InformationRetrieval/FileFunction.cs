using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//this class is exculsively for processing source documents

namespace InformationRetrieval
{
    class FileFunction
    {
        //create a method to process one source file
        public SourceDocument ConvertScrDoc(string path)
        {
            try
            {
                SourceDocument sourceDocument;
                string docId;
                string title = "";
                string author = "";
                string bibliography = "";
                string articleAbstract = "";
                string[] lines = System.IO.File.ReadAllLines(path);
                int titleHead = 0, titleTail = 0;
                int authorHead = 0, authorTail = 0;
                int bibliographyHead = 0, bibliographyTail = 0;
                int articleAbstractHead = 0, articleAbstractTail = lines.Length - 1;
                

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith(".T"))
                    {
                        titleHead = i + 1;
                    }
                    else if (lines[i].StartsWith(".A"))
                    {
                        titleTail = i - 1;
                        authorHead = i + 1;
                    }
                    else if (lines[i].StartsWith(".B"))
                    {
                        authorTail = i - 1;
                        bibliographyHead = i + 1;
                    }
                    else if (lines[i].StartsWith(".W"))
                    {
                        bibliographyTail = i - 1;
                        articleAbstractHead = i + 1;
                    }
                }

                docId = lines[0].Remove(lines[0].IndexOf(".I"), 2);
                
                for (int i = titleHead; i <= titleTail; i++)
                {
                    title = title + lines[i];
                }
                
                for (int i = authorHead; i <= authorTail; i++)
                {
                    author = author + lines[i];
                }
                
                for (int i = bibliographyHead; i <= bibliographyTail; i++)
                {
                    bibliography = bibliography + lines[i];
                }
                
                for (int i = articleAbstractHead; i <= articleAbstractTail; i++)
                {
                    articleAbstract = articleAbstract + lines[i];
                }
                if (articleAbstract.Length > 1 && articleAbstract.IndexOf('.') > 0)
                {
                    int HeadIndex = title.Length;
                    int tailIndex = articleAbstract.Length - 1;
                    int length = tailIndex - HeadIndex + 1;
                    articleAbstract = articleAbstract.Substring(HeadIndex, length);
                }
                
                docId = docId.Trim();
                title = title.Trim();
                author = author.Trim();
                bibliography = bibliography.Trim();
                articleAbstract = articleAbstract.Trim();
                sourceDocument = new SourceDocument(Convert.ToInt32(docId), title, author, bibliography, articleAbstract);

                return sourceDocument;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new SourceDocument();
            }
        }

        //create a method to process all documents
        public List<SourceDocument> ProcessAllDoc(string path)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(path);
            SourceDocument sourceDocument;
            List<SourceDocument> sourceDocumentList = new List<SourceDocument>();
            foreach (string fileName in fileEntries)
            {
                sourceDocument = ConvertScrDoc(fileName);
                sourceDocumentList.Add(sourceDocument);
            }
            return sourceDocumentList;
        }

    }

}

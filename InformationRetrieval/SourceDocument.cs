using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//create a class as a template for 1400 source document
//each document will be this class's object
//it has 5 private data members and their properties
// this class + InfoNeededDoc class will be used by FileFunction class

namespace InformationRetrieval
{
    public class SourceDocument
    {
        int docId;
        string title;
        string author;
        string bibliography;
        string articleAbstract;

        //the real constructor needed later
        public SourceDocument(int docId, string title, string author, string bibliography, string articleAbstract)
        {
            this.docId = docId;
            this.title = title;
            this.author = author;
            this.bibliography = bibliography;
            this.articleAbstract = articleAbstract;
        }

        //always create a default constructor
        public SourceDocument()
        {
            this.docId = -99;
            this.title = "";
            this.author = "";
            this.bibliography = "";
            this.articleAbstract = "";
        }


        public int DocId
        {
            get
            {
                return docId;
            }

            set
            {
                docId = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Bibliography
        {
            get
            {
                return bibliography;
            }

            set
            {
                bibliography = value;
            }
        }

        public string ArticleAbstract
        {
            get
            {
                return articleAbstract;
            }

            set
            {
                articleAbstract = value;
            }
        }

        //always override ToString() method to display the object for UI/Debugging
        public override string ToString()
        {
            return Author + " " + Bibliography + " " + articleAbstract;           
        }
    }
}

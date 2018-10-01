using System;
using System.Collections.Generic;
using System.Linq;


namespace InformationRetrieval
{
    class TextAnalyser
    {
        PorterStemmerAlgorithm.PorterStemmer myStemmer;
        System.Collections.Generic.Dictionary<string, int> tokenCount;
        public string[] stopWords = {"a", "an", "and", "are", "as", "at", "be", "but", "by","for", "if", "in", "into", "is", "it","no", "not", "of", "on", "or", "such","that", "the", "their", "then", "there", "these","they", "this", "to", "was", "will", "with"}; 

        public TextAnalyser()
        {
            myStemmer = new PorterStemmerAlgorithm.PorterStemmer();
            tokenCount = new Dictionary<string,int>();
        }

        /// Convert the  given text into tokens
        /// split it into tokens according to whitespace and punctuation

        public string[] TokeniseString(string text)
        {
            char[] splitters = new char[] { ' ', '\t', '\'', '"', '-', '(', ')', ',', '’', '\n', ':', ';', '?', '.', '!' };
            return text.ToLower().Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        }

        /// Stem an array of tokens
        public string[] StemTokens(string[] tokens)
        {
            int numTokens = tokens.Count();
            string[] stems = new string[numTokens];
            for (int i = 0; i < numTokens; i++)
            {
                stems[i] = myStemmer.stemTerm(tokens[i]);
            }
            return stems;
        }

        /// Prints out tokens for a given text string
        public string[] OutputTokens(string str)
        {
            string[] tokens = TokeniseString(str);            
            string[] tokensnostop = this.StopWordFilter(tokens);
            return StemTokens(tokensnostop);
        }

        /// Resets the tokencount to 0
        public void ResetCount()
        {
            tokenCount.Clear();
        }

        /// Removes stopwords from an array of tokens
        public string[] StopWordFilter(string[] tokens)
        {
            int numTokens = tokens.Count();
            List<string> filteredTokens = new List<string>();
            for (int i = 0; i < numTokens; i++)
            {
                string token = tokens[i];
                if (!stopWords.Contains(token) && (token.Length > 2)) filteredTokens.Add(token);
            }
            return filteredTokens.ToArray<string>();
        }

      
    }
}

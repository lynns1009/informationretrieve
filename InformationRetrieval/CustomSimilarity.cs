using Lucene.Net.Search;
using System;


namespace InformationRetrieval
{
    public class CustomSimilarity : DefaultSimilarity
    {


        public override float Tf(float freq)
        {
            return (float)(System.Math.Sqrt(freq) * 0.5);
        }

        
        public override float LengthNorm(string fieldName, int numTerms)
        {
            if (fieldName.Equals("title"))
            {
                return (float)(0.1 * Math.Log(numTerms));
            }
            else
            {
                return base.LengthNorm(fieldName, numTerms);
            }
        }

    }

}

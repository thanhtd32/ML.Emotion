using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ML.Emotion.Common
{
    public static class PreProcessingData
    {

        public static string TextCleaning(this string source)
        {
            string result= source;
            result = result.NormalizeText();
            result = result.RemoveUnicodeCharacters();
            result = result.RemoveStopwords();
            result = result.PerformStemmingAndLemmatization();
            return result;
        }
        /// <summary>
        /// Normalizing text is the process of standardizing text so that, through NLP,
        /// computer models can better understand human input, with the end goal being to
        /// more effectively perform sentiment analysis and other types of analysis on your customer feedback.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string NormalizeText(this string source)
        {
            string result = source.ToLower();
            return result;
        }
        /// <summary>
        /// Punctuation, Emoji’s, URL’s and @’s confuse AI models because they are uniques signatures that either
        /// end up being translated unhelpfully into unicode (Smiley face becomes \u200c or similar), 
        /// or are unique (in the case of @’s and hyperlinks).
        ///Punctuation also creates noise and impedes NLP understanding because it relates to the tone of 
        ///the specific sentence, not necessarily the word it is attached to.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveUnicodeCharacters(this string source)
        {
            string result = source;
            result =Regex.Replace(result, @"[^\u0000-\u007F]", String.Empty);
            result = Regex.Replace(result, @"(@\[A-Za-z0-9]+)|([^0-9A-Za-z \t])|(\w+:\/\/\S+)|^rt|http.+?", String.Empty);
            
            return result;
        }
        /// <summary>
        /// With english, among many popular languages, stop words are common words within sentences that 
        /// do not add value and thus can be eliminated when cleaning for NLP prior to analysis.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string RemoveStopwords(this string source)
        {
            string[] arrStopWords = { "when", "a", "their", "wouldn't", "down", "of", "each", "for", "through", "with", "only", "ain", "own", "our", "out",
                "being", "at", "up", "we", "under", "these", "before", "isn't", "most", "o", "needn't", "ours", "too", "that'll", "her", "d", 
                "other", "haven", "it's", "doing", "his", "below", "after", "between", "why", "i", "she's", "mustn't", "should've", "aren't",
                "s", "there", "you've", "yourself", "ll", "should", "didn", "don't", "you're", "mightn't", "hers", "yourselves", "it", "because",
                "in", "didn't", "yours", "myself", "hasn't", "again", "you'll", "off", "if", "those", "so", "which", "does", "can", "shouldn", 
                "themselves", "now", "t", "this", "wouldn", "them", "into", "very", "to", "nor", "won", "you'd", "doesn", "you", "while", "shan",
                "did", "ourselves", "were", "she", "that", "where", "re", "more", "just", "mightn", "how", "and", " is ", "weren", "hasn", "ma",
                "until", "they", "won't", "having", "few", "wasn", "was", "m", "couldn", "above", "hadn", "during", "couldn't", "have", "then", 
                "whom", "same", "herself", "had", "himself", "on", "isn", "than", "who", "mustn", "shouldn't", "hadn't", "about", "over", "ve", 
                "has", "an", "doesn't", "once", "the", "y", "am", "your", "no", "are", "from", "needn", "its", "been", "further", "some", "haven't", 
                " as", "shan't", "wasn't", "all", "will", "itself", "he", "don", "such", "any", "but", "be", "here", "against", "me", "my",
                "weren't", "theirs", "do", "aren", "or", "both", "what", "by", "him","hey"};
            string result = source;
            string []arr=result.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (string word in arr)
            {
                if (arrStopWords.Contains(word) == false)
                {
                    sb.Append(word);
                    sb.Append(" ");
                }
            }
            return sb.ToString().Trim();
        }
        /// <summary>
        /// Stemming:
        /// the simpler of the two, groups words by their root stem. This allows us to recognize 
        /// that ‘jumping’ ‘jumps’ and ‘jumped’ are all rooted to the same verb (jump) and thus are referring
        /// to similar problems.
        /// Lemmatization:
        /// on the other hand, groups words based on root definition, and allows us 
        /// to differentiate between present, past, and indefinite.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string PerformStemmingAndLemmatization(this string source)
        {
            string result = source;

            return result;
        }
    }
}

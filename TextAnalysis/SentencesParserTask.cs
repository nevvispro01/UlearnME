using System.Collections.Generic;
using System;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var part = text.Split('.', '!', '?', ';', ':', '(', ')');
            var word = "";
            var k = 0;
            for (int i = 0; i < part.Length; i++)
            {
                word = SplittingIntoWords(part[i]);
                var part1 = word.Split(' ');
                if (part1[0] != "")
                {
                    for (int j = 0; j < part1.Length; j++)
                    {
                        sentencesList.Add(new List<string>());
                        sentencesList[k].Add(part1[j]);
                    }
                    k++;
                }
            }
            return sentencesList;
        }
        public static string SplittingIntoWords(string proposal)
        {
            var word = "";
            while ((proposal.Length > 1) && (char.IsLetter(proposal[0]) == false))
            {
                proposal = proposal.Remove(0, 1);
            }
            for (int i = 0; i < proposal.Length; i++)
            {
                if (char.IsLetter(proposal[i]))
                {
                    word += proposal[i];
                }
                else if (word.Length >= 1)
                {
                    if (word[word.Length - 1] != ' ')
                    {
                        word += ' ';
                    }
                }
            }

            return word;
        }
    }
}
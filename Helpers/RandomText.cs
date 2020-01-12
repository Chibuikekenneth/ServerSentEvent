using System;
using System.Text;

namespace sse_eventsource.Helpers
{
    //class for generating random Text
    public class RandomText
    {
        public static string GetRandomSentence(int wordCount)
        {
            string[] words = { "an", "automobile", "or", "motor", "car", "is", "a", "wheeled", "motor", "vehicle", "used", "for", "transporting", "passengers", "which", "also", "carries", "its", "own", "engine", "or" };

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < wordCount; i++)  
            {
                // Select a random word from the array
                builder.Append(words[new Random().Next(words.Length)]).Append(" ");
            }

            string sentence = builder.ToString().Trim() + ". ";
        
            // Set the first letter of the first word in the sentenece to uppercase
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

            builder = new StringBuilder();
            builder.Append(sentence);

            return builder.ToString();
        }
    }
}
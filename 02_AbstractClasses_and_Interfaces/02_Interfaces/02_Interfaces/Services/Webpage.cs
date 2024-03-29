namespace Services
{
    public class Webpage : ISearchable
    {
        string Text { get; set; }

        public Webpage(string text)
        {
            Text = text;
        }

        public string Search(string word)
        {
            string result = "";
            string lowercaseText = Text.ToLower();
            string[] separateWords = lowercaseText.Split(' ', ',', '.', '!', '?');

            if (separateWords.Contains(word))
            {
                result = $"******** Webpage found \"{word}\" ********";
            }
            else
            {
                result = $"******** Webpage did not find any \"{word}\". ********";
            }

            return result;
        }

    }
}

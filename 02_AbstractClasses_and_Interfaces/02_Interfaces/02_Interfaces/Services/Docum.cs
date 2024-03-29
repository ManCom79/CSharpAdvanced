namespace Services
{
    public class Docum : ISearchable
    {
        string Text { get; set; }

        public Docum(string text) { Text = text; }

        public string Search(string word)
        {
            string result = "";
            string lowercaseText = Text.ToLower();
            string[] separateWords =lowercaseText.Split(' ', ',', '.', '!', '?');
            
            if (separateWords.Contains(word)) {
                result = $"Docum managed to find the word {word}.";
            } else
            {
                result = $"Docum was not able to find the word {word}.";
            }
            
            return result;
        }
    }
}

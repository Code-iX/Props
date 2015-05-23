namespace PropsLib.Models
{
    public class Comment
    {
        public Comment(string text)
        {
            Text = text.Trim();
        }

        public string Text { get; private set; }
    }
}
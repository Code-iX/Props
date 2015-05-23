using System;
using PropsLib.Exceptions;

namespace PropsLib.Models
{
    public class PropsModel
    {
        private const string CommentDelimeter = "//";

        /// <summary>
        /// Puts a single line into the model
        /// </summary>
        /// <param name="line"></param>
        /// <exception cref="ParseErrorException">Called if source was not right</exception>
        public void PushLine(string line)
        {
            var comment = GetComment(ref line);
            var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        }

        private Comment GetComment(ref string line)
        {
            var pos = line.IndexOf(CommentDelimeter, StringComparison.Ordinal);
            if (pos < 0)
                return null;
            var comment = line.Substring(pos);
            line = line.Substring(0, pos).Trim();
            return new Comment(comment);
        }
    }
}
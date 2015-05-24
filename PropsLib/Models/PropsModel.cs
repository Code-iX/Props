using System;
using System.Text.RegularExpressions;
using PropsLib.Exceptions;

namespace PropsLib.Models
{
    public class PropsModel
    {
        /// <summary>
        /// Puts a single line into the model
        /// </summary>
        /// <param name="line"></param>
        /// <exception cref="ParseErrorException">Called if source was not right</exception>
        public void PushLine(string line)
        {
            // Empty line, do nothing
            if (string.IsNullOrWhiteSpace(line))
                return;

            // Retrieve documentation information  
            if (GetDocumentation(line))
            {
                // TODO add documentation
                return;
            }

            // Extrac
            var comment = GetComment(ref line);
            var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                
            }
        }

        /// <summary>
        /// Gets documentation, if available
        /// Not yet implemented
        /// </summary>
        /// <param name="line">Line of source code</param>
        /// <returns>Returns true, if Documentation was found</returns>
        /// <exception cref="InlineDocumentationException">Is thrown if documentation is inside an functions TODO must be in function detection
        /// </exception>
        [Obsolete] // TODO Not yet implemented
        private bool GetDocumentation(string line)
        {
            return false;
        }

        private Comment GetComment(ref string line)
        {
            var pos = line.IndexOf(Constants.CommentDelimeter, StringComparison.Ordinal);
            if (pos < 0)
                return null;
            var comment = line.Substring(pos);
            line = line.Substring(0, pos).Trim();
            return new Comment(comment);
        }
    }
}
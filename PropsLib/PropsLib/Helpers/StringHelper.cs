using System.Text.RegularExpressions;

namespace PropsLib.Helpers
{
    public static class StringHelper
    {
        public static string[] SplitLines(this string s)
        {
            return Regex.Split(s, "\r\n|\r|\n");
        }
    }
}
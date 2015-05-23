using System.Collections.Generic;

namespace PropsLib.Helpers
{
    public static class ArrayHelper
    {
        public static T[] Create<T>(int length, T value)
        {
            var result = new T[length];
            for (int i = 0; i < length; i++)
                result[i] = value;
            return result;
        }
    }
}
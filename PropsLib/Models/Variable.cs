using PropsLib.Exceptions;

namespace PropsLib.Models
{
    internal class Variable
    {
        private object _value;

        public Variable(object value, bool isConstant = false)
        {
            Value = value;
            IsConstant = isConstant;
        }

        public object Value
        {
            get { return _value; }
            set
            {
                if (IsConstant)
                    throw new DummyParseErrorException();
                _value = value;
            }
        }

        public bool IsConstant { get; private set; }
    }
}
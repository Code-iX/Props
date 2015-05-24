using System.Collections.Generic;
using PropsLib.Exceptions;

namespace PropsLib.Models
{
    /// <summary>
    /// Can contain constants, variables
    /// available basic types are
    /// int
    /// float (double)
    /// string
    /// Color
    /// Shape
    /// Instrument (Pen, Brush, ...)
    /// </summary>
    public class VariableContext
    {
        private Dictionary<string, Variable> _variables;

        public VariableContext()
        {
            _variables = new Dictionary<string, Variable>();
        }

        public void AddVariable(string name, object value, bool isConstant)
        {
            var variable = new Variable(value, isConstant);
            _variables.Add(name, variable);
        }

        public void SetValue(string name, object newValue)
        {
            if (!_variables.ContainsKey(name))
                throw new DummyParseErrorException();
            var variable = _variables[name];
            variable.Value = newValue;
        }

        public object GetValue(string name)
        {
            if (!_variables.ContainsKey(name))
                throw new DummyParseErrorException();
            return _variables[name].Value;
        }
    }
}
using System;
using System.Collections.Generic;
using PropsLib.Exceptions;
using PropsLib.Helpers;
using PropsLib.Interface;
using PropsLib.Models;

namespace PropsLib
{
    public class PropsViewer : IPropsViewer
    {
        public PropsViewer()
        {
            Ratio = 1;
        }
    
        #region Properties

        public float Ratio { get; private set; } 

        #endregion

        public bool SetSource(string source)
        {
            string[] lines = source.SplitLines();

            var propsModel = new PropsModel();
            var exceptionList = new Dictionary<int, ParseErrorException>();
            for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
            {
                string line = lines[lineNumber];
                try
                {
                    propsModel.PushLine(line);
                }
                catch (ParseErrorException e)
                {
                    exceptionList.Add(lineNumber, e);
                }
                catch (Exception e)
                {
                    throw;
                }
            }

            // TODO set Ratio
            Ratio = 1;

            return exceptionList.Count == 0;
        }       

        public byte[] GetImage(int sizeX, int sizeY)
        {
            // create new image 
            byte[] result = ArrayHelper.Create(sizeX*sizeY*4, Byte.MaxValue);


            return result;
        }
    }
}
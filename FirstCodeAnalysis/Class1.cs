using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
#if !(NET20)

#endif

namespace FirstCodeAnalysis
{
    [Serializable()]
    public class TestClassException : Exception
    {
        public static void Initialize(int size) { }
        protected static readonly int _Item;
        public static int Item { get { return _Item; } }
        public TestClassException(String s) : base(s) { }
        public TestClassException() : base() { }
        public TestClassException(String s, Exception e) : base(s, e) { }
        protected TestClassException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

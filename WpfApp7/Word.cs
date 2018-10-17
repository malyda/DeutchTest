using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public enum Types { Der, Die, Das}
    class Word
    {
        public string Value { get; set; }
        public Types Type { get; set; }
    }
}

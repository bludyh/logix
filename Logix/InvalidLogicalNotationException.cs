using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix {
    class InvalidLogicalNotationException : Exception {

        public InvalidLogicalNotationException() { }
        public InvalidLogicalNotationException(string message) : base(message) { }
        public InvalidLogicalNotationException(string message, Exception inner) : base(message, inner) { }

    }
}

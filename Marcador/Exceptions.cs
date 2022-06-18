using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcador
{
    public class PlayerException : Exception
    {
        public PlayerException()
            : base() { }

        public PlayerException(string message)
            : base(message) { }
    }

    public class TeamException : Exception
    {
        public TeamException()
            : base() { }

        public TeamException(string message)
            : base(message) { }
    }
}

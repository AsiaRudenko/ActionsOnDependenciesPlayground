using A.Net;
using A.Core;
using A.Framework;

namespace B.Net
{
    public class Wibble
    {
        public void M()
        {
            var foo_from_net5 = new A.Net.Foo();
            var foo_from_framework = new A.Framework.Foo();
            var foo_from_core = new A.Core.Foo();
        }
    }
}

namespace B.Core
{
    public class Wibble
    {
        public void M()
        {
            var foo_framework = new A.Framework.Foo();
            var foo_core = new A.Core.Foo();
            var foo_standard = new A.Standard.Foo();

            foo_framework.Bar();
            foo_core.Bar();
            foo_framework.Bar();
        }
    }
}

namespace B.Net
{
    public class Wibble
    {
        public void M()
        {
            var foo_from_net5 = new A.Net.Foo();
            var foo_from_framework = new A.Framework.Foo();
            var foo_from_core = new A.Core.Foo();
            var foo_from_standard = new A.Standard.Foo();

            foo_from_net5.Bar();
            foo_from_framework.Bar();
            foo_from_core.Bar();
            foo_from_standard.Bar();
        }
    }
}

namespace B.Framework
{
    public class Wibble
    {
        public void M()
        {
            var foo_framework = new A.Framework.Foo();
            foo_framework.Bar();
            var foo_standard = new A.Standard.Foo();
            foo_framework.Bar();
        }
    }
}

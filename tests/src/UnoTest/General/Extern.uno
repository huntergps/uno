using Uno;
using Uno.Testing;

namespace UnoTest.General
{
    extern(CPLUSPLUS)
    class Extern
    {
        [Test]
        void Main()
        {
            int i = 0;
            var a = [Flags] extern<int>(i) "$0";
            var b = [Flags] extern<int> "0";
            [Flags] extern(i) "$0";
            [Flags] "0";
            [Flags] extern(i)
            @{
                $0;
            @}
            [Flags] extern
            @{
            @}
            [Flags]
            @{
            @}

            // Access struct member #250
            Bar bar;
            extern(bar) "@{$0.String}";
            extern(bar) "@{Bar:Of($0).String}";
            extern(bar) "@{Bar:Of($0).String:Get()}";
            extern(bar) "@{Bar:Of($0).StringProp:Get()}";
        }

        struct Bar
        {
            public string String;
            public string StringProp { get { return String; } }
        }
    }
}

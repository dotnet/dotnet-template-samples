using System;

namespace MyProject.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hello world");

            string title = "AppTitle";
////#if (DisplayTitle)
// Console.WriteLine($"Title: {title}");
////#endif

////#if (DisplayTitle)
////    Actual Comment
//    content
//#endif
// end comment
//// end quad comment
        }
    }
}

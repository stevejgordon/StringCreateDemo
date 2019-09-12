using System;

namespace StringCreateDemo
{
    class Program
    {
        private const char spaceSeparator = ' ';
        private static ReadOnlySpan<char> YearPrefix => new char[] { 'I', 't', '\'', 's', ' ' };

        static void Main()
        {
            var context = new ContextData
            {
                FirstString = "Hello",
                SecondString = ".NET",
                ThirdString = "friends.",
                ShowYear = true,
                DateTime = new DateTime(2019, 09, 13, 09, 00, 00)
            };

            // TODO: Build the final string data and write to the console  
                        
            Console.ReadKey();
        }       

        internal struct ContextData
        {
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public string ThirdString { get; set; }
            public bool ShowYear { get; set; }
            public DateTime DateTime { get; set; }
        }
    }
}











//private static int CalculateLength(in ContextData context)
//{
//    var length = context.FirstString.Length + 1 +
//        context.SecondString.Length + 1 +
//        context.ThirdString.Length;

//    if (context.ShowYear)
//    {
//        length += 1 + YearPrefix.Length + 4;
//    }

//    return length;
//}



//int length = CalculateLength(in context);

//var myString = string.Create(length, context, (chars, state) =>
//{
//    var position = 0;

//    state.FirstString.AsSpan().CopyTo(chars);
//    position += state.FirstString.Length;
//    chars[position++] = spaceSeparator;

//    state.SecondString.AsSpan().CopyTo(chars.Slice(position));
//    position += state.SecondString.Length;
//    chars[position++] = spaceSeparator;

//    state.ThirdString.AsSpan().CopyTo(chars.Slice(position));

//    if (!context.ShowYear) return;

//    position += state.ThirdString.Length;
//    chars[position++] = spaceSeparator;

//    YearPrefix.CopyTo(chars.Slice(position));
//    position += YearPrefix.Length;
//    state.DateTime.Year.TryFormat(chars.Slice(position), out _);
//});
//
// Console.WriteLine(myString);
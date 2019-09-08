using System;

namespace StringCreateDemo
{
    class Program
    {
        private const char spaceSeparator = ' ';

        static void Main()
        {
            var context = new ContextData
            {
                FirstString = "Hello",
                SecondString = ".NET",
                ThirdString = "friends."
            };
                       
            // TODO: Concatinate the data and write to the console       
        }

        internal struct ContextData
        {
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public string ThirdString { get; set; }
        }
    }
}















//var length = context.FirstString.Length + 1 +
//    context.SecondString.Length + 1 +
//    context.ThirdString.Length;

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
//});

//Console.WriteLine(myString);
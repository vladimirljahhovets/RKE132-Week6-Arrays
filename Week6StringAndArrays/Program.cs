﻿

string hello = "hello, world! Here I am?";

int stringLength = hello.Length;


hello  = hello.Trim();
char firstLetter = hello[0];

Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');




firstLetter = hello[0];

Console.WriteLine(firstLetter);

Console.WriteLine(hello);



//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    { wordCounter++; }
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words");



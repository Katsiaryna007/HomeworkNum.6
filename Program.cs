// Задача 1: Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

// string CreateStringFromCharMatrix(char[,] matrix)
// {
//   string rezult = String.Empty;
//   foreach (var symbol in matrix)
//   {
//     rezult += symbol;
//   }
//   return rezult;
// }
// char[,] matrix = { { 'K', 'a', 'k', ' ', ' ' }, { 'd', 'e', 'l', 'a', '?' } };
// string rezult = CreateStringFromCharMatrix(matrix);
// Console.WriteLine($"Результат: {rezult}");


// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string ConvertToLowerCase(string letters)
// {
//   string rezult = String.Empty;
//   int length = letters.Length;
//   for (int i = 0; i < length; i++)
//   {
//     if (char.IsUpper(letters[i]))
//     {
//       Console.Write(char.ToLower(letters[i]));
//     }
//     else Console.Write(letters[i]);
//   }
//   return rezult;
// }
// string letters = "AbCdEfG";
// string NewString = ConvertToLowerCase(letters);
// Console.WriteLine(NewString);


// Задача 3: Задайте произвольную строку.
// Выясните, является ли она палиндромом.

// string CheckStringForPolydrome(string str)
// {
//   string newString = String.Empty;
//   int newStringlength = str.Length;
//   for (int i = (str.Length - 1); i >= 0; i--)
//   {
//     newString += str[i];
//   }
//   if (String.Equals(newString, str))
//   {
//     Console.WriteLine($"Строка является полиндромом");
//   }
//   else Console.WriteLine($"Строка не является полиндромом");
//   return newString;
// }
// string str = "level";
// string newString = CheckStringForPolydrome(str);
// Console.WriteLine(newString);
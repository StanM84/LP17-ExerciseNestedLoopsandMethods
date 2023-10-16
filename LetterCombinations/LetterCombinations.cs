char firstLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excLetter = char.Parse(Console.ReadLine());

int count = 0;

for (char letter1 = firstLetter; letter1 <= endLetter; letter1++)
{
    for (char letter2 = firstLetter; letter2 <= endLetter; letter2++)
    {
        for (char letter3 = firstLetter;letter3 <= endLetter; letter3++)
        {
            if (letter1 != excLetter && letter2 != excLetter && letter3 != excLetter)
            {
                Console.Write($"{letter1}{letter2}{letter3} ");
                count++;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(count);
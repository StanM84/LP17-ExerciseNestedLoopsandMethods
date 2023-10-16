string text = Console.ReadLine();

Console.WriteLine(VowelsCount(text));

static int VowelsCount (string text)
{
    int count = 0;

    for (int position = 0; position <= text.Length - 1; position++)
    {
        char symbol = text[position];

        if (symbol == 'A' || symbol == 'a' || symbol == 'E' || symbol == 'e' || symbol == 'I' || symbol == 'i' || symbol == 'U' || symbol == 'u' || symbol == 'O' || symbol == 'o')
        {
            count++;
        }
    }
    return count;
}
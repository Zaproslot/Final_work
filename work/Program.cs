string[] text = {"Пытаюсь", "сделать", "итоговую", "работу", "по", "прогроммированию", ":)"};
Console.WriteLine("{0}", string.Join(" ", text));

void newText(string[] text)
{
    string result = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if(text[i].Length <= 3)
        {
            result += $"{text[i]} ";
        }
    }

    Console.WriteLine("{0}", string.Join(" ", result));
}
System.Console.WriteLine();
newText(text);
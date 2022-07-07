//======Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками.
// маленькие буквы "к" заменить большими буквами "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result + $"{newValue}";
        else result + $"{str[i]}";
    }
    return result;
}

string newText = Replace(text, " ", "|");
Console.WriteLine(newText);
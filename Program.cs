Dictionary<string, int> studentGrades = new Dictionary<string, int>();

studentGrades["Аня"] = 5;
studentGrades["Борис"] = 4;
studentGrades.Add("Вика", 5);

studentGrades.Add("Григорий", 3);

// Изменяем оценку Ани
studentGrades["Аня"] = 4;

foreach (KeyValuePair<string, int> pair in studentGrades)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.WriteLine($"Количество студентов: {studentGrades.Count}");





Dictionary<string, string> subjectRooms = new Dictionary<string, string>
{
    { "Математика", "Каб. 201" },
    { "Физика", "Каб. 305" },
    { "История", "Каб. 110" }
};

Console.WriteLine(subjectRooms.ContainsKey("Физика"));
subjectRooms.Remove("История");

foreach (KeyValuePair<string, string> pair in subjectRooms)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

Console.Write("Введите название предмета: ");
string subject = Console.ReadLine();

if (subjectRooms.ContainsKey(subject))
{
    Console.WriteLine(subjectRooms[subject]);
}
else
{
    Console.WriteLine("Предмет не найден");
}



HashSet<string> attendedElectives = new HashSet<string>();

attendedElectives.Add("Робототехника");
attendedElectives.Add("Дизайн");
attendedElectives.Add("Робототехника");

Console.WriteLine(attendedElectives.Count);

foreach (string elective in attendedElectives)
{
    Console.WriteLine(elective);
}





int[] recordBooks = { 1042, 1058, 1071, 1058, 1105 };

HashSet<int> seen = new HashSet<int>();

bool hasDuplicates = false;

foreach (int number in recordBooks)
{
    if (!seen.Add(number))
    {
        hasDuplicates = true;

        Console.WriteLine($"Повторяющийся номер: {number}");
        break;
    }
}

if (!hasDuplicates)
{
    Console.WriteLine("Все номера уникальны");
}





Dictionary<string, int> studentGrades = new Dictionary<string, int>
{
    { "Аня", 5 },
    { "Борис", 4 }
};

if (studentGrades.TryGetValue("Вика", out int grade))
{
    Console.WriteLine(grade);
}
else
{
    Console.WriteLine("Студент не найден");
}






Dictionary<string, int> students = new Dictionary<string, int>();

students.Add("Анна", 18);
students.Add("Борис", 19);
students.Add("Вика", 17);
students.Add("Григорий", 20);

foreach (KeyValuePair<string, int> pair in students)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}







Dictionary<string, string> subjectRooms = new Dictionary<string, string>
{
    { "Математика", "Каб. 201" },
    { "Физика", "Каб. 305" },
    { "История", "Каб. 110" }
};

Console.Write("Введите предмет: ");
string subject = Console.ReadLine();

if (subjectRooms.ContainsKey(subject))
{
    Console.WriteLine(subjectRooms[subject]);
}
else
{
    Console.WriteLine("Предмет не найден");
}







string text = "кот собака кот птица собака кот";

string[] words = text.Split(' ');

Dictionary<string, int> wordCount = new Dictionary<string, int>();

foreach (string word in words)
{
    if (wordCount.ContainsKey(word))
    {
        wordCount[word]++;
    }
    else
    {
        wordCount.Add(word, 1);
    }
}

foreach (KeyValuePair<string, int> pair in wordCount)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}








Dictionary<string, double> products = new Dictionary<string, double>
{
    { "Ноутбук", 75000 },
    { "Телефон", 45000 },
    { "Монитор", 25000 },
    { "Планшет", 35000 }
};

double maxPrice = 0;
string expensiveProduct = "";

foreach (KeyValuePair<string, double> pair in products)
{
    if (pair.Value > maxPrice)
    {
        maxPrice = pair.Value;
        expensiveProduct = pair.Key;
    }
}

Console.WriteLine($"Самый дорогой товар: {expensiveProduct}");
Console.WriteLine($"Цена: {maxPrice}");









string text = "Космос огромен и прекрасен. Космос полон загадок. Изучение космоса интересно.";

string[] words = text.Split(' ');

Dictionary<string, int> wordCount = new Dictionary<string, int>();
HashSet<string> uniqueWords = new HashSet<string>();

foreach (string word in words)
{
    string lowerWord = word.ToLower();

    uniqueWords.Add(lowerWord);

    if (wordCount.ContainsKey(lowerWord))
    {
        wordCount[lowerWord]++;
    }
    else
    {
        wordCount.Add(lowerWord, 1);
    }
}

// Поиск самого частого слова
string mostCommonWord = "";
int maxCount = 0;

foreach (KeyValuePair<string, int> pair in wordCount)
{
    if (pair.Value > maxCount)
    {
        maxCount = pair.Value;
        mostCommonWord = pair.Key;
    }
}

Console.WriteLine($"Самое частое слово: {mostCommonWord}");
Console.WriteLine($"Количество повторений: {maxCount}");

Console.WriteLine($"Количество уникальных слов: {uniqueWords.Count}");
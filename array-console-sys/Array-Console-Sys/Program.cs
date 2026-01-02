
//დავალება 1. ორი მასივის გაერთიანება / კოპირება

//int[] array1 = new int[3] { 1, 2, 3 };
//int[] array2 = new int[3] { 4, 5, 6 };

//int[] resultArray = new int[array1.Length + array2.Length];

//Console.WriteLine(resultArray);

//for (int i = 0; i < array1.Length; i++)
//{
//    resultArray[i] = array1[i];
//}

//for (int i = 0; i < array2.Length; i++)
//{
//    resultArray[i + array1.Length] = array2[i];
//}

//for (int i = 0; i < resultArray.Length; i++)
//{
//    Console.Write(resultArray[i] + "\t");
//}

//დავალება 2. 

//int[] intArray = new int[8] { 3, 5, -4, 8, 11, 1, -1, 6 };

//Console.Write("Enter target sum: ");
//int targetSum = 7;
//targetSum = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < intArray.Length; i++)
//{
//    for (int j = i + 1; j < intArray.Length; j++)
//    {
//        if (intArray[i] + intArray[j] == targetSum)
//        {
//            Console.WriteLine($"{intArray[i]} + {intArray[j]} = {targetSum}");
//        }
//    }
//}

//დავალება 3

//int[] numbers = new int[10];
//int evenCount = 0;
//int oddCount = 0;

//Console.WriteLine("Enter 10 Number : ");

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = Convert.ToInt32(Console.ReadLine());

//    if (numbers[i] % 2 == 0)
//    {
//        evenCount++;
//    }

//    else
//    {
//        oddCount++;
//    }
//}

//int[] evenNumbers = new int[evenCount];
//int[] oddNumbers = new int[oddCount];

//int evenIndex = 0;
//int oddIndex = 0;

//foreach (int number in numbers)
//{
//    if (number % 2 == 0)
//    {
//        evenNumbers[evenIndex] = number;
//        evenIndex++;
//    }

//    else
//    {
//        oddNumbers[oddIndex] = number;
//        oddIndex++;
//    }
//}

//Console.WriteLine("Even Numbers: ");

//foreach (int number in evenNumbers)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine("Odd Numbers: ");

//foreach (int number in oddNumbers)
//{
//    Console.WriteLine(number);
//}

//დავალება 4

//int[] presentArray = new int[7] { 7, 5, 85, 9, 11, 23, 18 };

//Console.WriteLine("Enter number that is in present array: ");

//int findNumber;
//findNumber = Convert.ToInt32(Console.ReadLine());

//bool isFound = false;


//foreach (int num in presentArray)
//{
//    if (num == findNumber)
//    {
//        isFound = true;
//        break;
//    }
//}

//if (isFound)
//{
//    Console.WriteLine($"{findNumber} is in array");
//}

//else
//{
//    Console.WriteLine($"{findNumber} is not in array");
//}


//int[] numbers = { 7, 5, 85, 9, 11, 23, 18 };
//Console.WriteLine("Enter number: ");
//int n;
//n = Convert.ToInt32(Console.ReadLine());

//bool isPresent = false;

//foreach (int num in numbers)
//{
//    if (num == n)
//    {
//        isPresent = true;
//        break;
//    }
//}

//if (isPresent)
//{
//    Console.WriteLine("Is Present");
//}

//else
//{
//    Console.WriteLine("Not Present");
//}









//string userEmail = "user@gmail.com";
//string mail;

//Console.WriteLine("Enter mail: ");
//mail = Console.ReadLine() ?? string.Empty;

//if (mail.Equals(userEmail, StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("Correct");
//}

//else
//{
//    Console.WriteLine("Incorrect");
//}



//string text = "Hello, World!";
//string subString = text.Substring(5, 3);
//Console.WriteLine(subString);

//using System.Text;

//StringBuilder sb = new StringBuilder();
//sb.Append(' ');
//sb.Append("C#");
//sb.Append("Python");

//string result = sb.ToString();
//Console.WriteLine(result);

//string text = "Hello, World!";
//string[] words = text.Split(' ');
//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}

//string text = "";
//bool isNullOrEmpty = string.IsNullOrEmpty(text);
//bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(text);


//string fullName = "     SaNdRo KsoVreli      ";
//string userName;
//string[] names = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//string firstName = names[0];
//string lastName = names[1];

//userName = (firstName[0] + lastName).ToLower();

//Console.WriteLine(userName);


//string text = "this is very long text that must be fortened!";

//if (text.Length > 20)
//{
//    text = text.Substring(0, 20) + "...";
//}

//Console.WriteLine(text);

//string regulation = "This is a bad text with bad word";
//string[] words = { "bad", "with" };

//foreach (string word in words)
//{
//    regulation = regulation.Replace(word, new string('*', word.Length));
//}

//Console.WriteLine(regulation);


//static double Summary(double x, double y)
//{
//    return x + y;
//}

//double sum = Summary(3, 4);

//Console.WriteLine(sum); // static

//string str = "Welcome to step academny";
//int count = CountSpaces(str);
//Console.WriteLine(count);
//static int CountSpaces(string text)
//{
//    //int result = 0;

//foreach(char item in text)
//{
//    if(item == ' ')
//    {
//        result++;
//    }
//}
//return result;



//return text.Split(' ').Length - 1;

//}


//int number;
//Console.WriteLine("Enter N:");
//number = Convert.ToInt32(Console.ReadLine());
//int fib = fibonacci(number);
//Console.WriteLine(fib);
//static int fibonacci(int n)
//{
//    int first = 0;
//    int second = 1;
//    int result = 0;


//    for (int i = 0; i < n; i++)
//    {
//        result = first + second; // 3
//        first = second; // 2
//        second = result; // 3
//    }

//    return result;
//}



//int[] numbers = new int[15];
//Random random = new Random();

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 101);
//}

//static void CountEven(int[] numbers) 
//{ 

//    int even = 0;
//    int sum = 0;

//        foreach (int i in numbers)
//        {
//            if (i % 2 == 0)
//            {
//                even++;
//                sum += i;
//            }
//        } 
//    }



// swap
//int a = 13;
//int b = 32;

//swap(ref a, ref b);
//static void swap(ref int x, ref int y)
//{
//    //int temp = x;
//    //x = y;
//    //y = temp;

//    (x, y) = (y, x);

//}
//Console.WriteLine($"a = {a}, b = {b}");

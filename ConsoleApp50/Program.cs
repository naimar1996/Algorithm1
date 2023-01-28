//int number = 349;
//int reminder = 0;
//int sum = 0;
//for(int i = 0; i < number; i++)
//{
//    reminder = number % 10;
//    number /= 10;
//    sum += reminder; 
//}
//if (sum % 2 == 0)
//{
//    Console.WriteLine(" sum is even");
//}
//else
//{
//    Console.WriteLine(" sum is odd");
//}

//int number = 100;
//int sum = 0;
//while (number > 0)
//{
//    if (number % 13 == 0)
//    {
//        Console.WriteLine(number);
//        sum += number;
//    }
//    number--;
//}
//Console.WriteLine(sum);

int number = 835;
int min = 9;
int reminder; 
for ( int n = 0; n < number; n++)
{
    reminder = number % 10;
    if ( reminder < min)
    {
        min = reminder; 
    }
    number /= 10;
}
Console.WriteLine(min);




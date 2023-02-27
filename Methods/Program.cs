#region Task 1
//int[] arr = { 1, 3, 5, 7, 9, 24, 56 };
//int num1 = 56;
//Result(arr);

//void Result(params int[] numbers)
//{
//	for (int i = 0; i < numbers.Length; i++)
//	{
//		if (numbers[i] == num1) 
//		{
//			Console.WriteLine(num1+":Arrayin icinde var");
//			break;
//		}
//		else
//		{
//			Console.WriteLine(num1+":Arrayin icinde yoxdur");
//			break;
//		}
//	}
//}
#endregion
#region Task 2 
int Biggest(params int[] numbers)
{
    int maximum = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] > maximum)
		{
			maximum = numbers[i];
        }
	}return maximum;
}
Console.WriteLine(Biggest(2, 5, 34, 67, 23, 98, 26));
#endregion 
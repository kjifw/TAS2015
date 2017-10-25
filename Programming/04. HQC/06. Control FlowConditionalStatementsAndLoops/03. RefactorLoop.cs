bool isValueFound = false;
for (int i = 0; i < array.length; i++) 
{
	if (i % 10 == 0 && array[i] == expectedValue)
	{
		isValueFound = true;
		break;
	}

	Console.WriteLine(array[i]);
}

// More code here
if (isValueFound)
{
	Console.WriteLine("Value Found");
}
public void PrintAvgNumber(double[] array, int count)
{
	double sum = 0;

	for (int i = 0; i < count; i++)
	{
		sum += array[i];
	}

	PrintAvg(tmp/count);
}

public void PrintMaxNumber(double[] array, int count)
{
	double maxValue = array[0];
	
	for (int i = 1; i < count; i++)
	{
		if (array[i] > maxValue)
		{
			maxValue = array[i];
		}
	}

	PrintMax(maxValue);
}

public void PrintMinNumber(double[] array, int count)
{
	double minValue = array[0];

	for	(int i = 1; i < count; i++)
	{
		if (array[i] < minValue)
		{
			minValue = array[i];
		}
	}

	PrintMin(minValue);
}
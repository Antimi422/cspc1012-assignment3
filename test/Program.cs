// See https://aka.ms/new-console-template for more information
double[] values = [5,4,10,3,1,2,3,2];
FindHighestValueInMemory(values, 7);


double FindHighestValueInMemory(double[] values, int logicalSize)
{
	double highest = values[0];
	for (int i = 0; i < logicalSize; i++)
	{
		if (values[i] > highest)
		{
			highest = values[i];
		}
	}
	Console.WriteLine($"Highest value is {highest}");
	return highest;
}
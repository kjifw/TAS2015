## Data Structures, Algorithms and Complexity Homework
#### Task 1 What is the expected running time of the following C# code?
    - Explain why using Markdown.
    - Assume the array's size is n.

~~~c#
    long Compute(int[] arr) 
    {
        long count = 0;
        for (int i=0; i < arr.Length; i++)
        {
            int start = 0, end = arr.Length-1;
            while (start < end)
                if (arr[start] < arr[end])
                    { start++; count++; }
                else 
                    end--;
        }
        return count;
    }
~~~

##### Answer: 
    --> for loop - n times
    --> while loop - maximum n times
    --> expected running time - n * n --> O(n<sup>2</sup>) 

#### 2. What is the expected running time of the following C# code?
    - Explain why using Markdown.
    - Assume the input matrix has size of `n * m`.

~~~c#
    long CalcCount(int[,] matrix)
    {
        long count = 0;
        for (int row=0; row < matrix.GetLength(0); row++)
            if (matrix[row, 0] % 2 == 0)
                for (int col=0; col < matrix.GetLength(1); col++)
                    if (matrix[row,col] > 0)
                        count++;
      
      return count;
  }
~~~

###### Answer: 
  --> Worst case scenario - matrix[row, 0] % 2 == 0 is true for each row --> O(row * col) --> O(n * m)
  --> Best case scenario - matrix[row, 0] % 2 == 0 is false for each row --> O(row) --> O(n)

#### 3. (*)What is the expected running time of the following C# code?
    - Explain why using Markdown.
    - Assume the input matrix has size of n * m.

~~~c#
    long CalcSum(int[,] matrix, int row)
    {
        long sum = 0;

        for (int col = 0; col < matrix.GetLength(0); col++)
        {
          sum += matrix[row, col];
        }
     
        if (row + 1 < matrix.GetLength(1)) 
        {
            sum += CalcSum(matrix, row + 1);
        }
        
        return sum;
    }

    Console.WriteLine(CalcSum(matrix, 0));
~~~

###### Answer: 
  --> For each row the for loop sums the values of each cell --> O(n * m)
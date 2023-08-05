int[,] matrix1 = GenerateTable(4, 2, 0, 9);
int[,] matrix2 = GenerateTable(2, 3, 0, 9);

WriteTable(matrix1, "матрица 1:");
WriteTable(matrix2, "матрица 2:");

int[,]? result = MatrixProduct(matrix1, matrix2);
if (result == null) Console.WriteLine("нельзя умножить matrix1 на matrix2");
else WriteTable(result, "результирующая матрица:");


int[,]? MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) return null;

    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int row = 0; row < matrix3.GetLength(0); row++)
        for (int col = 0; col < matrix3.GetLength(1); col++)
        {
            matrix3[row, col] = RowColProduct(matrix1, row, matrix2, col);
        }

    return matrix3;
}

int RowColProduct(int[,] matrix1, int row, int[,] matrix2, int col)
{
    int item = 0;
    for (int i = 0; i < matrix1.GetLength(1); i++)
    {
        item += matrix1[row, i] * matrix2[i, col];
    }
    return item;
}

int[,] GenerateTable(int rows, int columns, int min, int max)
{
    int[,] table = new int[rows, columns];
    Random rand = new();

    for (int i = 0; i < table.GetLength(0); i++)
        for (int j = 0; j < table.GetLength(1); j++)
            table[i, j] = rand.Next(min, max);

    return table;
}

void WriteTable(int[,] table, string? header)
{
    if (header != null) Console.WriteLine(header);
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write("{0, 2} ", table[i, j]);
        }
        Console.WriteLine();
    }
}

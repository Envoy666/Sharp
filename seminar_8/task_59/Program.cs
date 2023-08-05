int[,] table = GenerateTable(5, 5, 0, 9);
WriteTable(table, "исходная таблица:");

int[] coords = FindMinCoords(table);
Console.WriteLine($"минимум: ({coords[0]}; {coords[1]})");

int[,] result = RemoveRowCol(table, coords[0], coords[1]);
WriteTable(result, "результирующая таблица:");


int[,] RemoveRowCol(int[,] table1, int row, int col)
{
    int[,] table2 = new int[table1.GetLength(0) - 1, table1.GetLength(1) - 1];

    for (int i1 = 0, i2 = 0; i1 < table1.GetLength(0); i1++)
    {
        if (i1 == row) continue;
        for (int j1 = 0, j2 = 0; j1 < table1.GetLength(1); j1++)
        {
            if (j1 == col) continue;
            table2[i2, j2] = table1[i1, j1];
            j2++;
        }
        i2++;
    }
    return table2;
}

int[] FindMinCoords(int[,] table)
{
    int minRow = 0;
    int minCol = 0;
    int min = table[minRow, minCol];
    for (int i = 0; i < table.GetLength(0); i++)
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] < min)
            {
                min = table[i, j];
                minRow = i;
                minCol = j;
            }
        }

    return new[] { minRow, minCol };
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
            Console.Write("{0} ", table[i, j]);
        }
        Console.WriteLine();
    }
}

int col = int.Parse(Console.ReadLine());
int row = int.Parse(Console.ReadLine());
string[,] matrix = new string[col, row];
matrix = GiveOperation(matrix);
matrix = GiveMatrixNums(matrix);
DispalyMatrix(matrix);
static string[,] GiveMatrixNums(string[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            Random r = new Random();
            matrix[i, f] += (r.Next(0, 9)).ToString();
        }
    }
    return matrix;
}

static string[,] GiveOperation(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            Random r = new Random();
            string n = (r.Next(0, 3)).ToString();
            if (n == "0")
            {
                matrix[i, f] = "*";
            }
            else if (n == "1")
            {
                matrix[i, f] = "/";
            }
            else if (n == "2")
            {
                matrix[i, f] = "+";
            }
            else
            {
                matrix[i, f] = "-";
            }
        }
    }
    return matrix;
}
static void DispalyMatrix(string[,] matrix)
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write("┌────┐");
        }
        Console.WriteLine();
        for (int col = 0; col < matrix.GetLength(1); col++)
        {

            Console.Write("| " + matrix[row, col] + " |");
        }
        Console.WriteLine();
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write("└────┘");
        }
        Console.WriteLine();
    }

}

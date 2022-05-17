void ShowMat(task1.matrix mat)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(mat[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

task1.matrix mat1 = new task1.matrix(5, 6, 7, 8);
task1.matrix mat2 = new task1.matrix(0, 1, 2, 3);

Console.WriteLine("Матрица mat1:\n");
ShowMat(mat1);
Console.WriteLine("\nМатрица mat2:\n");
ShowMat(mat2);

task1.matrix mat3 = mat1 * mat2;
Console.WriteLine("\nmat3 = mat1 * mat2 :\n");
ShowMat(mat3);

task1.matrix mat4 = mat3 - mat1;
Console.WriteLine("\nmat4 = mat3 - mat1 :\n");
ShowMat(mat4);

mat2--;
Console.WriteLine("\nmat2-- :\n");
ShowMat(mat2);

task1.matrix mat5 = mat3 * 55;
Console.WriteLine("\nmat5 = mat3 * 55:\n");
ShowMat(mat5);

Console.WriteLine($"\nОпределитель матрицы mat5: {mat5.GetDeter()}");
Console.WriteLine($"\nОпределитель матрицы mat5: {(bool)mat5}");

Console.WriteLine($"\nМатрицы m1 и m2 равны: {mat1 == mat2}");

mat4.SetDeter(234);
Console.WriteLine($"\nМатрице m4 установлен определитель {mat4.GetDeter()}: \n");
ShowMat(mat4);
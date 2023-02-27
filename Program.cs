void Square(int A, int B) {
    if (A == B * B) Console.WriteLine("А является квадратом B");
    else Console.WriteLine("А не является квадратом B");

    if (B == A * A) Console.WriteLine("B является квадратом A");
    else Console.WriteLine("B не является квадратом A");
}

Console.Write("Число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Square(A, B);
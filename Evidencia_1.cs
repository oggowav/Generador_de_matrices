
//Oscar González Gómez y Camilo Alberto Andres 

int ren, col, num;

//Instruccion para copiar renglones
Console.WriteLine("Ingresa el numero de renglones: ");
ren = int.Parse(Console.ReadLine());
//Instruccion para copiar columnas
Console.WriteLine("Ingresa el numero de columnas: ");
col = int.Parse(Console.ReadLine());

while (ren * col > 16)
{
    Console.WriteLine("Favor de ingresar datos mas pequeños");

    Console.WriteLine("Ingresa el numero de renglones: ");
    ren = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa el numero de columnas: ");
    col = int.Parse(Console.ReadLine());
}

//DECLARAR MATRIZ
double[,] matriz = new double[ren, col];

for (int i = 0; i < ren; i++) //FOR RENGLONES
{
    for (int j = 0; j < col; j++) //COLUMNAS
    {
        Console.WriteLine("Ingresa el numero [" + i + "," + j + "] para la matriz}: ");
        matriz[i, j] = double.Parse(Console.ReadLine());


    }

   
}


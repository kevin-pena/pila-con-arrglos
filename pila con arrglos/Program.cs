class PilaConArreglos
{
    private int[] arreglo;
    private int tope;
    private int capacidad;

    public PilaConArreglos(int capacidad)
    {
        this.capacidad = capacidad;
        this.arreglo = new int[capacidad];
        this.tope = -1; // Pila vacía
    }

    public void Push(int elemento)
    {
        if (tope < capacidad - 1)
        {
            arreglo[++tope] = elemento;
            Console.WriteLine($"Elemento {elemento} agregado a la pila.");
        }
        else
        {
            Console.WriteLine("Error: Pila llena, no se puede agregar más elementos.");
        }
    }
    public int Pop()
    {
        if (tope >= 0)
        {
            int elementoEliminado = arreglo[tope--];
            Console.WriteLine($"Elemento {elementoEliminado} eliminado de la pila.");
            return elementoEliminado;
        }
        else
        {
            Console.WriteLine("Error: Pila vacía, no se puede eliminar más elementos.");
            return -1; // Valor sentinela para indicar error
        }
    }
    public void MostrarPila()
    {
        Console.WriteLine("Elementos en la pila:");
        for (int i = 0; i <= tope; i++)
        {
            Console.WriteLine(arreglo[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        PilaConArreglos pila = new PilaConArreglos(5);

        pila.Push(1);
        pila.Push(2);
        pila.Push(3);

        pila.MostrarPila();

        pila.Pop();
        pila.MostrarPila();
    }
}

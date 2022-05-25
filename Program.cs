// ====================================================MAIN START======================================================= //
WriteLine("Hello, World!");



// ====================================================MAIN START======================================================= //


// ====================================================CLASS CONTROL START======================================================= //
class ManejoDeArchivos
{
    StreamReader archivo = null;

    int contador = 0;

    string linea;

    public ManejoDeArchivos()
    {
        archivo = new StreamReader(@"C:\Users\HP-ProBook6460B\Desktop\programing\tarea.txt");

        while ((linea = archivo.ReadLine()) != null) ;
        {
            WriteLine(linea);

            contador++;
        }

        {

        }
    }

    public void Mensaje()
    {
        WriteLine($"Con el $: Hay {contador} lineas");
        WriteLine();
        WriteLine("Sin el $: Hay {0} lineas", contador);
    }
}
// ====================================================CLASS CONTROL END======================================================= //



// ====================================================DESTRUCTOR START======================================================= //




// ====================================================DESTRUCTOR END======================================================= //

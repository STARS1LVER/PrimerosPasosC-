



int numero = 1;

while( numero <= 10)
{
    // Console.WriteLine($"El valor de la variable es : { numero }");  
    numero++;
}

decimal balance = 200m;

decimal interes = 1.07m;

int contandor = 1;

while( contandor <= 2 )
{
    balance *= interes;
    contandor++;
}

// Console.WriteLine(balance);

// Aca veremos el do while 

int contador2 = 1;

do
{
    // Console.WriteLine("Empezo ");
    contador2++;
} while (contador2 < 10);

// Console.WriteLine("Termino");


// ahora veremos el bucle for:

for ( int contador3 = 1; contador3 <= 10; contador3++)
{
    //Console.WriteLine($"{contador3}");
 }

// Ahora veremos un bucle for each:
string nombre = "Diego";
foreach( var letra in nombre)
{
    //Console.WriteLine( letra );
}


// Ejercicio FIZZBUZZ

for( int i = 1; i <= 15; i ++)
{
    if(i % 3 == 0 && i % 5 == 0) 
    {
        Console.WriteLine($"  FizzBuzz ");
    } else if ( i % 3 == 0 ) 
    {
        Console.WriteLine($" Fizz ");
    } else if ( i % 5 == 0 )
    {
        Console.WriteLine($"Buzz");    
    } else
    {
        Console.WriteLine($" {i} ");
    }
}




// sentancia de break y continue:
for( int i = 1; i <= 10;  i++)
{
    if(i == 5)
    {   
        // break
        continue;
    }
   // Console.WriteLine(i);
}

//Console.WriteLine("Se termino la aplicacion");

while (true)
{
    Console.WriteLine("=======================");
    Console.WriteLine("Bienvenido a la calculadora en c#");
    Console.WriteLine("=======================");
    Console.Write("Escriba el primer numero");
    var entradaUsuario = Console.ReadLine();
    if( entradaUsuario is null)
    {
        Console.WriteLine("Error vuelve a comenzar");
        continue;
    }
    var numeroUsuario = decimal.Parse(entradaUsuario); // Tranformamos el numero a un decimal

    Console.Write("Escribe el segundo numero");
    entradaUsuario = Console.ReadLine();

    if (entradaUsuario is null)
    {
        Console.WriteLine("Error vuelve a comenzar");
        continue;
    }

    var numeroUsuario2 = decimal.Parse(entradaUsuario);

    Console.WriteLine($"El resultado de sumar { numeroUsuario } y { numeroUsuario2} es { numeroUsuario + numeroUsuario2 } ");
    Console.Write("¿ Desea sumar otra vez? (y/n) ");
    entradaUsuario = Console.ReadLine();

    if( entradaUsuario != "y")
    {
        Console.WriteLine("Hasta Luego");
        break;
    } 


}

Console.WriteLine("Saliste");
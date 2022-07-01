

bool carEsp = false, may = false, num = false, esp = true, carac = false, activo = false;
int numeros=0;

while (activo == false)
{
    Console.WriteLine("Digite su contraseña: ");
    String s = Console.ReadLine();
    int Nmay=0, Nnum = 0, Ncares = 0;
    char[] contraseña = s.ToCharArray();
    for (int i = 0; i < s.Length; i++)
    {
        if (Char.IsUpper(s,i))
        {
            Nmay++;
            if (Nmay==2)
            {
                may = true;
            }
        }
        else if (Char.IsLower(s, i))
        {
            
        }
        else if (Char.IsDigit(s, i))//(contraseña[i] == '1'|| contraseña[i] == '2' || contraseña[i] == '3' || contraseña[i] == '4' || 
        //    contraseña[i] == '5' || contraseña[i] == '6' || contraseña[i] == '7' || contraseña[i] == '8' ||
        //    contraseña[i] == '9')
        {
            
            int a = contraseña[i];
            int c = i +1;
            
            for (int y = c; y < contraseña.Length; y++)
            {
                int b = contraseña[y];
                if (a == b)
                {
                    Nnum++;
                    Console.WriteLine("El Numero: "+ contraseña[y] + " aparece repetido");
                }
            }
            if (Nnum==0)
            {
                num=true;
            }
        }
        else if (contraseña[i] == ' ')
        {
            esp = false;
        }
        else if (contraseña[i] == '*' || contraseña[i] == '_' || contraseña[i] == '-' || contraseña[i] == '¿' ||
            contraseña[i] == '¡' || contraseña[i] == '?' || contraseña[i] == '#' || contraseña[i] == '$')
        {
            carEsp = true;
        }

        
        if (Char.IsLetter(s, i))
        {
            Ncares++;
                      
            
        }
    }
    if ((Ncares < 14) && (Ncares > 8))
    {
        Console.WriteLine("Algo esta mal:");
        carac = true;
    }
    if (may==true && num == true && carEsp == true && esp == true && carac == true && Ncares <= 14 && Ncares >= 8)
    {
        activo = true;
        Console.WriteLine(" ");
        Console.WriteLine("Se ha establecido la contraseña" );
        Console.WriteLine(" ");
    }
    Console.WriteLine("Validacion:");
    Console.WriteLine("Al menos 2 letras mayúsculas: "+may);
    Console.WriteLine("Al menos 3 números no repetidos: " + num);
    Console.WriteLine("Al menos 1 carácter de esta lista (* _ - ¿ ¡ ? # $): " + carEsp);
    Console.WriteLine("No debe contener espacios en blanco: " + esp);
    Console.WriteLine("Tener entre 8 y 14 caracteres, no más, no menos: " + carac);
    if (activo == false)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Vuelva a intentarlo corrigiendo los detalles, gracias.");
    }
    Console.ReadLine();
    Console.Clear();
    carEsp = false;
    may = false; 
    num = false; 
    esp = true; 
    carac = false;
}
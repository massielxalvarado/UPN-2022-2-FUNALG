char caracter;
caracter = 'a';
caracter = 'e';
caracter = 'i';
caracter = 'o';
caracter = 'u';

do
{
    Console.Write("INGRESE UN NUMERO SEGUID0 DE ENTER: ");
    caracter = char.Parse(Console.ReadLine());
}

while (caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' && caracter != 'u');

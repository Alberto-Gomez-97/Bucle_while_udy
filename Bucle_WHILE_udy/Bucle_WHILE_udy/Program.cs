//While, ejecutar accion mientras sea verdadera
int cont = 0;
while(cont<=10){
     Console.WriteLine(cont);
        cont++;
}
//ejemplo 2
var balance = 200m;
var interes = 1.07m;
var contadorInteres = 1;

while (contadorInteres <= 10)
{   //balance x interes
    balance *= interes;
    contadorInteres++;
}
Console.WriteLine("El balance es: "+ balance);
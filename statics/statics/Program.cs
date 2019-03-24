using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace statics
{
    class Program
    {
        static void Main(string[] args)
        {

//            Create a statistical program which will allow the user to: 

//- Add new data 
//- See all data entered 
//- Find an item, to see whether it has been entered or not 
//- View a summary of statistics: amount of data, sum, average, maximum, minimum 
//- Exit the program 

//These options must appear as a menu. Each option will be chosen by a number or a letter. 

//The program must reserve space for a maximum of 1000 data, but keep count of how many data actually exist. 

            float[] numbers = new float[1000];
        float total = 0.0f;
        float NumberBuscado = 0.0f;
        bool numberencontrado;
        int valorMenu=0;
        int countArray =0;
        float Maximo = 0.0f;
        float Minimo = 0.0f;
       
        do
        {
            Console.WriteLine("1.Añadir nuevos datos");
            Console.WriteLine("2.Ver todos los datos introducidos");
            Console.WriteLine("3.Buscar un elemento");
            Console.WriteLine("4.Ver resumen de estadisticas");
            Console.WriteLine("5.Salir");
             
            valorMenu= Convert.ToInt32(Console.ReadLine());
            if (valorMenu != 5)
            {
                switch (valorMenu)
                {
                   case 1:
                        Console.WriteLine("Enter a number: ");
                        numbers[countArray] = Convert.ToSingle( Console.ReadLine());
                        Maximo = numbers[countArray];
                        Minimo = numbers[countArray];
                        total += numbers[countArray];
                        countArray++;
                        if (Maximo<numbers[countArray]) Maximo= "numbers[countArray];" 
                        if (Minimo =>numbers[countArray]);
                            Minimo = numbers[countArray];
                        break;
                   case 2:
                        for (int i=0;i<countArray;i++) Console.Writeline("los="" números="" que="" estan="" son="" {0}="" ",numbers[i]);="" break;="" case="" 3:="" console.writeline("enter="" a="" number="" for="" search:="" ");="" numberbuscado="Convert.ToSingle(" console.readline());="" (int="" i="0;i<countArray;i++)" if="" (numbers[i]="=" numberbuscado)="" numberencontrado="true;" (numberencontrado)="" console.writeline("el="" numero="" lo="" e="" encontrado="" {1}="" veces",="" numbers[i]);="" else="" {="" no="" esta");="" }="" 4:="" console.writeline("cantidad="" de="" datos:="" {0}",="" countarray+1);="" console.writeline("suma="" los="" total);="" console.writeline("promedio="" total="" (countarray+1));="" console.writeline("minimo:="" {0}",minimo);="" console.writeline("maximo:="" {0}",maximo);="" default:="" console.writeline("intoduzca="" un="" número="" del="" 1="" al="" 5");="" while(valormenu!="5);" <="" pre="">
<hr>
<div style="clear: both;"></div>
</countarray;i++)></numbers[countarray])>
        }
    }
}

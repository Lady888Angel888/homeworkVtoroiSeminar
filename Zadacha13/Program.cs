Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int result = 0;
             if(number>=100)
             {
                while(number > 999)
                {
                    number=number/10;
                }
                result=number%10;
                Console.WriteLine("третья цифра -> " + result);
             }else
             {
                Console.WriteLine("третьей цифры нет");
             }





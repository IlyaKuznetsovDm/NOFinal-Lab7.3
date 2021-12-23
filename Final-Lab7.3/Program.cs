namespace lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Информация о сотрудниках");
            Console.WriteLine("-------------------------");
            int n=0;
            Person[] person = new Person[n];
            Person Юлия = new();
            Person Андрей = new Person { fio = "Калишенко Андрей Алексеевич", god_rozjdeniya = 1999 , dolzjnost = "веб-дизайнер", zarplata= 54200 };
            Person Алена = new Person { fio = "Сидоренко Алена Васильевна", god_rozjdeniya = 2002, dolzjnost = "повар", zarplata = 28184 };
            Person Светлана = new Person { fio = "Бобова Светлана Викторовна", god_rozjdeniya = 1987, dolzjnost = "кондитер", zarplata = 33875 };
            Person Илья = new Person { fio = "Комисар Илья Георгиевич", god_rozjdeniya = 1991, dolzjnost = "менеджер по продажам", zarplata = 27913 };
            Person Данил = new Person { fio = "Мищак Данил Денисович", god_rozjdeniya = 1998, dolzjnost = "политоло", zarplata = 42818 };
            Person Евгений = new Person { fio = "Зубко Евгений Захарович", god_rozjdeniya = 2002, dolzjnost = "культуролог", zarplata = 34688 };
            Person Ян = new Person { fio = "Шевчук Ян Игоревич", god_rozjdeniya = 2000, dolzjnost = "логист", zarplata = 38482 };
            Person Лев = new Person { fio = "Ящук Лев Макарович", god_rozjdeniya = 1995, dolzjnost = "HR-менеджер", zarplata = 63414 };
           
            
            Юлия.Print();
            Андрей.Print();
            Алена.Print();
            Светлана.Print();
            Илья.Print();
            Евгений.Print();
            Андрей.Print();
            Ян.Print();
            Лев.Print();
            Console.WriteLine("-------------------------");

            {
               
                Console.WriteLine("Самый младший сотрудник и информация о нем:");
                Console.WriteLine("Фио: {0} \nГод рождения: {1}\nДолжность: {2}\nЗарплата: {3}", Юлия.fio, Юлия.god_rozjdeniya, Юлия.dolzjnost, Юлия.zarplata);
            }

        }

            struct Person
        {

            public string fio;
            public int god_rozjdeniya;
            public string dolzjnost;
            public int zarplata;


            public Person() : this("")
            { }
            public Person(string name) : this(name, 1)
            { }
            public Person(string name, int age)
            {
                fio = "Ситько Юлия Максимовна";
                god_rozjdeniya = 1990;
                dolzjnost = "IT-менеджер";
                zarplata = 54200 ;

            }

         


            public void Print() => Console.WriteLine($"Фио: {fio} Год рождения: {god_rozjdeniya} Должность: {dolzjnost} Зарплата: {zarplata} Руб");

            


        }

    }

       
    }
            

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Напишите 1 для продолжения");
        //    int a;
        //    a = Convert.ToInt32(Console.ReadLine());
        //    switch (a)
        //    {
        //        case 1:
        //            Console.WriteLine("Информация");
        //            Console.WriteLine("----------");
        //            Book[] X = new Book[10];
        //            X[0].fio = "Сидоров Антон Дмитриевич";
        //            X[0].god_rozjdeniya = 1984;
        //            X[0].dolzjnost = " [бухгалтер]- ";
        //            X[0].zarplata = 29810;

        //            X[1] = new Book("Ситько Юлия Максимовна", 2003, " [IT-менеджер]- ", 54200);
        //            X[2] = new Book("Калишенко Андрей Алексеевич", 1999, " [веб-дизайнер]- ", 51490);
        //            X[3] = new Book("Сидоренко Алена Васильевна", 2002, " [повар]- ", 28184);
        //            X[4] = new Book("Бобова Светлана Викторовна", 1987, " [кондитер]- ", 33875);
        //            X[5] = new Book("Комисар Илья Георгиевич", 1991, " [менеджер по продажам]- ", 27913);
        //            X[6] = new Book("Мищак Данил Денисович", 1998, " [политолог]- ", 42818);
        //            X[7] = new Book("Зубко Евгений Захарович", 2002, " [культуролог]- ", 34688);
        //            X[8] = new Book("Шевчук Ян Игоревич", 2000, " [логист]- ", 38482);
        //            X[9] = new Book("Ящук Лев Макарович", 1995, " [HR-менеджер]- ", 63414);
        //            {
        //                for (int i = 0; i <= 9; i++)
        //                {
        //                    Console.WriteLine(X[i].fio + ": " + X[i].god_rozjdeniya + " год " + X[i].dolzjnost + X[i].zarplata + " руб");

        //                }
        //            }
        //            double max = X[0].god_rozjdeniya;
        //            int z = 0;
        //            for (int i = 0; i < X.Length; i++)
        //            {
        //                if (X[i].god_rozjdeniya > max)
        //                {
        //                    max = X[i].god_rozjdeniya;
        //                    z = i;
        //                }
        //            }
        //            Console.WriteLine("---------------------------------------------");
        //            Console.WriteLine("Самый младший сотрудник и информация о нем:");
        //            Console.WriteLine("Фио: {0} \nГод рождения: {1}\nДолжность: {2}\nЗарплата: {3}", X[z].fio, X[z].god_rozjdeniya, X[z].dolzjnost, X[z].zarplata);

        //            break;



        //    }

        //}



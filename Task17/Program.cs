using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Task17;
using Task17.Classes;

namespace Task17;
class Program
{
    static async Task Main(string[] args)
    {

        Console.WriteLine("Практическая работа номер 17");
        Console.WriteLine("Выберите номер задания 1-78:");
        int inPut = Convert.ToInt32(Console.ReadLine());
        switch (inPut)
        {
            case 1:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input = Console.ReadLine();

                VectorProcessor v = new VectorProcessor();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice = int.Parse(Console.ReadLine());

                bool isAccepted = v.IsAccepted(input, directionChoice == 1, criterionChoice == 1);

                if (isAccepted)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 2:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input2 = Console.ReadLine();

                VectorProcessor2 v2 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice2 = int.Parse(Console.ReadLine());

                bool isAccepted2 = v2.IsAccepted(input2, directionChoice2 == 1, criterionChoice2 == 1);

                if (isAccepted2)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 3:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input3 = Console.ReadLine();

                VectorProcessor3 v3 = new VectorProcessor3();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice3 = int.Parse(Console.ReadLine());

                bool isAccepted3 = v3.IsAccepted(input3, directionChoice3 == 1, criterionChoice3 == 1);

                if (isAccepted3)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input4 = Console.ReadLine();

                VectorProcessor4 v4 = new VectorProcessor4();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice4 = int.Parse(Console.ReadLine());

                bool isAccepted4 = v4.IsAccepted(input4, directionChoice4 == 1, criterionChoice4 == 1);

                if (isAccepted4)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 5:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input5 = Console.ReadLine();

                VectorProcessor5 v5 = new VectorProcessor5();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice5 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice5 = int.Parse(Console.ReadLine());

                bool isAccepted5 = v5.IsAccepted(input5, directionChoice5 == 1, criterionChoice5 == 1);

                if (isAccepted5)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 6:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input6 = Console.ReadLine();

                VectorProcessor2 v6 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice6 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice6 = int.Parse(Console.ReadLine());

                bool isAccepted6 = v6.IsAccepted(input6, directionChoice6 == 1, criterionChoice6 == 1);

                if (isAccepted6)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 7:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input7 = Console.ReadLine();

                VectorProcessor2 v7 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice7 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice7 = int.Parse(Console.ReadLine());

                bool isAccepted7 = v7.IsAccepted(input7, directionChoice7 == 1, criterionChoice7 == 1);

                if (isAccepted7)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 8:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input8 = Console.ReadLine();

                VectorProcessor2 v8 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice8 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice8 = int.Parse(Console.ReadLine());

                bool isAccepted8 = v8.IsAccepted(input8, directionChoice8 == 1, criterionChoice8 == 1);

                if (isAccepted8)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 9:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input9 = Console.ReadLine();

                VectorProcessor2 v9 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice9 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice9 = int.Parse(Console.ReadLine());

                bool isAccepted9 = v9.IsAccepted(input9, directionChoice9 == 1, criterionChoice9 == 1);

                if (isAccepted9)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;

                case 10:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input10 = Console.ReadLine();

                VectorProcessor2 v10 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice10 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice10 = int.Parse(Console.ReadLine());

                bool isAccepted10 = v10.IsAccepted(input10, directionChoice10 == 1, criterionChoice10 == 1);

                if (isAccepted10)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;

                case 11:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input11 = Console.ReadLine();

                VectorProcessor2 v11 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice11 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice11 = int.Parse(Console.ReadLine());

                bool isAccepted11 = v11.IsAccepted(input11, directionChoice11 == 1, criterionChoice11 == 1);

                if (isAccepted11)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
                case 12:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input12 = Console.ReadLine();

                VectorProcessor2 v12 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice12 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice12 = int.Parse(Console.ReadLine());

                bool isAccepted12 = v12.IsAccepted(input12, directionChoice12 == 1, criterionChoice12 == 1);

                if (isAccepted12)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
                case 13:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input13 = Console.ReadLine();

                VectorProcessor2 v13 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice13 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice13 = int.Parse(Console.ReadLine());

                bool isAccepted13 = v13.IsAccepted(input13, directionChoice13 == 1, criterionChoice13 == 1);

                if (isAccepted13)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 14:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input14 = Console.ReadLine();

                VectorProcessor2 v14 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice14 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice14 = int.Parse(Console.ReadLine());

                bool isAccepted14 = v14.IsAccepted(input14, directionChoice14 == 1, criterionChoice14 == 1);

                if (isAccepted14)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 15:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input15 = Console.ReadLine();

                VectorProcessor2 v15 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice15 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice15 = int.Parse(Console.ReadLine());

                bool isAccepted15 = v15.IsAccepted(input15, directionChoice15 == 1, criterionChoice15 == 1);

                if (isAccepted15)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 16:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input16 = Console.ReadLine();

                VectorProcessor2 v16 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice16 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice16 = int.Parse(Console.ReadLine());

                bool isAccepted16 = v16.IsAccepted(input16, directionChoice16 == 1, criterionChoice16 == 1);

                if (isAccepted16)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 17:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input17 = Console.ReadLine();

                VectorProcessor2 v17 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice17 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice17 = int.Parse(Console.ReadLine());

                bool isAccepted17 = v17.IsAccepted(input17, directionChoice17 == 1, criterionChoice17 == 1);

                if (isAccepted17)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
             
                case 18:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input18 = Console.ReadLine();

                VectorProcessor2 v18 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice18 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice18 = int.Parse(Console.ReadLine());

                bool isAccepted18 = v18.IsAccepted(input18, directionChoice18 == 1, criterionChoice18 == 1);

                if (isAccepted18)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


                case 19:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input19 = Console.ReadLine();

                VectorProcessor2 v19 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice19 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice19 = int.Parse(Console.ReadLine());

                bool isAccepted19 = v19.IsAccepted(input19, directionChoice19 == 1, criterionChoice19 == 1);

                if (isAccepted19)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


                case 20:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input20 = Console.ReadLine();

                VectorProcessor2 v20 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice20 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice20 = int.Parse(Console.ReadLine());

                bool isAccepted20 = v20.IsAccepted(input20, directionChoice20 == 1, criterionChoice20 == 1);

                if (isAccepted20)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;


                case 21:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input21 = Console.ReadLine();

                VectorProcessor2 v21 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice21 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice21 = int.Parse(Console.ReadLine());

                bool isAccepted21 = v21.IsAccepted(input21, directionChoice21 == 1, criterionChoice21 == 1);

                if (isAccepted21)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;



                case 22:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input22 = Console.ReadLine();

                VectorProcessor2 v22 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice22 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice22 = int.Parse(Console.ReadLine());

                bool isAccepted22 = v22.IsAccepted(input22, directionChoice22 == 1, criterionChoice22 == 1);

                if (isAccepted22)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;


                case 23:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input23 = Console.ReadLine();

                VectorProcessor2 v23 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice23 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice23 = int.Parse(Console.ReadLine());

                bool isAccepted23 = v23.IsAccepted(input23, directionChoice23 == 1, criterionChoice23 == 1);

                if (isAccepted23)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


                case 24:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input24 = Console.ReadLine();

                VectorProcessor2 v24 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice24 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice24 = int.Parse(Console.ReadLine());

                bool isAccepted24 = v24.IsAccepted(input24, directionChoice24 == 1, criterionChoice24 == 1);

                if (isAccepted24)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;


                case 25:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input25 = Console.ReadLine();

                VectorProcessor2 v25 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice25 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice25 = int.Parse(Console.ReadLine());

                bool isAccepted25 = v25.IsAccepted(input25, directionChoice25 == 1, criterionChoice25 == 1);

                if (isAccepted25)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;


                case 26:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input26 = Console.ReadLine();

                VectorProcessor2 v26 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice26 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice26 = int.Parse(Console.ReadLine());

                bool isAccepted26 = v26.IsAccepted(input26, directionChoice26 == 1, criterionChoice26 == 1);

                if (isAccepted26)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                break;


                case 27:
                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input27 = Console.ReadLine();

                VectorProcessor2 v27 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice27 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice27 = int.Parse(Console.ReadLine());

                bool isAccepted27 = v27.IsAccepted(input27, directionChoice27 == 1, criterionChoice27 == 1);

                if (isAccepted27)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


                case 28:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input28 = Console.ReadLine();

                VectorProcessor2 v28 = new VectorProcessor2();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice28 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice28 = int.Parse(Console.ReadLine());

                bool isAccepted28 = v28.IsAccepted(input28, directionChoice28 == 1, criterionChoice28 == 1);

                if (isAccepted28)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 29:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input29 = Console.ReadLine();

                VectorProcessor29 v29 = new VectorProcessor29();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice29 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice29 = int.Parse(Console.ReadLine());

                bool isAccepted29 = v29.IsAccepted(input29, directionChoice29 == 1, criterionChoice29 == 1);

                if (isAccepted29)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

                case 30:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input30 = Console.ReadLine();

                VectorProcessor30 v30 = new VectorProcessor30();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice30 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice30 = int.Parse(Console.ReadLine());

                bool isAccepted30 = v30.IsAccepted(input30, directionChoice30 == 1, criterionChoice30 == 1);

                if (isAccepted30)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 31:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input31 = Console.ReadLine();

                VectorProcessor31 v31 = new VectorProcessor31();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice31 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice31 = int.Parse(Console.ReadLine());

                bool isAccepted31 = v31.IsAccepted(input31, directionChoice31 == 1, criterionChoice31 == 1);

                if (isAccepted31)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 32:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input32 = Console.ReadLine();

                VectorProcessor32 v32 = new VectorProcessor32();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice32 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice32 = int.Parse(Console.ReadLine());

                bool isAccepted32 = v32.IsAccepted(input32, directionChoice32 == 1, criterionChoice32 == 1);

                if (isAccepted32)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 33:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input33 = Console.ReadLine();

                VectorProcessor33 v33 = new VectorProcessor33();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice33 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice33 = int.Parse(Console.ReadLine());

                bool isAccepted33 = v33.IsAccepted(input33, directionChoice33 == 1, criterionChoice33 == 1);

                if (isAccepted33)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 34:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input34 = Console.ReadLine();

                VectorProcessor34 v34 = new VectorProcessor34();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice34 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice34 = int.Parse(Console.ReadLine());

                bool isAccepted34 = v34.IsAccepted(input34, directionChoice34 == 1, criterionChoice34 == 1);

                if (isAccepted34)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 35:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input35 = Console.ReadLine();

                VectorProcessor35 v35 = new VectorProcessor35();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice35 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice35 = int.Parse(Console.ReadLine());

                bool isAccepted35 = v35.IsAccepted(input35, directionChoice35 == 1, criterionChoice35 == 1);

                if (isAccepted35)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 36:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input36 = Console.ReadLine();

                VectorProcessor36 v36 = new VectorProcessor36();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice36 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice36 = int.Parse(Console.ReadLine());

                bool isAccepted36 = v36.IsAccepted(input36, directionChoice36 == 1, criterionChoice36 == 1);

                if (isAccepted36)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 37:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input37 = Console.ReadLine();

                VectorProcessor37 v37 = new VectorProcessor37();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice37 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice37 = int.Parse(Console.ReadLine());

                bool isAccepted37 = v37.IsAccepted(input37, directionChoice37 == 1, criterionChoice37 == 1);

                if (isAccepted37)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 38:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input38 = Console.ReadLine();

                VectorProcessor38 v38 = new VectorProcessor38();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice38 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice38 = int.Parse(Console.ReadLine());

                bool isAccepted38 = v38.IsAccepted(input38, directionChoice38 == 1, criterionChoice38 == 1);

                if (isAccepted38)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 39:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input39 = Console.ReadLine();

                VectorProcessor39 v39 = new VectorProcessor39();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice39 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice39 = int.Parse(Console.ReadLine());

                bool isAccepted39 = v39.IsAccepted(input39, directionChoice39 == 1, criterionChoice39 == 1);

                if (isAccepted39)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 40:

                Console.WriteLine("Введите строку для проверки (символы 'a', 'b' или бинарные последовательности):");
                string input40 = Convert.ToString(Console.ReadLine());
                VectorProcessor40 v40 = new VectorProcessor40();
                Console.WriteLine("Выберите направление обработки:");
                Console.WriteLine("1 - Символьный режим (a/b)");
                Console.WriteLine("2 - Бинарный режим (010/110)");
                int modeChoice40 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Четность суммы");
                Console.WriteLine("2 - Соответствие шаблону состояний");
                int criterionChoice40 = int.Parse(Console.ReadLine());

                if (v40.IsAccepted(input40, modeChoice40 == 1, criterionChoice40 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 41:

                Console.WriteLine("Введите строку для проверки (символы 'a' или 'b'):");
                string input41 = Console.ReadLine();

                VectorProcessor41 v41 = new VectorProcessor41();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice41 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice41 = int.Parse(Console.ReadLine());

                bool isAccepted41 = v41.IsAccepted(input41, directionChoice41 == 1, criterionChoice41 == 1);

                if (isAccepted41)
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 42:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c'):");
                string input42 = Console.ReadLine();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice42 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия строки:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice42 = int.Parse(Console.ReadLine());

                var processor = new VectorProcessor42();

                if (processor.IsAccepted(input42, directionChoice42 == 1, criterionChoice42 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 43:

                Console.WriteLine("Введите строку для проверки (символы 'b'-'c' или бинарные последовательности):");
                string input43 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (b/c)");
                Console.WriteLine("2 - Бинарный режим (110, 0110 и др.)");
                int modeChoice43 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По четности единиц");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice43 = int.Parse(Console.ReadLine());

                var processor43 = new VectorProcessor();

                if (processor43.IsAccepted(input43, modeChoice43 == 1, criterionChoice43 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 44:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input44 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (010110, 0100, 1101)");
                int modeChoice44 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По четности единиц");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice44 = int.Parse(Console.ReadLine());

                var processor44 = new VectorProcessor();

                if (processor44.IsAccepted(input44, modeChoice44 == 1, criterionChoice44 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();

                Console.ReadKey();
                break;
            case 45:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input45 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (11000, 0111, 11101)");
                int modeChoice45 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству нулей");
                Console.WriteLine("2 - По паттерну переходов");
                int criterionChoice45 = int.Parse(Console.ReadLine());

                var processor45 = new VectorProcessor45();

                if (processor45.IsAccepted(input45, modeChoice45 == 1, criterionChoice45 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 46:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input46 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим");
                int modeChoice46 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме битов");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice46 = int.Parse(Console.ReadLine());

                var processor46 = new VectorProcessor46();

                if (processor46.IsAccepted(input46, modeChoice46 == 1, criterionChoice46 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 47:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input47 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (1110, 0101 и др.)");
                int modeChoice47 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По четности единиц");
                Console.WriteLine("2 - По паттерну переходов");
                int criterionChoice47 = int.Parse(Console.ReadLine());

                var processor47 = new VectorProcessor47();

                if (processor47.IsAccepted(input47, modeChoice47 == 1, criterionChoice47 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 48:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input48 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (1110, 0101 и др.)");
                int modeChoice48 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По четности единиц");
                Console.WriteLine("2 - По паттерну переходов");
                int criterionChoice48 = int.Parse(Console.ReadLine());

                var processor48 = new VectorProcessor47();

                if (processor48.IsAccepted(input48, modeChoice48 == 1, criterionChoice48 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 49:

                Console.WriteLine("Введите бинарную последовательность:");
                string input49 = Console.ReadLine();

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice49 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме элементов");
                Console.WriteLine("2 - По максимальному элементу");
                int criterionChoice49 = int.Parse(Console.ReadLine());

                var validator49 = new VectorProcessor48();

                if (validator49.IsAccepted(input49, directionChoice49 == 1, criterionChoice49 == 1))
                {
                    Console.WriteLine("Последовательность принята.");
                }
                else
                {
                    Console.WriteLine("Последовательность отклонена.");
                }

                Console.ReadKey();
                break;
            case 50:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'f' или бинарные последовательности):");
                string input50 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-f)");
                Console.WriteLine("2 - Бинарный режим (01010, 011 и др.)");
                int modeChoice50 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice50 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме битов");
                Console.WriteLine("2 - По паттерну состояний");
                int criterionChoice50 = int.Parse(Console.ReadLine());

                var processor50 = new VectorProcessor50();

                if (processor50.IsAccepted(input50, modeChoice50 == 1, directionChoice50 == 1, criterionChoice50 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
        
    

                break;
            case 51:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input51 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/c)");
                Console.WriteLine("2 - Бинарный режим (10, 0101 и др.)");
                int modeChoice51 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice51 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству переходов");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice51 = int.Parse(Console.ReadLine());

                var processor51 = new VectorProcessor51();

                if (processor51.IsAccepted(input51, modeChoice51 == 1, directionChoice51 == 1, criterionChoice51 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 52:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input52 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/c)");
                Console.WriteLine("2 - Бинарный режим (10, 0101 и др.)");
                int modeChoice52 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice52 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству переходов");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice52 = int.Parse(Console.ReadLine());

                var processor52 = new VectorProcessor52();

                if (processor52.IsAccepted(input52, modeChoice52 == 1, directionChoice52 == 1, criterionChoice52 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 53:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input53 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-c)");
                Console.WriteLine("2 - Бинарный режим (0101, 11010 и др.)");
                int modeChoice53 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice53 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме битов");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice53 = int.Parse(Console.ReadLine());

                var validator53 = new VectorProcessor53();

                if (validator53.IsAccepted(input53, modeChoice53 == 1, directionChoice53 == 1, criterionChoice53 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 54:
                Console.WriteLine("Введите строку для проверки (символ 'c' или бинарные последовательности):");
                string input54 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (только 'c')");
                Console.WriteLine("2 - Бинарный режим (0101, 110 и др.)");
                int modeChoice54 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice54 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству переходов между состояниями");
                Console.WriteLine("2 - По конечному состоянию");
                int criterionChoice54 = int.Parse(Console.ReadLine());

                var validator54 = new VectorProcessor54();

                if (validator54.IsAccepted(input54, modeChoice54 == 1, directionChoice54 == 1, criterionChoice54 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 55:
                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input55 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (0100, 0111 и др.)");
                int modeChoice55 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice55 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству нулей");
                Console.WriteLine("2 - По паттерну переходов");
                int criterionChoice55 = int.Parse(Console.ReadLine());

                var validator55 = new VectorProcessor55();

                if (validator55.IsAccepted(input55, modeChoice55 == 1, directionChoice55 == 1, criterionChoice55 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 56:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input56 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (111, 0100 и др.)");
                int modeChoice56 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice56 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме битов");
                Console.WriteLine("2 - По максимальной последовательности единиц");
                int criterionChoice56 = int.Parse(Console.ReadLine());

                var validator56 = new VectorProcessor56();

                if (validator56.IsAccepted(input56, modeChoice56 == 1, directionChoice56 == 1, criterionChoice56 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 57:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input57 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (0110, 110 и др.)");
                int modeChoice57 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice57 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству переходов 0→1");
                Console.WriteLine("2 - По чередованию состояний");
                int criterionChoice57 = int.Parse(Console.ReadLine());

                var validator57 = new VectorProcessor57();

                if (validator57.IsAccepted(input57, modeChoice57 == 1, directionChoice57 == 1, criterionChoice57 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 58:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input58 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (011, 110 и др.)");
                int modeChoice58 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice58 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству пар 01");
                Console.WriteLine("2 - По соответствию шаблону переходов");
                int criterionChoice58 = int.Parse(Console.ReadLine());

                var validator58 = new VectorProcessor58();

                if (validator58.IsAccepted(input58, modeChoice58 == 1, directionChoice58 == 1, criterionChoice58 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 59:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input59 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (011, 110 и др.)");
                int modeChoice59 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice59 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству изменений состояния");
                Console.WriteLine("2 - По четности единиц");
                int criterionChoice59 = int.Parse(Console.ReadLine());

                var validator = new VectorProcessor59();

                if (validator.IsAccepted(input59, modeChoice59 == 1, directionChoice59 == 1, criterionChoice59 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 60:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или бинарные последовательности):");
                string input60 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a/b/c)");
                Console.WriteLine("2 - Бинарный режим (0100, 1111 и др.)");
                int modeChoice60 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice60 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По количеству нулей");
                Console.WriteLine("2 - По паттерну переходов");
                int criterionChoice60 = int.Parse(Console.ReadLine());

                var validator60 = new VectorProcessor60();

                if (validator60.IsAccepted(input60, modeChoice60 == 1, directionChoice60 == 1, criterionChoice60 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 61:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'f' или бинарные последовательности):");
                string input61 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-f)");
                Console.WriteLine("2 - Бинарный режим (01010, 11110 и др.)");
                int modeChoice61 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice61 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме битов");
                Console.WriteLine("2 - По специальному символу Ø");
                int criterionChoice61 = int.Parse(Console.ReadLine());

                var validator61 = new VectorProcessor61();

                if (validator61.IsAccepted(input61, modeChoice61 == 1, directionChoice61 == 1, criterionChoice61 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 62:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'f' или бинарные последовательности):");
                string input62 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-f)");
                Console.WriteLine("2 - Бинарный режим (01010, 11110 и др.)");
                int modeChoice62 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите направление обхода:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice62 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - По сумме битов");
                Console.WriteLine("2 - По специальному символу Ø");
                int criterionChoice62 = int.Parse(Console.ReadLine());

                var validator62 = new VectorProcessor61();

                if (validator62.IsAccepted(input62, modeChoice62 == 1, directionChoice62 == 1, criterionChoice62 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 63:

                Console.WriteLine("Введите строку (символы 'a'-'b' или последовательности):");
                string input63 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Прямой ввод последовательностей");
                int modeChoice63 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Завершение в состоянии 2");
                Console.WriteLine("2 - Наличие вертикальной черты '|'");
                int criterionChoice63 = int.Parse(Console.ReadLine());

                var validator63 = new VectorProcessor63();

                if (validator63.IsAccepted(input63, modeChoice63 == 1, criterionChoice63 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 64:
                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или числовые последовательности):");
                string input64 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Числовой режим (0111, 2122 и др.)");
                int modeChoice64 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит последовательность '00'");
                Console.WriteLine("2 - Сумма цифр равна 4");
                int criterionChoice64 = int.Parse(Console.ReadLine());

                var validator64 = new VectorProcessor64();

                if (validator64.IsAccepted(input64, modeChoice64 == 1, criterionChoice64 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 65:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или числовые последовательности):");
                string input65 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Числовой режим (0110, 1120 и др.)");
                int modeChoice65 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Сумма цифр кратна 3");
                Console.WriteLine("2 - Все цифры одинаковые");
                int criterionChoice65 = int.Parse(Console.ReadLine());

                var validator65 = new VectorProcessor65();

                if (validator65.IsAccepted(input65, modeChoice65 == 1, criterionChoice65 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 66:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или последовательности с разделителем '|'):");
                string input66 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Прямой ввод последовательностей");
                int modeChoice66 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Левая часть равна правой после обработки");
                Console.WriteLine("2 - Содержит комбинацию '0|0'");
                int criterionChoice66 = int.Parse(Console.ReadLine());

                var validator66 = new VectorProcessor66();

                if (validator66.IsAccepted(input66, modeChoice66 == 1, criterionChoice66 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 67:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или числовые последовательности):");
                string input67 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Числовой режим (112, 0 1 1 и др.)");
                int modeChoice67 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит специальный символ 'ⓒ'");
                Console.WriteLine("2 - Сумма чисел равна 5");
                int criterionChoice67 = int.Parse(Console.ReadLine());

                var validator67 = new VectorProcessor67();

                if (validator67.IsAccepted(input67, modeChoice67 == 1, criterionChoice67 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 68:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или числовые последовательности):");
                string input68 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Числовой режим (0111, 210 и др.)");
                int modeChoice68 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Последовательность заканчивается на '0'");
                Console.WriteLine("2 - Содержит комбинацию '11'");
                int criterionChoice68 = int.Parse(Console.ReadLine());

                var validator68 = new VectorProcessor68();

                if (validator68.IsAccepted(input68, modeChoice68 == 1, criterionChoice68 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 69:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или числовые последовательности):");
                string input69 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Числовой режим (0111, 1122 и др.)");
                int modeChoice69 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит более трех '1' подряд");
                Console.WriteLine("2 - Сумма цифр равна 5");
                int criterionChoice69 = int.Parse(Console.ReadLine());

                var validator69 = new VectorProcessor69();

                if (validator69.IsAccepted(input69, modeChoice69 == 1, criterionChoice69 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;
            case 70:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или числовые последовательности):");
                string input70 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Числовой режим (0111, 2121 и др.)");
                int modeChoice70 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Последовательность заканчивается на '0'");
                Console.WriteLine("2 - Содержит комбинацию '11'");
                int criterionChoice70 = int.Parse(Console.ReadLine());

                var validator70 = new VectorProcessor70();

                if (validator70.IsAccepted(input70, modeChoice70 == 1, criterionChoice70 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

            case 71:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или числовые последовательности):");
                string input71 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-c)");
                Console.WriteLine("2 - Числовой режим (012, 2100 и др.)");
                int modeChoice71 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит комбинацию '10'");
                Console.WriteLine("2 - Сумма цифр равна 4");
                int criterionChoice71 = int.Parse(Console.ReadLine());

                var validator71 = new VectorProcessor71();

                if (validator71.IsAccepted(input71, modeChoice71 == 1, criterionChoice71 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


            case 72:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'c' или последовательности с разделителем '|'):");
                string input72 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-c)");
                Console.WriteLine("2 - Прямой ввод последовательностей");
                int modeChoice72 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит специальный символ 'Ø'");
                Console.WriteLine("2 - Левая часть равна правой после обработки");
                int criterionChoice72 = int.Parse(Console.ReadLine());

                var validator72 = new VectorProcessor72();

                if (validator72.IsAccepted(input72, modeChoice72 == 1, criterionChoice72 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


            case 73:

                Console.WriteLine("Введите строку для проверки (символы 'b'-'c' или числовые последовательности):");
                string input73 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (b-c)");
                Console.WriteLine("2 - Числовой режим (2111, 012 и др.)");
                int modeChoice73 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит три '1' подряд");
                Console.WriteLine("2 - Сумма цифр кратна 3");
                int criterionChoice73 = int.Parse(Console.ReadLine());

                var validator73 = new VectorProcessor73();

                if (validator73.IsAccepted(input73, modeChoice73 == 1, criterionChoice73 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


            case 74:

                Console.WriteLine("Введите последовательность букв (например, 'aba'):");
                string input74 = Console.ReadLine().ToLower();

                Console.WriteLine("Выберите направление:");
                Console.WriteLine("1 - По часовой стрелке");
                Console.WriteLine("2 - Против часовой стрелки");
                int directionChoice74 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий:");
                Console.WriteLine("1 - По среднему значению");
                Console.WriteLine("2 - По максимальному значению");
                int criterionChoice74 = int.Parse(Console.ReadLine());

                VectorProcessor74 processor74 = new VectorProcessor74();
                bool isAccepted74 = processor74.IsAccepted(input74, directionChoice74 == 1, criterionChoice74 == 1);

                Console.WriteLine(isAccepted74 ? "Последовательность принята" : "Последовательность отклонена");
                break;

            case 75:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или бинарные последовательности):");
                string input75 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Бинарный режим (11010, 0010 и др.)");
                int modeChoice75 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит '101' как подстроку");
                Console.WriteLine("2 - Сбалансировано по количеству 0 и 1 (разница ≤ 1)");
                int criterionChoice75 = int.Parse(Console.ReadLine());

                var validator75 = new VectorProcessor75();

                if (validator75.IsAccepted(input75, modeChoice75 == 1, criterionChoice75 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


            case 76:
                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или бинарные последовательности):");
                string input76 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Бинарный режим (1110, 0101 и др.)");
                int modeChoice76 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит '00' и '11'");
                Console.WriteLine("2 - Сумма единиц кратна 3");
                int criterionChoice76 = int.Parse(Console.ReadLine());

                var validator76 = new VectorProcessor76();

                if (validator76.IsAccepted(input76, modeChoice76 == 1, criterionChoice76 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


            case 77:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или бинарные последовательности):");
                string input77 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Бинарный режим (001101, 101010 и др.)");
                int modeChoice77 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Строка симметрична (палиндром)");
                Console.WriteLine("2 - Чередование 0 и 1 без повторений");
                int criterionChoice77 = int.Parse(Console.ReadLine());

                var validator77 = new VectorProcessor77();

                if (validator77.IsAccepted(input77, modeChoice77 == 1, criterionChoice77 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;


            case 78:

                Console.WriteLine("Введите строку для проверки (символы 'a'-'b' или бинарные последовательности):");
                string input78 = Console.ReadLine();

                Console.WriteLine("Выберите режим работы:");
                Console.WriteLine("1 - Символьный режим (a-b)");
                Console.WriteLine("2 - Бинарный режим (11, 00111 и др.)");
                int modeChoice78 = int.Parse(Console.ReadLine());

                Console.WriteLine("Выберите критерий принятия:");
                Console.WriteLine("1 - Содержит '0110' как подстроку");
                Console.WriteLine("2 - Имеет одинаковое количество '0' и '1'");
                int criterionChoice78 = int.Parse(Console.ReadLine());

                var validator78 = new VectorProcessor78();

                if (validator78.IsAccepted(input78, modeChoice78 == 1, criterionChoice78 == 1))
                {
                    Console.WriteLine("Строка принята.");
                }
                else
                {
                    Console.WriteLine("Строка отклонена.");
                }

                Console.ReadKey();
                break;

        }
    }
}

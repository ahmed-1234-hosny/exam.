using System.Numerics;
using System.Text;
namespace examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            show sh = new show();

            Console.WriteLine("Hello .. Welcom To In The School Mamgment .. \n");
            while (true)
            {
                Console.WriteLine("please enter the num to beggin ");
                Console.WriteLine("1 ==> signe up ..");
                Console.WriteLine("2 ==> creat account ..");
                int responde = int.Parse(Console.ReadLine());
                switch (responde)
                {
                    case 1:
                        Console.WriteLine("are you student or teacher :");
                        string gg = Console.ReadLine();
                        if (gg == "student")
                        {
                            sh.check_stud();
                        }
                        else if (gg == "teach")
                        {
                            sh.check_teach();
                        }
                        else
                        {
                            Console.WriteLine("unknown choise ");
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine(" are you teacher or student ??");
                            string re = Console.ReadLine().ToLower();
                            switch (re)
                            {
                                case "student":
                                    sh.stud_info();

                                    break;

                                case " teacher":
                                    sh.teach_info();

                                    break;
                                default:
                                    Console.WriteLine("Unknown Choise ..");
                                    Console.WriteLine("Try again ");
                                    break;
                            }
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown Choise ..");
                        Console.WriteLine("Try again \n");
                        break;
                }
                Console.WriteLine("do you want do any operation yes or no  :");
                string res = Console.ReadLine();
                if (res == "yes")
                {
                    Console.WriteLine("ok\n");
                }
                else if (res == "no")
                {
                    Console.WriteLine("Thank you to use my application ..");
                    return;
                }
                else
                {
                    Console.WriteLine("ynknown choise ..");
                    Console.WriteLine("try again .. ");
                }
            }
        }
    }
    class info : exam
    {
        public string stud_name;
        public string stud_id;
        public string stud_depa;
        public string stud_password;
        public string stud_email;
        public string teach_name;
        public string teach_id;
        public string teach_depa;
        public string teach_password;
        public string teach_email;
        public string stud_info()
        {
            Console.WriteLine("enter your name :");
            stud_name = Console.ReadLine();
            Console.WriteLine("enter your id :");
            stud_id = Console.ReadLine();
            Console.WriteLine(" enter your department :");
            stud_depa = Console.ReadLine();
            Console.WriteLine("enter email to creat an acount ");
            stud_email = Console.ReadLine();
            Console.WriteLine("enter passord : ");
            stud_password = Console.ReadLine();
            return $"";
        }

        public string teach_info()
        {
            Console.WriteLine("enter your name :");
            teach_name = Console.ReadLine();
            Console.WriteLine("enter your id :");
            teach_id = Console.ReadLine();
            Console.WriteLine(" enter your department :");
            teach_depa = Console.ReadLine();
            Console.WriteLine("enter email to creat an acount ");
            stud_email = Console.ReadLine();
            Console.WriteLine("enter passord : ");
            stud_password = Console.ReadLine();
            return $"";
        }
    }
    class show : info
    {
        public string stud_u_pass;
        public string stud_u_email;
        public string teach_u_pass;
        public string teach_u_email;
        public string show_stud()
        {
            Console.WriteLine("hello dear  ");
            Console.WriteLine("information of student : ");
            Console.WriteLine($"name :{stud_name} ");
            Console.WriteLine($"id is : {stud_id}");
            Console.WriteLine($"department : {stud_depa}");
            return $"";
        }
        public string show_teach()
        {
            Console.WriteLine("hello dear  ");
            Console.WriteLine("information of teacher  : ");
            Console.WriteLine($"name :{teach_name} ");
            Console.WriteLine($"id is : {teach_id}");
            Console.WriteLine($"department : {teach_depa}");
            return $"";
        }
        public string check_stud()
        {
            Console.WriteLine("enter your email :");
            stud_u_email = Console.ReadLine();
            Console.WriteLine("enter your password :");
            stud_u_pass = Console.ReadLine();
            if (stud_u_pass == stud_password && stud_u_email == stud_email)
            {
                Console.WriteLine("signe in succesfly.. ");
                show_stud();
            }
            else
            {
                Console.WriteLine("ivalid passord or email adress ..");
            }
            return $"";
        }
        public string check_teach()
        {
            Console.WriteLine("enter your email :");
            teach_u_email = Console.ReadLine();
            Console.WriteLine("enter your password :");
            teach_u_pass = Console.ReadLine();
            if (teach_u_pass == teach_password && teach_u_email == teach_email)
            {
                Console.WriteLine("signe in succesfly.. ");
                show_teach();
            }
            else
            {
                Console.WriteLine("ivalid passord or email adress ..");
            }
            return $"";
        }

        public string check()
        {
            Console.WriteLine("enter your email :");
            teach_u_email = Console.ReadLine();
            Console.WriteLine("enter your password :");
            teach_u_pass = Console.ReadLine();
            if (teach_u_pass == teach_password && teach_u_email == teach_email)
            {
                Console.WriteLine("signe in succesfly.. ");
                show_teach();
                inf_q();
            }
            else if (stud_u_pass == stud_password && stud_u_email == stud_email)
            {
                Console.WriteLine("signe in succesfly.. ");
                show_stud();
                TakeExam();
            }
            else
            {
                Console.WriteLine("ivalid passord or email adress ..");
            }
            return $"";
        }
    }
    class exam : type_qustion
    {
        public int num_q;
        public int deg_q;
        public int type_q;
        public string[] studentAnswers;

        public string inf_q()
        {
            Console.WriteLine("enter the number of question :");
            num_q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num_q; i++)
            {
                Console.WriteLine($"enter the type of qustion{i} :");
                Console.WriteLine("multi choise ==> press 1 ");
                Console.WriteLine("true or false ==> press 2 ");
                type_q = int.Parse(Console.ReadLine());
                Console.WriteLine($"enter the degre of qustion {i} :");
                deg_q = int.Parse(Console.ReadLine());
                switch (type_q)
                {
                    case 1:
                        return Q_multi_choise();
                        break;
                    case 2:
                        return Q_true_false();
                        break;
                    default:
                        Console.WriteLine("unknown choise ..");
                        break;
                }
            }
            return $"";
        }
        public void TakeExam()
        {
            Console.WriteLine("You are taking the exam now!");
            int totalScore = 0;

            for (int i = 0; i < num_q; i++)
            {
                Console.WriteLine($"Question {i + 1}: {QuestionText}");

                if (type_q == 1)
                {
                    Console.WriteLine("A: " + A);
                    Console.WriteLine("B: " + B);
                    Console.WriteLine("C: " + C);
                    Console.WriteLine("Enter your answer (A, B, or C):");
                    studentAnswers[i] = Console.ReadLine().ToUpper();

                    if (studentAnswers[i] == CorrectAnswer.ToString())
                    {
                        Console.WriteLine("Correct!");
                        totalScore += deg_q;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                }
                else if (type_q == 2)
                {
                    Console.WriteLine("Enter your answer (True/False):");
                    studentAnswers[i] = Console.ReadLine().ToLower();

                    if (studentAnswers[i] == CorrectAnswerTF.ToLower())
                    {
                        Console.WriteLine("Correct!");
                        totalScore += deg_q;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                }
            }

            Console.WriteLine($"Your total score is: {totalScore}");
        }

    }
    class type_qustion
    {
        public string A;
        public string B;
        public string C;
        public string QuestionText;
        public char CorrectAnswer;
        public string CorrectAnswerTF;
        public string Q_true_false()
        {
            Console.WriteLine("enter qustion :");
            QuestionText = Console.ReadLine();
            Console.WriteLine("the answer is true or false");
            CorrectAnswerTF = Console.ReadLine();

            return $"";
        }
        public string Q_multi_choise()
        {
            Console.WriteLine("enter question ");
            QuestionText = Console.ReadLine();
            Console.WriteLine("enter three choice ");
            Console.WriteLine("enter A :");
            A = Console.ReadLine();
            Console.WriteLine("enter B :");
            B = Console.ReadLine();
            Console.WriteLine("enter C :");
            C = Console.ReadLine();
            Console.WriteLine("the correct choise is A or B or C :");
            CorrectAnswer = char.Parse(Console.ReadLine());
            return $"";
        }
    }
}
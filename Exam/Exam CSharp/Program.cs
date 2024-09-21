namespace Exam_CSharp;

public static class Program
{
    public static void Main(string[] args)
    {
        #region Get Type Of Exam 

        bool typeFlag;
        int examType;
        do
        {
            Console.WriteLine("PLZ Enter The Type Of Exam (1 For Practical | 2 For Final)");
            typeFlag = int.TryParse(Console.ReadLine(),out examType);
        } while (!typeFlag);


        #endregion
        
        #region  Get Duration Time
        bool timeFlag;
        int time;
        do
        {
            Console.WriteLine("Plz Enter The Time For Exam From (30 to 180 mins)");
            timeFlag =  int.TryParse(Console.ReadLine(),out time);
        } while (!timeFlag);
        #endregion
        
        #region Get Number Of Ques

        bool flagNumberQues;
        int numberOfQuestions;
        do
        {
            Console.WriteLine("Enter The Number Of Ques");
            flagNumberQues = int.TryParse(Console.ReadLine(),out numberOfQuestions);
        } while (!flagNumberQues);
        #endregion

        #region Create Exam

        Exam exam;
        if (examType == 1)
        {
            exam = new PracticalExam(time, numberOfQuestions);
        }
        else
        {
            exam = new FinalExam(time, numberOfQuestions);
        }

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine("Enter The Type Of Ques (1 for MSQ | 2 For True | false)");
            int questionType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ques Body");
            string body = Console.ReadLine();

            Console.WriteLine("Enter Ques Mark");
            int mark = int.Parse(Console.ReadLine());

            List<Answer> answers = new List<Answer>();
            int correctAnswerId = 0;
            if (questionType == 1)
            {
                Console.WriteLine("Enter The Number Of Choices");
                int numberOfChoices = int.Parse(Console.ReadLine());

                for (int j = 0; j < numberOfChoices; j++)
                {
                    Console.WriteLine($"Enter Choice Number {j + 1}");
                    answers.Add(new Answer(j + 1, Console.ReadLine()));
                }
                Console.WriteLine("Enter the number of the correct answer");
                correctAnswerId = int.Parse(Console.ReadLine());
            }
            else
            {
                answers.Add(new Answer(1, "True"));
                answers.Add(new Answer(2, "False"));
                Console.WriteLine("Enter the number of the correct answer (1 for True, 2 for False)");
                correctAnswerId = int.Parse(Console.ReadLine());
            }

            Question question;
            if (questionType == 1)
            {
                question = new McqQuestion($"Question {i + 1}", body, mark, answers.ToArray(), correctAnswerId);
            }
            else
            {
                question = new TrueFalseQuestion($"Question {i + 1}", body, mark, answers.ToArray(), correctAnswerId);
            }

            exam.Questions.Add(question);
        }

        Subject subject = new Subject(1, "Sample Subject");
        subject.CreateExam(exam);

        exam.ShowExam();

        #endregion

        #region Start Exam

        int totalGrade = 0;
        DateTime startTime = DateTime.Now;
        foreach (var question in exam.Questions)
        {
            question.Display();
            Console.WriteLine("Your Answer => ");
            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == question.CorrectAnswerId)
            {
                totalGrade += question.Mark;
            }
        }
        TimeSpan timeTaken = DateTime.Now - startTime;

        Console.WriteLine($"Your Grade is {totalGrade} from {exam.NumberOfQuestions * 6}");
        Console.WriteLine($"Time = {timeTaken}");
        Console.WriteLine("Thank You");

        #endregion
      
    }
}
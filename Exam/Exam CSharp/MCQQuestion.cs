namespace Exam_CSharp;

public class McqQuestion : Question
{
    public McqQuestion(string header, string body, int mark, Answer[] answers, int correctAnswerId)
        : base(header, body, mark, answers, correctAnswerId) { }

    public override void Display()
    {
        Console.WriteLine($"{Header}\n{Body}");
        for (int i = 0; i < AnswerList.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
        }
    }
}
using Exam_CSharp;

public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion(string header, string body, int mark, Answer[] answers, int correctAnswerId)
        : base(header, body, mark, answers, correctAnswerId) { }

    public override void Display()
    {
        Console.WriteLine($"{Header}\n{Body}\n1. True\n2. False");
    }
}
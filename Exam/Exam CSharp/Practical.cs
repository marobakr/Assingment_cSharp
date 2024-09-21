namespace Exam_CSharp;

public class PracticalExam : Exam
{
    public PracticalExam(int time, int numberOfQuestions)
        : base(time, numberOfQuestions) { }

    public override void ShowExam()
    {
        Console.WriteLine("Practical Exam");
    }
}
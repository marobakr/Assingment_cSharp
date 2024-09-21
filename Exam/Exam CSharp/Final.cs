namespace Exam_CSharp;

public class FinalExam : Exam
{
    public FinalExam(int time, int numberOfQuestions)
        : base(time, numberOfQuestions) { }

    public override void ShowExam()
    {
        Console.WriteLine("Final Exam");
    }
}
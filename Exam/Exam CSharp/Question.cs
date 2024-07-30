using System;
using Exam_CSharp;

public abstract class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }
    public Answer[] AnswerList { get; set; }
    public int CorrectAnswerId { get; set; }

    public Question(string header, string body, int mark, Answer[] answers, int correctAnswerId)
    {
        Header = header;
        Body = body;
        Mark = mark;
        AnswerList = answers;
        CorrectAnswerId = correctAnswerId;
    }

    public abstract void Display();
}
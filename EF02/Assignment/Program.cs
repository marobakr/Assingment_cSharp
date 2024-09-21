using Assignment.Context;
using Assignment.Intities;

namespace Assignment;

class Program
{
    static void Main(string[] args)
    {
        #region ASS_01 CRUD Operations
        using ITIDBContext context = new ITIDBContext();

        #region Create

        #region Student
        //
        // var student = new Student()
        // {
        //     Fname = "Marwan",
        //     Lname = "Omar",
        //     Address = "Cairo",
        //     Age = 20,
        //     Dep_id = 1
        // };
        // Console.WriteLine(context.Entry(student).State);//  [Detached]
        // context.Add(student); // Add Student to Context
        // Console.WriteLine(context.Entry(student).State);//  [Added]
        // context.SaveChanges(); // Save Changes

        #endregion

        #region Course
        
        // var Course = new Course()
        // {
        //     Top_id = "5",
        //     Description = "html",
        //     Name = "html",
        //     Durations = 50,
        // };
        // Console.WriteLine(context.Entry(Course).State);//  [Detached]
        // context.Add(Course); // Add Student to Context
        // Console.WriteLine(context.Entry(Course).State);//  [Added]
        // context.SaveChanges(); // Save Changes
        //

        #endregion

        #region Course_ins
        //
        // var Course_ins = new Course_ins()
        // {
        //     Course_id = 2,
        //     evaluate = "text",
        // };
        // Console.WriteLine(context.Entry(Course_ins).State);//  [Detached]
        // context.Add(Course_ins); // Add Student to Context
        // Console.WriteLine(context.Entry(Course_ins).State);//  [Added]
        // context.SaveChanges(); // Save Changes

        #endregion

        #endregion

        #region Read

        #region Student
        
        // var Result  =  context.Student.Where((S) => S.Fname == "Marwan");
        // Console.WriteLine(Result.ToList()[0].Lname);

        #endregion
        
        #region Course
        
        // var Result  =  context.Course.Where((C) => C.Name == "HTML");
        // Console.WriteLine(Result.ToList()[0].Id);
        //

        #endregion
             
        #region Course_ins
        //
        // var Result  =  context.Course_ins.Where((Cs) => Cs.Course_id == 2);
        // Console.WriteLine(Result.ToList()[0].Course_id);
        //

        #endregion

        #endregion
        
        #region Update

        #region Student
        
        // var Result = context.Student.FirstOrDefault(S => S.Address == "Cairo");
        // Result.Fname = "Marwan";
        // Console.WriteLine(context.Entry(Result).State);
        // context.SaveChanges();
        // Console.WriteLine(context.Entry(Result).State);

        #endregion
        
        #region Course
         
        // var Result01 = context.Course.FirstOrDefault(C => C.Name == "HTML");
        // Result01.Name = "Javascript";
        // Console.WriteLine(context.Entry(Result01).State);
        // context.SaveChanges();
        // Console.WriteLine(context.Entry(Result01).State);

        #endregion
             
        #region Course_ins
        // var Result02 = context.Course_ins.FirstOrDefault(CI => CI.Course_id == 2);
        // Result02.Course_id= 4;
        // Console.WriteLine(context.Entry(Result02).State);
        // context.SaveChanges();
        // Console.WriteLine(context.Entry(Result02).State);

        #endregion

        #endregion

        #region Delete

        #region Student
        // var ResultDelated = context.Student.Where(S=>S.Fname == "Marwan");
        // Console.WriteLine(context.Entry(ResultDelated).State); // [unchanged]
        // context.Remove(ResultDelated);
        // context.SaveChanges(); 
        //

        #endregion
        
        #region Course
        // var ResultDelated = context.Course.Where(C=>C.Id == 3);
        // Console.WriteLine(context.Entry(ResultDelated).State); // [unchanged]
        // context.Remove(ResultDelated);
        // context.SaveChanges(); 

        #endregion
        
        #region Course_Ins
        var ResultDelated = context.Course_ins.Where(CI=>CI.Course_id == 4);
        Console.WriteLine(context.Entry(ResultDelated).State); // [unchanged]
        context.Remove(ResultDelated);
        context.SaveChanges(); 

        #endregion
        
        #endregion


        #endregion
    }
}
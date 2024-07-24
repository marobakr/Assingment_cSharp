
namespace Session_4;

/*
 * Static Class
 * is a just container for static member [ attributes, property, constructor, method] and constants
 * you can't create an object from these calls (helper class)
 * no inheritance for this calls
 */


static class Utility
{

    /* Static Attributes*/
    // private static double pi;

    /* Constant */
    private const double pi = 3.24;

    /* Object Member Constructor: Non-Static Constructor */
    /*public Utility(int _X,int _Y )
    {
        X = _X;
        Y = _Y;
        // PI = 3.14; /* is not the right place for initializing the static Attributes#1#
    }*/

    /*
     * Static Constructor [Maximum Only One Static Constructor Pe Class]
     * Can't specify Access Modifies Or Parameter FOr Static Constructor
     * Will Be Executed Just Ony One Time Per Class LifeTime Before The First Usage Of Class
     * - Usage Of Class
     *  01 - Class Static Method Or Static Property
     *  02 - Create Object From This Class
     *  03 - Create Object From Another Class Inheriting From This Class
     *  - What the useful For Static Constructor
     *     --- to make Initialize for static Attributes
     *     --- can make static Contributor Overloading because its dos;ne take parameter
     *     ---
     */

    private static string num = "10"; /* Or Initialize the At repute in The Same line */
    /*
    static Utility()
    {
        PI = 3.14;
    }
    */



/* Class Member Property: Static Property */

/*
 * Static Property Get And Set one Of These ...
 *  - Static Attributes
 *  - Constant
 */

    /*
     * Static Attributes
     *  - Compiler Will Initialize THe Static Attributes With The defaults Value Of Its Datatype = 0
     */

    /* with Static Attributes */
    /*
    public static double PI
    {
        get { return pi; }
        set { pi = value; }
    }
    */

    /* with Constant doesn't Have Set*/
    public static double PI
    {
        get { return pi; }
    }



    /*
     * Object Member Method : is't Non-Static Member Method : instance methods
     * To Use It You must get an Instance from class [create Object] to invoke the Function
     *
     */

    /*
     * static Member Method: ist Static Member Method: not  instance methods
     * can i invoke the function and get proprty throw Class
     *  don;t need to create an inntanve Form CLass [object]
     *
     */

    /* Class Member Method */
    public static double CMToInch(double Cm)
    {
        return Cm * 2.45;
    }


    /* Class Member Method */
    public static double CalcCircleArea(double Radius)
    {
        return PI * Math.Pow(Radius, 2);

    }
}

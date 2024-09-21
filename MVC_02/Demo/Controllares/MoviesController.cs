using Microsoft.AspNetCore.Mvc;
using Session_02.Models;

namespace Session_02.Controllares;

/*
 * Controller contains an Action,
 * Action is a Public none-static Method
 * Action has Special DataTypes [ActionResult]
*/
public class MoviesController : Controller
{
    #region User-Defined-Action
    /* Action */
    // public string GetMovies(int id )
    // {
    //     return $"movies/{id}";
    // }    
    /* Action */
    // public string Test()
    // {
    //     return "Default Test";
    // }


    #endregion

    #region Built-in-Action [Special DataTypes]
    
    public IActionResult GetMovies(int id ,Movie movie )
    {
        ContentResult result = new ContentResult();
        result.Content = $"movies/{id}";
        // result.ContentType = "text/html";
        result.ContentType = "object/pdf";
        return result;
    }
    
    public IActionResult Test(int id)
    {
        // RedirectToActionResult result = new RedirectToActionResult("GetMovies", "Movies", new { id = id });
/* OR Use Helper Method  */
        return  RedirectToAction("GetMovies", "Movies", new { id = id });
         ;
    }
    
    // Attribute 
    [HttpGet] // by default 
    [ActionName("Test3")] // Custom Name for Action Test2
    public IActionResult Test2(int id)
    {
        RedirectResult result;
        if (id > 5)
        {
             // result = new RedirectResult($"www.google.com");
/* OR Use Helper Method  */
             result = Redirect($"www.google.com");

        }
        else
        {
            // result = new RedirectResult($"www.facebook.com");
/* OR Use Helper Method  */
            result =  Redirect($"www.facebook.com");
            
        }

        return result;
    }
    #endregion
    
    #region  Action Paramters Binding
     
    /*
     * 1- From
     * 2- Segment
     * 3- Query String / Query Params
     * 4- file
     */
    
    #endregion
    

}
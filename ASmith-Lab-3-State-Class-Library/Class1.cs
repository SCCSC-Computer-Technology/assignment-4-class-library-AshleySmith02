/*Ashley Smith
 * CPT-206-A01S (Adv Event-Driven Program)
 * Class Library to Lab 3
 * State Database Assignment
 * (Class for StateData = Main Form)
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Created to be called to the StateData form
namespace ASmith_Lab_3_State_Class_Library
{
    //Class created
    public class StateName //Hold variable name for the class
    {
        //Property to access/work with the database
        private static StateDataDataContext db {  get; set; } 
            = new StateDataDataContext();

       

        //Method 1: being called to the StateData for median income (Main Form)
        public static IQueryable updatemedian(decimal lowRange, decimal highRange) //Doesn't give anything back but does something
        {
            //Check between high and low range
            var results = 
                db.StateTables.Where(x => x.State_Median_Income < highRange 
            && x.State_Median_Income > lowRange);
            return results;
            /*Two the right is like the if-statement to decide whether or
             not give you a certain record or not (condition) base on range*/


        }

        //Method 2: Searching states to the StateData
        public static IQueryable searchstate(String stateNames)
        {
            /*Checking/Searching ONLY for state names that is
             already in the database*/
            /*"=>" is another variable that holds a state can be worked on
             or compared to the right*/

            var names = db.StateTables.Where(x => x.State_Name.
            ToUpper().Contains(stateNames.ToUpper()));
            return names;

            /*This would accept either upper or lower case letters
             and will match with possible state names*/


        }

        

    }
}

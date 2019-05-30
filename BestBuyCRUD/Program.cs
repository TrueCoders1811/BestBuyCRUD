﻿using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace BestBuyCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Intructions:
             * 1. Start by creating a json file to store your connection string, and making sure it is hidden by git.
             * 2. Grab your connection string from the json file and into a string in the main method.
             * 2. Create 4 classes:
             *    a. Sales - will contain a property for each field / column in the sales table in the bestbuy database.
             *    b. Employees - will contain a property for each field / column in the employees table in the bestbuy database.
             *    c. SalesRepo - will contain the 4 CRUD operations for the sales table.
             *    d. EmployeesRepo - will contain the 4 CRUD operations for the employees table.
             * 3. The two repo classes will need constructors that take in a connection string.
             * 4. Back in the Main method, you will have to successfully demonstrate each CRUD operation works:
             *    a. Create a employee and a sale made by that employee.
             *    b. Update some information for the created employee.
             *    c. Read Information from both the sales and employees tables.
             *    d. Delete the created employee and all the sales they have made.
             * 
             * Make sure you are making commits along the way!
             * 
             * Bonus: Create a method(s) in the EmployeesRepo class that search for employees by their first / last name, or both.
             */
        }
    }
}

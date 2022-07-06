Complete these actions:


Open Visual Studio and click File > New > Project.

Select Visual C# > ASP.NET Web Application (.NET Framework).

Name the project "CarInsurance", then click Create.

Select the MVC template, then click Create.

In the Solution Explorer, right click the App_Data folder and select Add > New Item.

Select SQL Server Database and name your database “Insurance.mdf”, then click Add.

In the Solution Explorer, double click Insurance.mdf.

In the Server Explorer, under Insurance.mdf, right-click the Tables folder and select Add New Table.

In the T-SQL screen type the following SQL query:

 <IMAGE HERE>

Click Update, then click Update Database.

In the Solution Explorer, right click the Models folder and select Add > New Item.

Select ADO.NET Entity Data Model, name your data model “InsuranceEntities”, then click Add.

Select EF Designer from the database, then click Next.

Ensure that your data connection is to Insurance.mdf and that you're saving connection settings in Web.Config as “InsuranceEntities”, then click Next.

If prompted, select Entity Framework 6.x, then click Next.

Click Tables, then click Finish.

Build the project (CTRL + SHIFT + B).

In the Solution Explorer, right click the Controllers folder and select Add > Controller.

Select "MVC 5 Controller with views, using Entity Framework", then click Add.

From the Model class dropdown list, select Insuree (CarInsurance.Models).

From the Data context class dropdown list, select InsuranceEntities (CarInsurance.Models).

Change the controller name from “InsureesController” to “InsureeController”, then click Add.

You now have a multi-page website with full CRUD functionality and the five standard MVC Views, each of which comes with the following built-in functionality:


Index: The Index View of a given Controller presents a page consisting of a list of all objects of the Model from which that Controller was scaffolded.

Create: The Create View of a given Controller presents a page with which the user can instantiate an object of the Model from which that Controller was scaffolded.

Edit: The Edit View of a given Controller corresponds to one object of the Model from which that Controller was scaffolded; it allows the user to change the values of that object's properties.

Details: The Details View of a given Controller corresponds to one object of the Model from which that Controller was scaffolded; it allows the user to view the values of that object's properties.

Delete: the Delete View of a given Controller corresponds to one object of the Model from which that Controller was scaffolded; it allows the user to delete that object.
# Inventory System

This exercise focuses on creating a simple inventory application using ASP.NET Core MVC. We will go through the steps of creating models, controllers, views, and managing the data flow between the front-end and back-end.

## Step 1: Create the Project

1. Create a new MVC.Core project by selecting `File -> New -> Project -> Installed -> Visual C# -> .NET Core -> ASP.NET Core Web Application (Model-View-Controller)`.
2. Name the project "Storage" and choose "None" for the authentication type.
3. Click on "Create".

## Step 2: Model

1. Create a class in the `Models` folder named "Product".
2. Add the following auto-properties:
   - Id (int)
   - Name (string)
   - Price (int)
   - Orderdate (DateTime)
   - Category (string)
   - Shelf (string)
   - Count (int)
   - Description (string)

## Step 3: Create Controllers

1. Build the project.
2. Right-click on the `Controllers` folder and choose `Add -> New Scaffolded item`.
3. Select "MVC Controller with views using Entity Framework".
4. Choose your `Product` class as the model class.
5. Create a new context if needed.
6. The controller will be named "ProductsController".
7. Click on "Ok".

## Step 4: Generate Database with Entity Framework

1. Open Package Manager Console (PMC) via `Tools -> NuGet Package Manager -> Package Manager Console`.
2. Type `Add-Migration [Name]` to create a migration file.
3. Run `Update-Database` to apply the migration and create the database.

## Step 5: Add Navigation

1. Add a navigation link in the header to go directly to `Products/Index`.
2. Change the routing in `Program.cs` to make `ProductsController` the default controller.

## Step 6: Create ViewModel

1. Create a class in the `Models` folder named "ProductViewModel" with properties:
   - Name (string)
   - Price (int)
   - Count (int)
   - InventoryValue (int)
2. Create a new ActionResult in the `Products` controller.
3. Retrieve all products from the database and map the data to `ProductViewModel`.
4. Sum up the total value for each product and assign it to `InventoryValue`.
5. Create a new view for `ProductViewModel`.

## Step 7: Filtering

1. Create a new method in the controller that takes a string parameter `category`.
2. Filter the products based on the specified category.
3. Send the result to the view.
4. Create a search form on the page with a button to search for products. Use Form Tag Helpers.

## Author
[Emre Demirel](https://github.com/98emre)

# Smart-ATM-Simulator
A console based Smart ATM Simulator application developed to learn conditional programming and OOPs concepts. It includes features like balance inquiry, cash withdrawal, deposit handling, and PIN verification while simulating real ATM operations through structured program logic.


 **Prerequisites**
 Before running this project, ensure your system has the following installed:
 .NET SDK (version 6.0 or higher recommended)
 Visual Studio (2022 or later recommended) with the .NET desktop development workload enabled

 **Method 1: Pulling the RepositoryClone this repository to your local machine:**
 git clone <repository-url>
 Open Visual Studio.Choose Open a project or solution and select the .sln file from the cloned folder

 **Method 2: Copy and PasteCreate a new Console App project in Visual Studio.**
 Copy the source code from this repository.
 Paste the code into your project's Program.cs file, replacing the existing template code.

  **Execution**
  To run the logic, navigate to your project's entry point and call the main functionality inside the Main method.Code Integration Examplecsharpusing System;


namespace YourProjectNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting the application...");

            // Call the main project logic here
            // Example: YourClassName.YourMethodName();

            Console.WriteLine("Execution completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}


**Running the Project in Visual Studio**
Set your project as the Startup Project if it is part of a larger solution.
Press F5 (or click the green Start button) to run with debugging.
Alternatively, press Ctrl + F5 to run the application without debugging.

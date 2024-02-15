// See https://aka.ms/new-console-template for more information
using WelcomeApp1;

Console.WriteLine("Welcome to auth app");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@1256"));

// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Nodes;
using fluentApi;
using Microsoft.EntityFrameworkCore;

var context = new MyContext();
// var user = new UserFluent
// {
//     Age = 10,
//     BirthDate = default,
//     Dummy = "dummy",
//     Gender = Gender.Unknown,
//     FullName = new FullName
//     {
//         FirstName = "john",
//         LastName = "doe"
//     },
//     Password = "12344",
//     NationalCode = new NationalCode("22333")
// };
// context.UserFluents.Add(user);
// context.SaveChanges();


var users = context.Set<UserFluent>()
    .Where(u => u.Password.Length>1).ToList();
// var users = context.Set<UserFluent>()
//     .Where(u => EF.Functions.JsonValue(u.FullName, "$.FirstName") == "john")
//     .ToList();

foreach (var user in users)
{
    Console.WriteLine(user.Id); 
  //  Console.WriteLine(user.Password); 
}

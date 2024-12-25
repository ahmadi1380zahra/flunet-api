// See https://aka.ms/new-console-template for more information

using fluentApi;

var context = new MyContext();
var user = new UserFluent
{
    Age = 10,
    BirthDate = default,
    Dummy = "dummy",
    Gender = Gender.Girl
};
context.UserFluents.Add(user);
context.SaveChanges();

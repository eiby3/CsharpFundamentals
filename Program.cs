using System;
using System.Collections.Generic;
using System.Linq;
using Projeto.ContentContext;
using Projeto.SubscriptionContext;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Article>();
            artigos.Add(new Article("Artigo OOP", "orientacao-obj"));
            artigos.Add(new Article("Artigo C#", "csharp"));
            artigos.Add(new Article("Artigo .NET", "dotnet"));

            // foreach (var item in artigos)
            // {
            //     Console.WriteLine(item.Id);
            //     Console.WriteLine(item.Title);
            //     Console.WriteLine(item.Url);
            // }

            var courses = new List<Course>();
            var courseOOP = new Course("Artigo OOP", "orientacao-obj");
            var courseCsharp = new Course("Artigo C#", "csharp");
            var courseAspNet = new Course("Artigo ASP .NET", "fundamentos aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Specialist .NET", "specialist-dotnet");
            var careerItem2 = new CareerItem(2, "Learn OOP", "", null);
            var careerItem = new CareerItem(1, "Start here", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Learn .NET", "", courseAspNet);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine(notification.Message);
                        Console.WriteLine(notification.Property);
                    }
                }
            }
            var student = new Student();
            student.CreateSubscription(new PaypalSubscription());
        }
    }
}

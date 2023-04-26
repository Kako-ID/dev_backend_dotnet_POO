using Balta.SubscriptionContext;

namespace Balta.ContentContext.Enums
{
    public class Program
    {
        static void Main(String[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre POO", "orientacao-objetos")); // Passando Title e URL
            articles.Add(new Article("Artigo sobre C#", "charp")); // Passando Title e URL
            articles.Add(new Article("Artigo sobre .Net", "dotnet")); // Passando Title e URL

            foreach (var article in articles)
            {
                Console.WriteLine("ID: {0}", article.Id);
                Console.WriteLine("Title: {0}", article.Title);
                Console.WriteLine("URL: {0}", article.Url);
                Console.WriteLine("------------------------------------");
            }

            var courses = new List<Course>(); // Instanciando a Lista

            // Criando cursos 
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-c#");
            var courseAspnet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspnet);




            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");// Instanciando uma carreira
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null); // 
            var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspnet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem3);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order)) // OrderBy é usado para ordernar por ordem descendente
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    // Percorrendo a lista e verificando se possui algum curso dentro de Items está como nulo
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }
    }
}
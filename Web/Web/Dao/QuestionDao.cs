using System.Collections;
using System.Collections.Generic;
using Web.Domain;

namespace Web.Dao
{
    public class QuestionDao
    {
        public IEnumerable<Question> getAll 
        { 
            get
            {
                return new List<Question>()
                {
					//1
                    new Question("Яка компанія розробила середовище розробки  ASP net?", new List<Answear>()
                    {
                        new Answear("Unity Technologies",false),
                        new Answear("Meta Platforms",false),
                        new Answear("Google",false),
                        new Answear("Microsoft",true),
                    }),
					//2
                     new Question("Які мови програмування використовуються для розробки веб додатків", new List<Answear>()
                    {
                        new Answear("C#",true),
                        new Answear("Js",false),
                        new Answear("Java",false),
                        new Answear("Python",false),
                    }),
					//3
                     new Question("Чи підтримуэ ASP net бази даних та які", new List<Answear>()
                    {
                        new Answear("Так,  MS SQL Server, MySQL, Postgres, MongoDB",true),
                        new Answear("Ні",false),
                        new Answear("Так але тільки MS SQL Server",false),
                        new Answear("Так але  тільки Postgres",false),
                    }),
					//4
                     new Question("Яка модель реалізує патерн RESET ASP.NET ", new List<Answear>()
                    {
                        new Answear("Razor Pages",false),
                        new Answear("Blazor",false),
                        new Answear("Minimal API ",false),
                        new Answear("ASP.NET Core Web API",true),
                    }),
					//5
					new Question("Які операційні системи підтримує ASP NET", new List<Answear>()
                    {
                        new Answear("Windows, Linux, macOS",true),
                        new Answear("Windows",false),
                        new Answear("Linux",false),
                        new Answear("macOS",false),
                    }),
					//6
					new Question("Коли вперше почали розробку ASP.NET Core", new List<Answear>()
                    {
                        new Answear("1997",true),
                        new Answear("2000",false),
                        new Answear("2002",false),
                        new Answear("2012",false),
                    }),
					//7
					new Question("Хто на самому початку займався розробкою ASP NET", new List<Answear>()
                    {
                        new Answear("Брендан айк",false),
                        new Answear("Джеймс Гослінг",false),
                        new Answear("Андерс Гейлзберг",false),
                        new Answear("Марк Андерс та Скотт Гутрі",true),
                    }),
					//8
					new Question("Що таке ASP.NET", new List<Answear>()
                    {
                        new Answear("Середовище для розробки веб додатків",true),
                        new Answear("Середовище розробки ігрових-додатків",false),
                        new Answear("Срередовище для розробки WPF",false),
                        new Answear("Системна бібліотека",false),
                    }),
					//9
					new Question("Де зазвичай розробляють веб додатки", new List<Answear>()
                    {
                        new Answear("Unity Editor",false),
                        new Answear("В конослі",false),
                        new Answear("Visual Studio,Visual Studio Code ",true),
                        new Answear("Unreal Engine 5",false),
                    }),
					//10
					new Question(" З яких  компонентів складається  MVC ", new List<Answear>()
                    {
                        new Answear("model",false),
                        new Answear("view",false),
                        new Answear("model, view,  controller",true),
                        new Answear("controller",false),
                    })
					
                };
            }
        } 
    }
}

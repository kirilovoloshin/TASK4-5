using System.Collections.Generic;

namespace Web.Domain
{
    public class Question
    {
        public string title { get; set; }

        public List<Answear> answears { get; set; }

        public Question(){}
        public Question(string title, List<Answear> answears)
        {
            this.title = title;
            this.answears = answears;
        }
    }
}

namespace Web.Domain
{
    public class Answear
    {
        public string title { get; set; }

        public bool isTrue { get; set; }

        public Answear(){}

        public Answear(string title, bool isTrue)
        {
            this.title = title;
            this.isTrue = isTrue;
        }
    }
}

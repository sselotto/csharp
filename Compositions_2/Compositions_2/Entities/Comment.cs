
namespace Compositions_2.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment() //Construtor sem argumento
        {

        }

        public Comment(string text) //Construtor
        {
            Text = text;
        }
    }
}

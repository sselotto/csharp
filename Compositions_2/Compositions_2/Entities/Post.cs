using System;
using System.Collections.Generic;
using System.Text;


namespace Compositions_2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void AddRemove(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString() //utilizando string builder 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach(Comment c in Comments) //Para percorrer a lista
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString(); //Converter o conteudo no Stringbuilder para String 

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula121_ExercicioResolvido2_StringBuilder.Entities
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
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(Title);
            str.Append(Likes);
            str.Append(" Likes - ");
            str.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            str.AppendLine(Content);
            str.Append("Comments:");
            foreach(Comment x in Comments)
            {
                str.AppendLine(x.Text);
            }
            return str.ToString();    
    }
    }   
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfRange.Models
{
    public class QuestionDTO
    {
        public QuestionDTO()
        {
            Tags=new HashSet<TagDTO>();
            Answers=new HashSet<AnswerDTO>();
        }

        public QuestionDTO(Question question)
        {
            ID = question.ID;
            UserID = question.UserID;
            CategoryID = question.CategoryID;
            Title = question.Title;
            QuestionBody = question.QuestionBody;
            Added = question.Added;
            Modified = question.Modified;
            Tags = question.Tags.Select(TagDTO.FromEntity).ToList();
            //Tags = (from tag in question.Tags select new TagDTO(tag)).ToList();
            Answers = question.Answers.Select(AnswerDTO.FromEntity).ToList();
            //Anwsers = (from ans in question.Answers select new AnswerDTO(ans)).ToList();
            AspNetUser = new AspNetUserDTO(question.AspNetUser);
            Category = new CategoryDTO(question.Category);
        }

        public Guid ID { get; set; }
        public string UserID { get; set; }
        public Guid CategoryID { get; set; }
        public string Title { get; set; }
        public string QuestionBody { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Modified { get; set; }
        public ICollection<TagDTO> Tags { get; set; }
        public ICollection<AnswerDTO> Answers { get; set; }
        public AspNetUserDTO AspNetUser { get; set; }
        public CategoryDTO Category { get; set; }

        public static QuestionDTO FromEntity(Question question)
        {
            QuestionDTO qdto = new QuestionDTO(question);

            return qdto;
        }
    }
}

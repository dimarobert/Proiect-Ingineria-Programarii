﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OutOfRange.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OutOfRangeEntities : DbContext
    {
        public OutOfRangeEntities()
            : base("name=OutOfRangeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<QuestionView> QuestionViews { get; set; }
        public virtual DbSet<ScoreItem> ScoreItems { get; set; }
        public virtual DbSet<UserLevel> UserLevels { get; set; }
        public virtual DbSet<UserBadge> UserBadges { get; set; }
    }
}

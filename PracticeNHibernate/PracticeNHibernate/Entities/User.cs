﻿namespace PracticeNHibernate.Entities
{
    public abstract class User
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}

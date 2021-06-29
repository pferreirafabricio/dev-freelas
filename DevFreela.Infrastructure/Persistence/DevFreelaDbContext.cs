using System;
using System.Collections.Generic;
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("New web project", "Gorgeous description", 1, 1, 1000),
                new Project("New web project 2", "Gorgeous description", 1, 1, 2000),
                new Project("New web project 3", "Gorgeous description", 1, 1, 3000)
            };

            Users = new List<User>
            {
                new User("Fabrício", "fabricio@gmail.com", new DateTime(2000, 01, 01)),
                new User("Felipe", "felipe@gmail.com", new DateTime(1995, 01, 01)),
                new User("John", "john@gmail.com", new DateTime(1992, 01, 01)),
            };

            Skills = new List<Skill>
            {
                new Skill("PHP"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
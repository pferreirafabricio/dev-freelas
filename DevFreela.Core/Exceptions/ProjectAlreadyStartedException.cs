using System;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException() : base("Project already started") { }
    }
}
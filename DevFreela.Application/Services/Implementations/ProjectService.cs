using System.Collections.Generic;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Implementation
{
    public class ProjectService : IProjectService
    {
        public int Create(NewProjectInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Finish(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            throw new System.NotImplementedException();
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Start(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
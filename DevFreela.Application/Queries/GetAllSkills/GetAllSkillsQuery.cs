using System.Collections.Generic;
using DevFreela.Application.ViewModels;
using DevFreela.Core.DTOs;
using MediatR;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillsQuery : IRequest<List<SkillDTO>>
    {
    }
}
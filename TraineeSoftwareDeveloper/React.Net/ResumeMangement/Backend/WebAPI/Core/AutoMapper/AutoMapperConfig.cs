using AutoMapper;
using WebAPI.Core.DTOs.Candidate;
using WebAPI.Core.DTOs.Company;
using WebAPI.Core.DTOs.Job;
using WebAPI.Core.Entities;

namespace WebAPI.Core.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            // Company
            CreateMap<CompanyCreateDTO, Company>();
            CreateMap<Company, CompanyGetDTO>();

            // Job
            CreateMap<JobCreateDTO, Job>();
            CreateMap<Job, JobGetDTO>()
                .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Company.Name));

            // Candidate
            CreateMap<CandidateCreateDTO, Candidate>(0);
            CreateMap<Candidate, CandidateGetDTO>()
                .ForMember(dest => dest.JobTitle, opt => opt.MapFrom(src => src.Job.Title));
        }
    }
}

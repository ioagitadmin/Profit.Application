using AutoMapper;
using Profit.Core.Commands;
using Profit.Core.Mapping;

namespace Profit.WebApi
{
    public class CreateMessageDto : IMap<CreateCommand>
    {
        public string Data { get; set; }
        public DateTime CreationTime { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateMessageDto, CreateCommand>()
                .ForMember(cmd => cmd.Data,
                opt => opt.MapFrom(dto => dto.Data))
                .ForMember(cmd => cmd.CreationTime,
                opt => opt.MapFrom(dto => dto.CreationTime.ToUniversalTime()));
        }
    }
}

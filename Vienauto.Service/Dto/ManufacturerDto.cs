using Vienauto.Entity.Entities;
using System.Collections.Generic;

namespace Vienauto.Service.Dto
{
    public class ManufacturerDto
    {
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerRewriteName { get; set; }
        public string ManufacturerLogo { get; set; }
    }

    public static class ManufacturerDtoExtension
    {
        public static ManufacturerDto FromEntityToDto(this Manufacturer entity)
        {
            return new ManufacturerDto
            {
                ManufacturerId = entity.Id,
                ManufacturerLogo = entity.Logo,
                ManufacturerName = entity.Name,
                ManufacturerRewriteName = entity.RewriteName
            };
        }

        public static IList<ManufacturerDto> FromEntitiesToDtos(this IList<Manufacturer> entities)
        {
            var dtos = new List<ManufacturerDto>();
            var listEntities = (List<Manufacturer>)entities;
            listEntities.ForEach(x =>
            {
                dtos.Add(x.FromEntityToDto());
            });
            return dtos;
        }

        public static Manufacturer FromDtoToEntity(this ManufacturerDto dto)
        {
            return new Manufacturer
            {
                Id = dto.ManufacturerId,
                Logo = dto.ManufacturerLogo,
                Name = dto.ManufacturerName,
                RewriteName = dto.ManufacturerRewriteName
            };
        }

        public static List<Manufacturer> FromDtosToEntities(this IList<ManufacturerDto> dtos)
        {
            var manufacturers = new List<Manufacturer>();
            var listDtos = (List<ManufacturerDto>)dtos;
            listDtos.ForEach(x =>
            {
                manufacturers.Add(x.FromDtoToEntity());
            });
            return manufacturers;
        }
    }
}

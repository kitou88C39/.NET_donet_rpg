using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg
{
  public class AutoMapperProfile : profile
  {
    public AutoMapperProfile()
    {
        CreateMap<Character,GetCharacterDto>();
        CreateMap<AddCharacterDto,Character>();
    }
  }
}
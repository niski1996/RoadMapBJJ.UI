using RoadMapBJJ.Contracts.Entities.Media;
using RoadMapBJJ.Contracts.Entities.Techniques;

namespace RoadMapBJJ.UI.DTOs;

public record PersonalCardModel(string Name, string LastName, string City, string Club, int Techniques);
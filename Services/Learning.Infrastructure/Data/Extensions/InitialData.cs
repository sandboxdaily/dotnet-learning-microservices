using Learning.Domain.Models;

namespace Learning.Infrastructure.Data.Extensions
{
    public static class InitialData
    {
        public static IEnumerable<Property> Properties =>
            new List<Property>
            {
                Property.Create(new Guid("35B60C6B-BB0A-4495-971D-1CBA783AD96F"), "Cortland Residential"),
                Property.Create(new Guid("B944CD01-B81E-4BB7-92D4-A5CD3D5D534F"), "Morgan Properties"),
                Property.Create(new Guid("6999819D-2C9B-4B7A-BBA8-FF934A0DA113"), "Ocean Breeze"),
                Property.Create(new Guid("3C149EC8-7865-45E3-8BB2-737FCE6C6CFC"), "Black Bear Mountains Campsite"),
                Property.Create(new Guid("49C4AF07-2983-49E5-BAAF-8F67BF287339"), "Wain Manor"),
                Property.Create(new Guid("81F3AA1D-95AD-4B41-92EB-06F2AD61F231"), "Summerlin HOA"),
                Property.Create(new Guid("58221690-59FB-4872-B607-B28FC29DABB2"), "Corporate Business Park"),
                Property.Create(new Guid("E097D90B-EC88-4D27-BD69-5D8FB11B550E"), "Golden Gate Housing")
            };

    }
}

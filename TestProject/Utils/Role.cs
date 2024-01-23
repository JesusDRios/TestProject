using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace TestProject.Utils
{
    internal enum Role
    {
        Executive,
        Clinical,
        Financial,
        Operations,
        [Description("Technology/IT")]
        Technology,
        Other,
    }
}

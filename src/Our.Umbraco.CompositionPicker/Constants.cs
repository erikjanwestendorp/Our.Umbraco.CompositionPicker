namespace Our.Umbraco.CompositionPicker;

internal static class Constants
{
    internal static partial class Internals
    {
        internal const string ProjectName = "CompositionPicker";
        internal const string PackagePathRoot = "~/App_Plugins/" + ProjectName + "/";
        internal const string EditorPathRoot = PackagePathRoot + "editors/";
    }

    internal static class Conventions
    {
        internal static partial class PropertyGroups
        {
            public const string Pickers = nameof(Pickers);
            
        }
    }
}

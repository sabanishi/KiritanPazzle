using Packages.Rider.Editor.ProjectGeneration;
using UnityEditor;

public static class Export
{
    public static void VSSolution()
    {
        AssetDatabase.Refresh();
        var generator = new ProjectGeneration();
        generator.Sync();
    }
}
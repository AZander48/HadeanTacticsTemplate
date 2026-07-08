using BepInEx;

namespace HadeanTacticsTemplate;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class HadeanTacticsTemplate : BaseUnityPlugin
{
    private void Awake()
    {
        // Put your initialization logic here
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} has loaded!");
    }
}
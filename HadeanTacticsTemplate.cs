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

    // Do NOT UnpatchSelf here. This game destroys BepInEx plugin MonoBehaviours on
    // scene load (Unity-null) while the managed instance/config stay alive — unpatching
    // would strip CreateRune hooks before gameplay (see HarmonyLog rewrite with 0 postfixes).
    /*
    private void OnDestroy()
    {
        Log.LogWarning("HadeanTacticsTemplate OnDestroy (Unity lifecycle); Harmony patches left in place.");
    }
    */
}
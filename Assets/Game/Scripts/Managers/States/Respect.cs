public class Respect : BaseState
{
    public override void OnActivate()
    {
        Managers.UIManager.ShowRespectPanel();
        Managers.AudioManager.PlayAudio();
        Managers.AdsManager.ShowAnnoyingInter();
    }

    public override void OnDeactivate()
    {
#if UNITY_EDITOR
        ClearConsole();
#endif
    }

    public override void OnUpdate()
    {
    }

    private static void ClearConsole()
    {
        var logEntries = System.Type.GetType("UnityEditor.LogEntries, UnityEditor.dll");

        var clearMethod = logEntries.GetMethod("Clear",
            System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);

        clearMethod.Invoke(null, null);
    }
}
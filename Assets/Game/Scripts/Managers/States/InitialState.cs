public class InitialState : BaseState
{
    public override void OnActivate()
    {
        Managers.UIManager.ShowStartPanel();
    }

    public override void OnDeactivate()
    {
    }

    public override void OnUpdate()
    {
    }
}
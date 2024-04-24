namespace DecoratorPattern.States;

public sealed class NormalState : IState
{
  // シングルトン
  private NormalState() { }
  public static NormalState Instance { get; } = new NormalState();

  public string GetStateText()
  {
    return "NormalStateなう";
  }

  public void OnChange(StateContext stateContext)
  {
    stateContext.ChangeState(LowerState.Instance);
  }
}

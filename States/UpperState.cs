namespace DecoratorPattern.States;

public sealed class UpperState : IState
{
  // シングルトン
  private UpperState() { }
  public static UpperState Instance { get; } = new UpperState();
  public string GetStateText()
  {
    return "UpperStateなう";
  }

  public void OnChange(StateContext stateContext)
  {
    stateContext.ChangeState(NormalState.Instance);
  }
}

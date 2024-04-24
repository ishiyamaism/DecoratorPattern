namespace DecoratorPattern.States;

public sealed class LowerState : IState
{
  // シングルトン
  private LowerState() { }
  public static LowerState Instance { get; } = new LowerState();
  public string GetStateText()
  {
    return "LowerStateなう";
  }

  public void OnChange(StateContext stateContext)
  {
    stateContext.ChangeState(UpperState.Instance);
  }
}

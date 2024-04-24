namespace DecoratorPattern.States
{
  // 状態を同一視するためのインターフェース
  public interface IState
  {
    string GetStateText();
    void OnChange(StateContext stateContext);
  }
}

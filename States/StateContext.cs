namespace DecoratorPattern.States;
// 状態管理のためのクラス
public sealed class StateContext
{
  private IState _state = NormalState.Instance;

  // State変化監視用のオブザーバー
  public event Action? StateChanged;
  internal void ChangeState(IState state)
  {
    _state = state;
    StateChanged?.Invoke();
  }

  // State変更時
  public void Change()
  {
    // State状態を変える
    _state.OnChange(this);
  }

  public string GetText()
  {
    return _state.GetStateText();
  }

}

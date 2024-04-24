using DecoratorPattern.Objects;

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

  public string GetComponentData(IComponent component)
  {
    string textCase = GetText();

    // 必要ならばデコレートする。
    if (textCase.Contains("Upper"))
    {
      component = new DecoratorUpper(component);
    }
    else if (textCase.Contains("Lower"))
    {
      component = new DecoratorLower(component);
    }

    // いずれにしても実行メソッドは同じとなる。
    return component.GetData();
  }
}

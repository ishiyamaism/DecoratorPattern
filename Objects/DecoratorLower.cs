namespace DecoratorPattern.Objects;

// 具象クラス
public sealed class DecoratorLower : Decorator
{
  public DecoratorLower(IComponent child) : base(child)
  {
  }

  protected override string GetDataSub()
  {
    return _child.GetData().ToLower();
  }
}

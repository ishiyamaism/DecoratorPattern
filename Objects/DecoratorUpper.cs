namespace DecoratorPattern.Objects;

// 具象クラス
public sealed class DecoratorUpper : Decorator
{
  public DecoratorUpper(IComponent child) : base(child)
  {
  }

  protected override string GetDataSub()
  {
    return _child.GetData().ToUpper();
  }
}

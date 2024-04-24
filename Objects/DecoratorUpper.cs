namespace DecoratorPattern.Objects;

// １．同じインターフェースの実装にする
public sealed class DecoratorUpper : IComponent
{
  // ２．同じインターフェースを保持する
  private IComponent _child;

  // ３．コンストラクタで子階層を受ける
  public DecoratorUpper(IComponent child)
  {
    _child = child;
  }

  // ４．_childを使って実装(拡張)する
  public string GetData()
  {
    return _child.GetData().ToUpper();
  }

  // 元のGetData()には何の影響もない。
}

namespace DecoratorPattern.Objects;

// 抽象クラスで共通化する
public abstract class Decorator : IComponent
{
  // ２．同じインターフェースを保持する
  protected IComponent _child;

  // ３．コンストラクタで子階層を受ける
  public Decorator(IComponent child)
  {
    _child = child;
  }

  // ４．_childを使って実装(拡張)する
  // ５．それは具象クラスに任せる
  public string GetData()
  {
    return GetDataSub();
  }

  protected abstract string GetDataSub();
  // 元のGetData()には何の影響もない。
}

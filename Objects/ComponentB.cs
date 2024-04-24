namespace DecoratorPattern.Objects;

public sealed class ComponentB : IComponent
{
  private readonly string textB_txt = "BbB Text From textB.txt";

  public string GetData()
  {
    // string readText = File.ReadAllText("textB.txt");
    string readText = textB_txt;

    return readText;
  }
}

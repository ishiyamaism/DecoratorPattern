namespace DecoratorPattern.Objects;

public sealed class ComponentB : IComponent
{
  private string _textCase;
  private readonly string textB_txt = "BbB Text From textB.txt";
  public ComponentB(string textCase)
  {
    _textCase = textCase;
  }
  public string GetData()
  {
    // string readText = File.ReadAllText("textB.txt");
    string readText = textB_txt;

    if (_textCase.Contains("Upper"))
    {
      return readText.ToUpper();
    }
    if (_textCase.Contains("Lower"))
    {
      return readText.ToLower();
    }

    return readText;
  }
}

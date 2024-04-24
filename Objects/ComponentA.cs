namespace DecoratorPattern.Objects;

public sealed class ComponentA : IComponent
{
  private string _textCase;
  private readonly string textA_txt = "AaA Text From textA.txt";

  public ComponentA(string textCase)
  {
    _textCase = textCase;
  }
  public string GetData()
  {
    // string readText = File.ReadAllText("textA.txt");
    string readText = textA_txt;

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

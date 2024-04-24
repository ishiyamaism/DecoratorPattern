namespace DecoratorPattern.Objects;

public sealed class ComponentA : IComponent
{
  private readonly string textA_txt = "AaA Text From textA.txt";

  public string GetData()
  {
    // string readText = File.ReadAllText("textA.txt");
    string readText = textA_txt;

    return readText;
  }
}

using DecoratorPattern.Objects;
using DecoratorPattern.States;

namespace DecoratorPattern;

class Program
{
    // 状態保持
    static private StateContext _stateContext = new StateContext();
    static private string _textCase = "Normal";
    static void Main(string[] args)
    {
        Console.WriteLine("...program start...");
        Console.WriteLine("Enter '0' for State Change,");
        Console.WriteLine("Enter '1' for button1_Click,");
        Console.WriteLine("Enter '2' for button1_Click,");
        Console.WriteLine("'exit' to quit.");

        _stateContext.StateChanged += stateContext_StateChanged;
        // コンソール入力をクリック的トリガーとする
        // 1:
        // 2:
        // exit: 終了
        while (true)
        {
            // 文字入力待機
            string? input = Console.ReadLine();

            if (input == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            switch (input)
            {
                case "0":
                    _stateContext.Change();
                    break;

                case "1":
                    Console.WriteLine("button1_Click");

                    // IComponentインターフェースにて変数宣言し、
                    IComponent componentA = new ComponentA();

                    // 必要ならばデコレートする。
                    if (_textCase.Contains("Upper"))
                    {
                        componentA = new DecoratorUpper(componentA);
                    }
                    else if (_textCase.Contains("Lower"))
                    {
                        componentA = new DecoratorLower(componentA);
                    }

                    // いずれにしても実行メソッドは同じとなる。
                    string valueA = componentA.GetData();
                    Console.WriteLine(valueA);

                    break;
                case "2":
                    Console.WriteLine("button2_Click");

                    IComponent componentB = new ComponentB();

                    if (_textCase.Contains("Upper"))
                    {
                        componentB = new DecoratorUpper(componentB);
                    }
                    else if (_textCase.Contains("Lower"))
                    {
                        componentB = new DecoratorLower(componentB);
                    }

                    string valueB = componentB.GetData();
                    Console.WriteLine(valueB);

                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter '1', '2', or 'exit'.");
                    break;
            }
        }
    }

    // 状態変更オブザーバー
    static private void stateContext_StateChanged()
    {
        _textCase = _stateContext.GetText();

        Console.WriteLine($"State Changed: {_textCase}");
    }
}

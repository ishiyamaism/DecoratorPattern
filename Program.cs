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

                    // この場合は ComponentA インスタンスを利用
                    Console.WriteLine(_stateContext.GetComponentData(new ComponentA()));
                    break;

                case "2":
                    Console.WriteLine("button2_Click");

                    // この場合は ComponentB インスタンスを利用
                    Console.WriteLine(_stateContext.GetComponentData(new ComponentB()));
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

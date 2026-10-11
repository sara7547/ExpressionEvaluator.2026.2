using System.Globalization;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    private static string ToPostfix(string infix)
    {
        var postfix = new List<string>();
        var stack = new Stack<char>();
        int i = 0;

        while (i < infix.Length)
        {
            char item = infix[i];

            if (char.IsWhiteSpace(item))
            {
                i++;
                continue;
            }

            if (char.IsDigit(item) || item == '.')
            {
                int start = i;
                bool hasDecimalPoint = false;
                bool hasDigit = false;

                while (i < infix.Length &&
                       (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    if (infix[i] == '.')
                    {
                        if (hasDecimalPoint)
                        {
                            throw new FormatException(
                                "Número decimal inválido.");
                        }

                        hasDecimalPoint = true;
                    }
                    else
                    {
                        hasDigit = true;
                    }

                    i++;
                }

                string number = infix.Substring(start, i - start);

                if (!hasDigit ||
                    !double.TryParse(
                        number,
                        NumberStyles.AllowDecimalPoint,
                        CultureInfo.InvariantCulture,
                        out _))
                {
                    throw new FormatException(
                        $"Número inválido: {number}");
                }

                postfix.Add(number);
                continue;
            }

            if (!IsOperator(item))
            {
                throw new FormatException(
                    $"Operador o carácter inválido: {item}");
            }

            if (item == '(')
            {
                stack.Push(item);
            }
            else if (item == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    postfix.Add(stack.Pop().ToString());
                }

                if (stack.Count == 0)
                {
                    throw new FormatException(
                        "Paréntesis sin correspondencia.");
                }

                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 &&
                       stack.Peek() != '(' &&
                       PriorityInfix(item) <= PriorityStack(stack.Peek()))
                {
                    postfix.Add(stack.Pop().ToString());
                }

                stack.Push(item);
            }

            i++;
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == '(')
            {
                throw new FormatException(
                    "Hay un paréntesis sin cerrar.");
            }

            postfix.Add(stack.Pop().ToString());
        }

        return string.Join(" ", postfix);
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();

        var tokens = postfix.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in tokens)
        {
            if (item.Length == 1 && IsOperator(item[0]))
            {
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();

                stack.Push(Calculate(ope1, ope2, item[0]));
            }
            else
            {
                double number = double.Parse(
                    item,
                    CultureInfo.InvariantCulture);

                stack.Push(number);
            }
        }

        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}





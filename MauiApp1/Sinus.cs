
using System.Diagnostics;

static class Sinus
{
    public static event Action<double> EvaluatingChanged;
    static CancellationTokenSource cancelTokenSource;


    public static async Task<double> RectangleSinus()
    {
        cancelTokenSource = new CancellationTokenSource();
        return await Task.Run(Evaluate, cancelTokenSource.Token);
    }

    private static double Evaluate()
    {
#pragma warning disable CS0219 // Переменной "a" присвоено значение, но оно ни разу не использовано.
        int a = 0;
#pragma warning restore CS0219 // Переменной "a" присвоено значение, но оно ни разу не использовано.
        double ans = 0;
        double h = 0.000_000_01;

        for (double i = 0, j = 0; i <= 1; i += h, j++)
        {
            
            if (cancelTokenSource.IsCancellationRequested)
                return double.NaN;

            for (int zu = 0; zu < 10; zu++)
                a = 5 * 7 - 5;
            ans += System.Math.Sin(i) * h;

            if ((int)j % 1_000_000 == 0)
                EvaluatingChanged.Invoke(i);
        }

        EvaluatingChanged.Invoke(1.00);
        return ans;
    }

    public static void CancelEvaluation()
    {
        cancelTokenSource.Cancel();
        cancelTokenSource.Dispose();
    }
}
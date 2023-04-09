namespace MauiApp1;

public partial class CalculatorPage : ContentPage
{
    public string operation;
    public string firstNum;
    public string secondNum;
    public bool flag;
    public CalculatorPage()
	{
		InitializeComponent();
	}


    private void OnButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        //if(Result.Text=="0") Result.Text = "";
     
        if(flag)
        {
            flag = false;
            Result.Text = string.Empty;
        }
        if (Result.Text == string.Empty || Result.Text=="0")
        {
            
            Result.Text = button.Text;
        }
        else Result.Text += button.Text;
    }

    private void ClearAll(object sender, EventArgs e)
    {
        Result.Text = "0";
    }

    private void ClearLast(object sender, EventArgs e)
    {
        Result.Text = Result.Text.Substring(0, Result.Text.Length - 1);

        if (Result.Text == "") Result.Text = "0";
    }
    private void Operation(object sender, EventArgs e)
    {
        Button B = (Button)sender;
        operation = B.Text;
        firstNum = Result.Text;
        flag = true;

    }

    private void Equel(object sender, EventArgs e)
    {
        double first, second, answer = 0;
        first = Convert.ToDouble(firstNum);
        second = Convert.ToDouble(Result.Text);

        if (operation == "+") answer = first + second;
        if (operation == "-") answer = first - second;
        if (operation == "×") answer = first * second;
        if (operation == "÷") answer = first / second;
        if (operation == "%") answer = first * second / 100;

        operation = "=";
        flag = true;
        Result.Text = answer.ToString();

    }

    private void Point(object sender, EventArgs e)
    {
        if (!Result.Text.Contains(",")) Result.Text += ",";

    }

    private void MyFunc(object sender, EventArgs e)
    {
        double first;
        first = Convert.ToDouble(Result.Text);
        double answer = first * first * 3.14;
        Result.Text = answer.ToString();

    }

    private void Minus(object sender, EventArgs e)
    {
        if (Result.Text == "0") Result.Text = "0";
        if (Result.Text == "0,") Result.Text = "0,";
        else
        {
            double first;
            first = Convert.ToDouble(Result.Text);
            double answer = first * -1;
            Result.Text = answer.ToString();
        }
        //operation= "×";
        //int second = -1;

    }
}


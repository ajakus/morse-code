using System.Reflection;



namespace TestApp.Views
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;
        private string message;
        private string morses;

        private static string[] codes = new string[]
        {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---"
            ,"-.-",".-..","--","-.","---",".--.","--.-",
            ".-.","...","-","..-","...-",".--", "-..-", "-.--","--..",""
        };

        private static char[] letters = new char[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z'
        };
        public MainPage()
        {
            InitializeComponent();
            var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;
            VersionLabel.Text = $".NET MAUI ver. {version?[..version.IndexOf('+')]}";
            message = "";
            morses = "";

        }

        public static char MorseCoder(string code)
        {
            char result = '?';
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].Equals(code))
                {
                    result = letters[i];
                    break;   
                }

               
            }
            return result;
        }

        private void Dash_Clicked(object sender, EventArgs e)
        {
            morses += "-";
            DAD.Text = morses;
        }
        private void Dot_Clicked(object sender, EventArgs e)
        {
            morses += ".";
            DAD.Text = morses;
        }
        private void Space_Clicked(object sender, EventArgs e)
        {
            char letter = MorseCoder(morses);
            message += letter;
            Scwibbles.Text = message;
            morses = "";
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = $"Current count: {_count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }

        private int count = 0;
        // private void Button_OnClicked(System.Object sender, System.EventArgs e)
        // {
        //     // count++;
        //     // ((Button)sender).Text = $"you clicked {count} times. ";
        //     int weight = Convert.ToInt32(weight_inp.Text);
        //     int height = Convert.ToInt32(height_inp.Text);
        //     double bmi = ((height * height)/weight);
        //     BMI.Text = $"Your BMI is {bmi}";
        // }
        
        
        

        // private static (string status)
        // {
        //     var bmi = status
        //     if (bmi < 18.5)
        //         return ("You are Underweight");
        //     else if (bmi <= 24.9)
        //         return ("You have a Normal body weight, Great Job!");
        //     else if (bmi <= 29.9)
        //         return ("You are Overweight");
        //     else
        //         return ("You are Obese");
        // }
        
    }
}
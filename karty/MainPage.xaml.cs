using System.Xml;

namespace karty
{
    public partial class MainPage : ContentPage
    {
        static List<string> talia = new List<string>
        {
            "clubs_ace.png",
            "spades_ace_simple.png",
            "hearts_ace.png",
            "diamonds_ace.png",
            "clubs_king.png",
            "spades_king.png",
            "hearts_king.png",
            "diamonds_king.png",
            "diamonds_2.png",
            "spades_2.png",
            "hearts_2.png",
            "clubs_2.png",
            "hearts_10.png",
            "spades_10.png",
            "clubs_10.png",
            "diamonds_10.png",
            "spades_6.png",
            "diamonds_6.png",
            "hearts_6.png",
            "clubs_6.png",
            "clubs_4.png",
            "spades_4.png",
            "diamonds_4.png",
            "hearts_4.png",
            "clubs_5.png",
            "spades_5.png",
            "diamonds_5.png",
            "hearts_5.png",
            "clubs_3.png",
            "spades_3.png",
            "diamonds_3.png",
            "hearts_3.png",
            "clubs_7.png",
            "spades_7.png",
            "diamonds_7.png",
            "hearts_7.png",
            "clubs_8.png",
            "spades_8.png",
            "diamonds_8.png",
            "hearts_8.png",
            "clubs_9.png",
            "spades_9.png",
            "diamonds_9.png",
            "hearts_9.png",
            "clubs_jack.png",
            "spades_jack.png",
            "diamonds_jack.png",
            "hearts_jack.png",
            "clubs_queen.png",
            "spades_queen.png",
            "diamonds_queen.png",
            "hearts_queen.png",
        };
        List<string> talia2 = new List<string>(talia);
        List<string> potasowane = new List<string>();
        Random rnd = new Random();
        public MainPage()
        {
            int los;
            int z = talia2.Count;
            InitializeComponent();
            for (int i = 0; i<z; i++)
            {
                los = rnd.Next(0, talia2.Count);
                potasowane.Add(talia2[los]);
                talia2.RemoveAt(los);
            }
        }
        int poz = 0;
        int rot = -125;
        private void btnLosujClicked(object sender, EventArgs e)
        {
            
            if(potasowane.Count > 0)
            {
                
                Image image = new Image() { Source = potasowane[poz], Rotation=rot};
                karty.Children.Add(image);
                potasowane.RemoveAt(poz);
                rot += 15;
            }
            else
                btnLosuj.IsEnabled = false;
        }
    }
}
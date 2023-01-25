using TicTacToeApp;
namespace TicTacToeWinForm
{
    public partial class frmTicTacToe : Form
    {
       
        TicTacToe game = new TicTacToe();
        List<Button> lstbuttons;
        public frmTicTacToe()
        {
            InitializeComponent();
            lstbuttons = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            lstbuttons.ForEach(b => b.Click += btn_Click);
            btnStart.Click += BtnStart_Click;
            lblMessage.DataBindings.Add("Text", game, "Message");
            lblPlayer.DataBindings.Add("Text", game, "CurrentTurn");

            lstbuttons.ForEach(btn =>
            {
                Spot sp = game.Spots[lstbuttons.IndexOf(btn)];
                btn.DataBindings.Add("Text", sp, "ValueDisplay");
                btn.DataBindings.Add("BackColor", sp, "SpotColor");
            });
            game.SpotDefaultColor = Control.DefaultBackColor;
            game.SpotWinningColor = Color.OrangeRed;

            this.StartGame();
        }
        private void StartGame()
        {
            game.StartGame();
            game.PlayAgainstComputer = opt1Player.Checked;
            // DisplayGame();
        }

        private void DoMove(int spotnum)
        {
            game.TakeSpot(spotnum);
            //DisplayGame();
        }

        //private void DisplayGame() //display on the front end the game and spot properties
        //{
        //    lblMessage.Text = game.Message;
        //    lblPlayer.Text = game.CurrentTurn.ToString();
        //    //each button corresponds to a spot based on index
        //    //loop through the buttons, get index of button, and use the index to get matching spot
        //    lstbuttons.ForEach(b =>
        //    {
        //        //get spot based on index of button
        //        Spot spotobj = game.Spots[lstbuttons.IndexOf(b)];
        //        //set button properties
        //        b.Text = spotobj.ValueDisplay;

        //        if (spotobj.WinStatus == true) {
        //            b.BackColor = Color.Green;
        //        }
        //        else
        //        {
        //            b.BackColor = Control.DefaultBackColor;
        //        }
        //    });
        //}
        private void btn_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                int i = lstbuttons.IndexOf(btn);
                DoMove(i);
            }
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            StartGame();
        }
    }
}
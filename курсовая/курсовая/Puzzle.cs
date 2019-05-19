using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace курсовая
{

    class Puzzle
    {  public  int Nomer { get; set; }
        public ObservableCollection<PuzzlePiece> puzzlePiece = new ObservableCollection<PuzzlePiece>();

        public string name;

        public event EventHandler Edited;

        public Puzzle()
        {

        }

        public void OnEdit(EventArgs e)
        {
            if (Edited != null)
                Edited(this, e);
        }

        public void Initialize(int chosen)
        {
            string directorySource = "";

            if (chosen == 1)
            {
                this.name = "Rabbit Puzzle";

                directorySource = "RabbitPuzzle";

            }
            if (chosen == 2)
            {
                this.name = "Rabbit Puzzle1";

                directorySource = "RabbitPuzzle1";
            }
            if (chosen == 3)
            {
                this.name = "Rabbit Puzzle2";

                directorySource = "RabbitPuzzle2";
            }
            if (chosen == 4)
            {
                this.name = "Rabbit Puzzle3";

                directorySource = "RabbitPuzzle3";
            }
            if (chosen == 5)
            {
                this.name = "Rabbit Puzzle4";

                directorySource = "RabbitPuzzle4";
            }
            if (chosen == 6)
            {
                this.name = "Rabbit Puzzle6";

                directorySource = "RabbitPuzzle6";
            }
            if (chosen == 7)
            {
                this.name = "Rabbit Puzzle5";

                directorySource = "RabbitPuzzle5";
            }
            if (chosen == 8)
            {
                this.name = "Rabbit Puzzle7";

                directorySource = "RabbitPuzzle7";
            }
            if (chosen == 9)
            {
                this.name = "Rabbit Puzzle8";

                directorySource = "RabbitPuzzle8";
            }
            if (chosen == 10)
            {
                this.name = "Rabbit Puzzle9";

                directorySource = "RabbitPuzzle9";
            }
                if (chosen == 11)
                {
                    this.name = "Rabbit Puzzle10";

                    directorySource = "RabbitPuzzle10";
                }
            if (chosen == 12)
            {
                this.name = "Rabbit Puzzle11";

                directorySource = "RabbitPuzzle11";
            }
            for (int i = 0; i < 16; i++)
            {
                this.puzzlePiece.Add(new PuzzlePiece());

                this.puzzlePiece[i].index = i;

                this.puzzlePiece[i].UriString = "Puzle/" + directorySource + "/" + (i + 1).ToString() + ".png";

                this.puzzlePiece[i].PuzzleImageSource = new BitmapImage(new Uri(this.puzzlePiece[i].UriString, UriKind.Relative));
            }

            //shuffle
            Random rand = new Random();

            for (int i = 0; i < 16; i++)
            {
                int random = rand.Next(0, 15);

                PuzzlePiece buffer;

                buffer = this.puzzlePiece[i];

                this.puzzlePiece[i] = this.puzzlePiece[random];

                this.puzzlePiece[random] = buffer;
            }
        }

        public bool Validate(ObservableCollection<PuzzlePiece> itemPlacement)
        {
            ObservableCollection<PuzzlePiece> placement = itemPlacement;

            foreach (PuzzlePiece item in placement)
            {
                if ((placement.IndexOf(item) != item.index) || placement.IndexOf(item) < 0)

                    return false;
            }

            return true;
        }
    }
}

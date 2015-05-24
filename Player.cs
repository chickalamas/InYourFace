using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InYourFace
{
    public class Player
    {
        public int Id { get; set; }
        public bool IsPressed { get; set; }
        public int SelectedNumber { get; set; }
        public Label Label { get; set; }
        
        public Player(int id, Label label)
        {
            this.Id = id;
            this.IsPressed = false;
            this.SelectedNumber = -1;
            this.Label = label;
        }

    }
}

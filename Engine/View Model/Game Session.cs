using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.View_Model
{
    public class Game_Session
    {
        Player CurrentPlayer { get; set; } 
        public Game_Session() 
        { 
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Nymph";
            CurrentPlayer.Gold = 1000000;

        
        }
    }
}

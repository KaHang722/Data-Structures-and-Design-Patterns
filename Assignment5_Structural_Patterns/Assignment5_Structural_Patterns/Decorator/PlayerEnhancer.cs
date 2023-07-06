using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Decorator
{
    public abstract class PlayerEnhancer : Player
    {
        public Player player;

        public PlayerEnhancer(Player player)
        {
            this.player = player;
        }
        
        public virtual void Play()
        {
            player.Play();
        }
    }
}

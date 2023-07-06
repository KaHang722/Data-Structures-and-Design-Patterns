using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Decorator
{
    public class BassEnhancer : PlayerEnhancer
    {
        public BassEnhancer(Player player) : base(player)
            { }

        public override void Play()
        {
            base.Play();
            Console.WriteLine("Set the bass effect higher.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_Structural_Patterns.Decorator
{
    public class Video : Player
    {
        public void Play()
        {
            Console.WriteLine("Play a video");
        }
    }
}

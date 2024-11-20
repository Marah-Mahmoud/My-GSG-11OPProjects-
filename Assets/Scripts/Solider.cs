using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Solider : Character
    {
        public Solider(string name,int health,Position position) : base(name,health,position)
        {

        }

        public Solider() : base()
        {

        }

        public override void DisplayInfo()
        {
            Debug.Log("Solider");
            base.DisplayInfo();
        }
    }
}



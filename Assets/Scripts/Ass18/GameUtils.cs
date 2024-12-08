using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ass18
{
    public class GameUtils
    {
        public static string DescribItem <T>(T something)
        {
            return "This item is a " + something;
        }
    }
}

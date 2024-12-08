using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ass18
{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer <string> container = new GameContainer <string>();
            container.SetItem("Healing Posion");

            Debug.Log("Stored item: " + container.GetItem());

            string describ = GameUtils.DescribItem(container.GetItem());
            Debug.Log(describ);
        }
    }
}

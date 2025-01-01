using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
        public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Character solider = new Solider();
            Character officer = new Officer("Policeman",90 ,new Position(5,10,20));

            Character[] characters = {solider,officer};

            foreach (var character in characters)
            {
                character.DisplayInfo();
            }

            Debug.Log("Solider's health before attack = " + solider.Health);
            officer.Attack(10 ,solider , "Kicking");
            Debug.Log("Solider's health after attack = " + solider.Health);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}


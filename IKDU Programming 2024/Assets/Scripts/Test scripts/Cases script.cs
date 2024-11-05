using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Casesscript : MonoBehaviour
{
    public bool doorBellRings;
    public bool someoneIsThere;
    public bool doorIsOpen;
    // Start is called before the first frame update
    void Start()
    {
        if(doorIsOpen == false)
        {
            if(doorBellRings ==true)
            {
            Debug.LogFormat("The doorbell just rung");
                if(someoneIsThere == true)
                {
                    Debug.LogFormat("It's your friend. You open the door");
                    doorIsOpen = true;

                }
                else
                Debug.LogFormat("Guess it was a prank");
            }
            else if (someoneIsThere == true)
            {
                Debug.LogFormat("Thank God the door is closed. You wouldn't wanna know who's out there...");
            }
        }
        else
        {
            Debug.LogFormat("A murdere runs in and kills you! guess you should have closed your door huh?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

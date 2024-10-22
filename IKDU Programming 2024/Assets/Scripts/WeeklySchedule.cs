using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklySchedule : MonoBehaviour
{
    public string weekdays = "Tuesday";
    public int dayOfTheWeek = 1;
    // Start is called before the first frame update
    void Start()
    {
        Schedule();
        Schedule2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Says which day it is according to the string "weekdays" then sets the int "dayOfTheWeek" to the according number.
    /// </summary>
    void Schedule()
    {

    
        switch(weekdays)
        {
           case "Monday":
            Debug.LogFormat("It's monday: TIME FOR CLIMBING!!!");
            dayOfTheWeek=0;
            break;
           case "Tuesday":
           Debug.LogFormat("It's tuesday: TIME FOR VAESEN!");
           dayOfTheWeek=1;
            break;
            case "Wednesday":
           Debug.LogFormat("It's wednesday, ma dude");
           dayOfTheWeek=2;
            break;
            case "Thursday":
           Debug.LogFormat("It's thursday: TIME FOR DND!");
            dayOfTheWeek=3;
            break;
            case "Friday":
           Debug.LogFormat("It's friday: GO DRINK BEER!!!");
            dayOfTheWeek=4;
            break;
            case "Saturday":
           Debug.LogFormat("It's saturday: PLAY THEM GAMES!");
            dayOfTheWeek=5;
            break;
            case "Sunday":
           Debug.LogFormat("It's sunday: CRY, THE WEEKEND IS ALMOST OVER!!!");
            dayOfTheWeek=6;
            break;

        }
    }
    /// <summary>
    /// List of all the weekdays
    List<string> Days = new List<string>()
        {
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday"
        };
    /// <summary>
    /// Displays the date according to the int "dayOfTheWeek"
    /// </summary>
    void Schedule2()
    {
        Debug.LogFormat("Today it is: {0}", Days[dayOfTheWeek]);
    }
}

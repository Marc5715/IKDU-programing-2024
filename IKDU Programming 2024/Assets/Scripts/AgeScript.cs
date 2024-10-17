using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeScript : MonoBehaviour
{
    float awesomeness = 96.4f;
    string myFirstName = "Marcus";
    int currentAge = 23;
    int ageIncrease =1;
    public int timeTravel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("Hello my name is {0} my current age is: {1}. next year I'll be: {2} My awesomeness detector says that my awesomeness today is = {3}%", myFirstName, currentAge, (currentAge + ageIncrease), awesomeness) ;

        Debug.LogFormat("In {0} years I'll be: {1}", timeTravel, (currentAge + timeTravel));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionaryScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        itemInventory.Add("Throwing Knife", 3);
        itemInventory["Asthma spray"] = itemInventory["Asthma spray"] + 3;
        Debug.LogFormat("Number of different items: {0}", itemInventory.Count);
        Debug.LogFormat("Number of Asthma sprays: {0}", itemInventory["Asthma spray"]);

         foreach(KeyValuePair<string, int> kvp in itemInventory)
        {
             Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Dictionary<string, int> itemInventory = new
        Dictionary<string, int>()
    {
        {"potion", 5 },
        {"Asthma spray", 1 },
        {"Mana potion", 10 }
    };
    
}

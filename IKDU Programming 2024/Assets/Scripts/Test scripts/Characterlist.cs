using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterlist : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character("Bob");
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Character villain = hero;
        villain.Name = "Sir Evil of Pentionare";
        villain.PrintStatsInfo();
        hero.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.Name = "War Bow";
        warBow.Damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();




        int listLength = QuestPartyMembers.Count;
        for (int i = 0; i < listLength; i++)
 {
    Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
 } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     List<string> QuestPartyMembers = new List<string>()
 {
 "Grim the Barbarian",
 "Merlin the Wise",
 "Sterling the Knight"
 };

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character("Bob");
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha", 25);
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

        Paladin knight = new Paladin("Sir Pentious", huntingBow);
        knight.PrintStatsInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

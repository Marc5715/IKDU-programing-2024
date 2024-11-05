using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
public int PlayerLives = 3;
 void Start()
 {
 HealthStatus();
 }
 public void HealthStatus()
 {
    while(PlayerLives > 0)
    {
        Debug.Log("Still alive!");
        PlayerLives--;
    }
    Debug.Log("Player KO'd...");
 }
}

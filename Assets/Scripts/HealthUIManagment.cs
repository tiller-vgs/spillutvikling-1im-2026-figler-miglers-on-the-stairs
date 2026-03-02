using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthUIManagment : MonoBehaviour
{

    public List<Health> allHealth = new  List<Health>();
    public int healthCounter;

    public void IncreaseHealth()
    {
       for (int i = 0; i < allHealth.Count; i++)
        {
            if (!allHealth[i].isActive)
            {
                allHealth[i].Activehealth();
                healthCounter++;
                break;

            }
            Debug.Log("Increase button pressed");

        }


       if (healthCounter >= allHealth.Count)
        {
            Debug.Log("Health is full");
        }
    }

    public void DecreaseHealth()
    {
        for (int i = allHealth.Count - 1; i >= 0; i--)
        {
            if (allHealth[i].isActive)
            {
                allHealth[i].DisableHealth();
                healthCounter--;
                break;

            }
            Debug.Log("Decrease button pressed");


        }

        if (healthCounter <= 0   )
        {
            Debug.Log("Player is dead");
        }




    }
}

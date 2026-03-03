using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthhUIManagment : MonoBehaviour
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

            
        }

        if (healthCounter <= 0   )
        {
            Debug.Log("Player is dead");
        }




    }
}

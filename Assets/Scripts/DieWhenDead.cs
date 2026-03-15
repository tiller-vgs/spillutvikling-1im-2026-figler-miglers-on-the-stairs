using Assets.Scripts;
using UnityEngine;

public class DieWhenDead : MonoBehaviour
{
    private HealthService health;

    void Start()
    {
        health = GetComponent<HealthService>();
    }

    void Update()
    {
        if (health != null && health.CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

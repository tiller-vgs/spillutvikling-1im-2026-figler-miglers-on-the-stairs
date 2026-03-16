using Assets.Scripts;
using UnityEngine;

public class GorillaDamage : MonoBehaviour
{
    public float cooldown = 1.5f;   // seconds between hits
    private float lastDamageTime = 0f;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Time.time >= lastDamageTime + cooldown)
            {
                HealthService playerHealth = other.GetComponent<HealthService>();

                if (playerHealth != null)
                {
                    playerHealth.DecreaseHealth(3);
                    Debug.Log($"Player health: {playerHealth.CurrentHealth}");
                }

                lastDamageTime = Time.time;
            }
        }
    }
}
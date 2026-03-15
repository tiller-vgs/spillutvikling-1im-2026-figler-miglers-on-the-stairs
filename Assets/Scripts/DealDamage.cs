using Assets.Scripts;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    public int damageAmount = 25;
    public string targetTag = "enemy";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            HealthService enemyHealth = other.GetComponent<HealthService>();

            if (enemyHealth != null)
            {
                enemyHealth.DecreaseHealth(damageAmount);
                Debug.Log($"Enemy health: {enemyHealth.CurrentHealth}");
            }            
            Destroy(gameObject);
        }
    }
}

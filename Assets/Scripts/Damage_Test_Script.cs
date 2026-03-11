using UnityEngine;

public class Damage_Test_Script : MonoBehaviour
{
    public HealthUIManagment healthUIManagment;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            healthUIManagment.DecreaseHealth();
        }
    }
}

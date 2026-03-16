using UnityEngine;

public class Damage_Script : MonoBehaviour
{
    public int damageamount = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Healthenemy health = collision.gameObject.GetComponent<Healthenemy>();
        if (collision.gameObject.CompareTag("Player")){
            health.TakeDamage(damageamount);
        }
        Debug.Log("Damage");
    }
}
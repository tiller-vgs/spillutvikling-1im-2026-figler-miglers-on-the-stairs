using Assets.Scripts;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float destroytime = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, destroytime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HealthService playerHealth = other.GetComponent<HealthService>();

            if (playerHealth != null)
            {
                playerHealth.DecreaseHealth(1);
            }            
            Destroy(gameObject);
        }
    }
}

using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float fallSpeed = 10f;

    void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}

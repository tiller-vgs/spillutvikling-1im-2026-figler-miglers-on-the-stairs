using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public GameObject bullet;
    public float time = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnNewBullet", 0f, time);
    }

    void SpawnNewBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}

using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpawnBullet : MonoBehaviour
{
    public GameObject bullet;
    public float time = 1f;
    public AudioClip bulletSound;
    private AudioSource _audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        InvokeRepeating("SpawnNewBullet", 0f, time);
    }

    void SpawnNewBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        _audioSource.PlayOneShot(bulletSound);
    }
}

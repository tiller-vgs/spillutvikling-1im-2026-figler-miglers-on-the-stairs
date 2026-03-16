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
        if (IsVisibleToPlayerCamera())
        {
            Instantiate(bullet, transform.position, transform.rotation);
            _audioSource.PlayOneShot(bulletSound);
        }
    }

    bool IsVisibleToPlayerCamera()
    {
        Camera cam = Camera.main;

        Vector3 viewportPoint = cam.WorldToViewportPoint(transform.position);

        return viewportPoint.z > 0 &&
               viewportPoint.x > 0 && viewportPoint.x < 1 &&
               viewportPoint.y > 0 && viewportPoint.y < 1;
    }
}

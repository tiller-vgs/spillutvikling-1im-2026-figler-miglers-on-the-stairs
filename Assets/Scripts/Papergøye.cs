using UnityEngine;

public class Papergøye : MonoBehaviour
{
    public Transform player;
    public GameObject bombPrefab;

    public float flySpeed = 5f;
    public float changeDirectionTime = 3f;
    public float flyHeight = 10f;
    public float dropCooldown = 2f;

    private Vector3 targetPosition;
    private float directionTimer;
    private float dropTimer;

    void Start()
    {
        ChooseNewDirection();
    }

    void Update()
    {
        FlyRandom();
        CheckIfAbovePlayer();
    }

    void FlyRandom()
    {
        directionTimer -= Time.deltaTime;

        if (directionTimer <= 0)
        {
            ChooseNewDirection();
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, flySpeed * Time.deltaTime);
    }

    void ChooseNewDirection()
    {
        directionTimer = changeDirectionTime;

        float randomX = Random.Range(-20f, 20f);
        float randomZ = Random.Range(-20f, 20f);

        targetPosition = new Vector3(randomX, flyHeight, randomZ);
    }

    void CheckIfAbovePlayer()
    {
        dropTimer -= Time.deltaTime;

        if (Mathf.Abs(transform.position.x - player.position.x) < 1.5f &&
            Mathf.Abs(transform.position.z - player.position.z) < 1.5f)
        {
            if (dropTimer <= 0)
            {
                DropBomb();
                dropTimer = dropCooldown;
            }
        }
    }

    void DropBomb()
    {
        Instantiate(bombPrefab, transform.position, Quaternion.identity);
    }
}
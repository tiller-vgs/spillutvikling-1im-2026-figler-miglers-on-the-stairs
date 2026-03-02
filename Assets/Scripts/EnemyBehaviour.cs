using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] private Transform player;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (player == null)
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
            return;
        }

        if (IsVisibleToPlayerCamera())
        {
            float directionX = Mathf.Sign(player.position.x - transform.position.y);
            rb.linearVelocity = new Vector2(directionX * Speed, rb.linearVelocity.y);
        }

        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
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
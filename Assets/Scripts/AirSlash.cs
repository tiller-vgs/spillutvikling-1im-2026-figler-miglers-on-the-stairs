using UnityEngine;

public class AirSlash : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 1f;

    Vector2 direction = Vector2.up;
    bool launched = false;
    SpriteRenderer spriteRenderer;

    void Update()
    {
        if (!launched) return;
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }

    public void Launch(Vector2 dir, float sp)
    {
        this.spriteRenderer ??= GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = true;
        direction = dir.normalized;
        speed = sp;
        launched = true;
        Destroy(gameObject, lifeTime);
    }
}

using UnityEngine;

public class AimingFireSlash : MonoBehaviour
{
    float lastSlashTime;
    bool attackSlash = false;
    public GameObject airSlashPrefab;
    public float slashSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastSlashTime = Time.time - 1f; // Player can slash immediately at the start of the game
    }

    void Update()
    {
        // Hold left mouse button to keep attacking
        attackSlash = Input.GetKey(KeyCode.Mouse0);

        if (attackSlash && Time.time - lastSlashTime >= 1f)
        {
            lastSlashTime = Time.time;
            // Spawn a copy of the AirSlashSprite at the current position/rotation and launch it
            if (airSlashPrefab != null)
            {
                Quaternion prefabRotation = airSlashPrefab.transform.rotation;
                GameObject slash = Instantiate(airSlashPrefab, transform.position, prefabRotation);
                slash.transform.localScale = airSlashPrefab.transform.lossyScale;

                Vector2 direction = transform.up.normalized;

                AirSlash mover = slash.GetComponent<AirSlash>();
                if (mover != null)
                {
                    mover.Launch(direction, slashSpeed);
                }
                else
                {
                    Debug.LogWarning("AirSlash prefab has no AirSlash component");
                }
            }
            else
            {
                Debug.Log($"Slash {Time.time:F2}");
            }
        }
    }
}

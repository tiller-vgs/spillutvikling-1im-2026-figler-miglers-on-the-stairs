using System;
using UnityEngine;

public class AimingFireSlash : MonoBehaviour
{
    DateTime lastSlash = DateTime.MinValue;
    bool attackSlash = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackSlash = true;
        }
        else
        {
            attackSlash = false;
        }
    }

    private void FixedUpdate()
    {
        if (attackSlash && (DateTime.Now - lastSlash).Seconds < 2)
        {
            lastSlash = DateTime.Now;
            Debug.Log($"Slash {DateTime.Now.ToString("T")}");
        }
        else
        {

        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Healthenemy : MonoBehaviour
{
    

    [Header("Health Settings")]
    [SerializeField] public int  maxhealth = 100;
    private int currenthealth;

    [Header ("optional Effects")]
    public GameObject deathEffect;

    void Start()
    {
        currenthealth = maxhealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(25);
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currenthealth -= damageAmount;

        Debug.Log(gameObject.name + " took " + damageAmount + " damage");

        if (currenthealth <= 0)
        {
               Die();
        }
    }
    void Die()
    {
        Debug.Log(gameObject.name + " died");
        if (deathEffect != null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);

    }
}

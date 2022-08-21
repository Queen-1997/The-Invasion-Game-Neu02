using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    Projectile enemyProjectile;
    HealthBar healthBar;

    public int maxHealth = 50;
    public int curHealth;

    void Start()
    {
        curHealth = maxHealth;
        enemyProjectile = GetComponent<Projectile>();

    }

    void OnCollisionEnter(Collision collision)
    {
        
        foreach (ContactPoint contact in collision.contacts)
        {
            TakeDamage(10);
        }

        if (collision.relativeVelocity.magnitude <= 0f){
            Debug.Log("Gestorben du Looser");
        }
    }
    void TakeDamage(int damage){
        curHealth -= damage;
    }
}

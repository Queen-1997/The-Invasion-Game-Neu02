using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour, IDamageable
{
    [SerializeField] GameObject _gameObject;
    [SerializeField] Projectile _projectilePrefab;
    [SerializeField] Explosion _explosionPrefab;
    
    public int maxHealth = 50;
    public int currentHealth;
    public HealthBar _healthBar;
    private Transform _transform;

    void Start(){

        currentHealth = maxHealth;
        _healthBar.SetMaxHealth(maxHealth);
    }

    private void Awake(){
        _transform = transform;
    }

    /*void Update(){

        if(Projectile.OnTriggerEnter())
    }*/

    /*void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Gegner")
        {
            TakeDamage();
        }
    }*/ 

    public void TakeDamage(int damage, Vector3 hitPosition){

        currentHealth -= damage;
        _healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0){
            Explosion(hitPosition);
        }
        
    }

    private void Explosion(Vector3 hitPosition){
        if (_explosionPrefab != null){
            Instantiate(_explosionPrefab, _transform.position, _transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterEnemy : MonoBehaviour
{
    [SerializeField] Projectile _projectilePrefab;
    [SerializeField] Transform _muzzle;
    [SerializeField] [Range(0f, 5f)] float _coolDownTime = 0.25f;
    [SerializeField] Transform _gameObject;

    bool CanFire{

        get{

            _coolDown -= Time.deltaTime;
            return _coolDown <= 0f;
        }
    }

    float _coolDown;

    void Update(){

        if(Vector3.Distance(_gameObject.transform.position, transform.position)<1000f){

            FireProjectile();
        }
        
    }

    void FireProjectile(){

        _coolDown = _coolDownTime;
        Instantiate(_projectilePrefab, _muzzle.position, transform.rotation);

    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] ShipMovementInput _movementInput;
    [Range(1000f, 10000f)]
    float _thrustForce = 7500f,
        _pitchForce = 6000f,
        _rollForce = 1000f,
        _yawForce = 2000f;
        
    
    [SerializeField]
    List<ShipEngine> _engines;

    

    Rigidbody _rigidBody;
    float _thrustAmount, _pitchAmount, _rollAmount, _yawAmount = 0f;

    IMovementControlls ControllInput => _movementInput.MovementControlls;
    
    void Awake(){

        _rigidBody = GetComponent<Rigidbody>();
    }

    void Start(){

        foreach(ShipEngine engine in _engines){
            engine.Init(ControllInput);
        }
        
    }

    void Update(){

        _thrustAmount = ControllInput.ThrustAmount;
        _rollAmount = ControllInput.RollAmount;
        _yawAmount = ControllInput.YawAmount;
        _pitchAmount = ControllInput.PitchAmount;
       

    }

    void FixedUpdate()
    {
        if (!Mathf.Approximately(0f, _pitchAmount))
        {
            _rigidBody.AddTorque(transform.right * (_pitchForce * _pitchAmount * Time.fixedDeltaTime));
        }

        if (!Mathf.Approximately(0f, _rollAmount))
        {
            _rigidBody.AddTorque(transform.forward * (_rollForce * _rollAmount * Time.fixedDeltaTime));
        }

        if (!Mathf.Approximately(0f, _yawAmount))
        {
            _rigidBody.AddTorque(transform.up * (_yawAmount * _yawForce * Time.fixedDeltaTime));
        }

        if (!Mathf.Approximately(0f, _thrustAmount))
        {
            _rigidBody.AddForce(transform.forward * (_thrustForce * _thrustAmount * Time.fixedDeltaTime));
        }

       

        
    }
}

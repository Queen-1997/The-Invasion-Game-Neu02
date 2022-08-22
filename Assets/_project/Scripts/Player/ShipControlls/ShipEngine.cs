using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEngine : MonoBehaviour
{
    [SerializeField] GameObject _thruster;

    IMovementControlls _shipMovementControlls;

    bool ThrustersEnabled => !Mathf.Approximately(0f, _shipMovementControlls.ThrustAmount);

    
    // Update is called once per frame
    void Update()
    {

        ActivateThrusters();
        
    }

    void ActivateThrusters(){

        _thruster.SetActive(ThrustersEnabled);

    }

    public void Init(IMovementControlls movementControlls){

        _shipMovementControlls = movementControlls;
    }
}

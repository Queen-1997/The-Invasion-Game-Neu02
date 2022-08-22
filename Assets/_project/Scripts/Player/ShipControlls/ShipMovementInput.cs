using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementInput : MonoBehaviour
{
    [SerializeField] ShipInputManager.InputType _inputType = ShipInputManager.InputType.HumanDesktop;

    public IMovementControlls MovementControlls { get; private set; }
    
    void Start()
    {
        MovementControlls = ShipInputManager.GetInputcontrolls(_inputType);
    }

    void OnDestroy()
    {
        MovementControlls = null;
    }
}

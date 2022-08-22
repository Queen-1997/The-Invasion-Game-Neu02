using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCockpitControlls : MonoBehaviour
{
    [SerializeField] 
    Transform _joystick;

    [SerializeField] 
    Vector3 _joystickRange = Vector3.zero;

    [SerializeField] 
    List<Transform> _throttles;

    [SerializeField] 
    float _throttleRange = 35f;

    [SerializeField]
    ShipMovementInput _movementInput;

    IMovementControlls ControllInput => _movementInput.MovementControlls;

    // Update is called once per frame
    void Update()
    {
        _joystick.localRotation = Quaternion.Euler(
            ControllInput.PitchAmount * _joystickRange.x,
            ControllInput.YawAmount * _joystickRange.y,
            ControllInput.RollAmount * _joystickRange.z
        );

        Vector3 throttleRotation = _throttles[0].localRotation.eulerAngles;
        throttleRotation.x = ControllInput.ThrustAmount * _throttleRange;
        foreach (Transform throttle in _throttles)
        {
            throttle.localRotation = Quaternion.Euler(throttleRotation);
        }
    }
}

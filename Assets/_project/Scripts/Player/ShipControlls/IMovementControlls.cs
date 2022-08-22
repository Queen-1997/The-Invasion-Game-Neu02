using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementControlls

{
   float YawAmount { get; }
   float PitchAmount { get; }
   float RollAmount { get; }
   float ThrustAmount { get; }
  
}

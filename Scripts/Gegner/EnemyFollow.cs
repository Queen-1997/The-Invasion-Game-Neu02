using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    float speed = 25;
    public Transform target;
    public Transform myTransform;

    // Update is called once per frame
    void Update()
    {

      transform.LookAt(target);
      transform.Translate(Vector3.forward * speed * Time.deltaTime);
      
    }
}

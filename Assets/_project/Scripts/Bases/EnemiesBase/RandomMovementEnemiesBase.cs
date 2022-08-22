using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomMovementEnemiesBase : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float rotationSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isRotatingUp = false;
    private bool isRotatingDown = false;
    private bool isFlying = false;

    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update(){

        if(isWandering == false){
            StartCoroutine(Wander());
        }
        if(isRotatingRight == true){
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        }
        if(isRotatingLeft == true){
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
        }
        if(isRotatingUp == true){
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        }
        if(isRotatingDown == true){
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);
        }
        if(isFlying == true){
            rb.AddForce(transform.forward * movementSpeed);
        }
    }

    IEnumerator Wander(){

        int rotationTime = Random.Range(1,3);
        int rotateWait = Random.Range(1,3);
        int rotateDirection = Random.Range(1,2);
        int flyWait = Random.Range(1,3);
        int flyTime = Random.Range(1,3);

        isWandering = true;

        yield return new WaitForSeconds(flyWait);

        isFlying = true;

        yield return new WaitForSeconds(flyTime);

        isFlying = false;

        yield return new WaitForSeconds(rotateWait);

        if(rotateDirection == 1){
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }

        if(rotateDirection == 2){
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }
        if(rotateDirection == 3){
            isRotatingUp = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingUp = false;
        }

        if(rotateDirection == 4){
            isRotatingDown = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingDown = false;
        }

        isWandering = false;
    }

}

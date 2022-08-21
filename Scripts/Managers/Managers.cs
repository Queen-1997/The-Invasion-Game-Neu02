using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers _instance;

    void Awake(){
        
        if (_instance !=null && _instance != this){

            Destroy(this.gameObject);

        }else{

            _instance = this;
            DontDestroyOnLoad(this.gameObject);

        }

    }
}

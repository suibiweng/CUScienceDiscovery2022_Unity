using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    public float speed;
    public bool second;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if(second){
        if(Input.GetKey(KeyCode.O)){

            transform.Translate(new Vector3(0,0,-speed));

        }

        if(Input.GetKey(KeyCode.L)){

            transform.Translate(new Vector3(0,0,speed));

        }


        }else{

        if(Input.GetKey(KeyCode.W)){

            transform.Translate(new Vector3(0,0,-speed));

        }

        if(Input.GetKey(KeyCode.S)){

            transform.Translate(new Vector3(0,0,speed));

        }



        }


        
    }
}

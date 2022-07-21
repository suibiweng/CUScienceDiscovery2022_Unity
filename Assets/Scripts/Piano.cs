using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;

    // Start is called before the first frame update
    void Start()
    {
        c1.SetActive(false);
        c2.SetActive(false);
       c3.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            c1.SetActive(true);      
        }else{

             c1.SetActive(false);  
        }

        if(Input.GetKey(KeyCode.S)){
            c2.SetActive(true);      
        }else{

             c2.SetActive(false);  
        }
        if(Input.GetKey(KeyCode.D)){
            c3.SetActive(true);      
        }else{

             c3.SetActive(false);  
        }
        
    }
}

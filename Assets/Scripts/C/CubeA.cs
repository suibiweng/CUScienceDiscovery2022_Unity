using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeA : MonoBehaviour
{
    public GameObject cubeB;
    // Start is called before the first frame update
    void Start()
    {
       cubeB.BroadcastMessage("SayHello",10); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

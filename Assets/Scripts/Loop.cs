using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public GameObject obj;
   public  float gap=2;    // Start is called before the first frame update
    
    
    public int sum;
    void Start()
    {
        for(int i=0;i<5;i++){

            for(int j=0;j<5;j++){

              //  int mul=i*j;

                for(int k=0;k<5;k++){

 Instantiate(obj,new Vector3(transform.position.x+gap*i  ,transform.position.y+gap*j ,transform.position.z+gap*k)  , Quaternion.identity);

                }


               


            }

        }



        /*

        float gap=10;
    for(int i=0;i<100;i=i+1){

          //Instantiate(obj,new Vector3(transform.position.x+gap*i  ,transform.position.y ,transform.position.z)  , Quaternion.identity);
   

    }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

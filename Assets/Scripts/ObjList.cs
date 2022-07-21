using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjList : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    int [] array;
    // Start is called before the first frame update
    void Start()
    {
      array = new int [6];

        array[0]=4;
        array[1]=4;
        array[2]=4;
        array[3]=4;
        array[4]=4;
        array[5]=4;
        
        print(array[5]);

        for(int i=0;i<array.Length;i++){

                print(array[i]);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

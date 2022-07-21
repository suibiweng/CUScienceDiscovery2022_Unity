using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPI : MonoBehaviour
{
  public bool check;
    int Ry;
   public float fy;
    // Start is called before the first frame update
    void Start()
    {
        Ry=20;
        fy=fy*100;

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButton(1)){

        transform.Rotate(new Vector3(0,1,0));

      }else{

  transform.Rotate(new Vector3(0,0,0));

      }
    }
}

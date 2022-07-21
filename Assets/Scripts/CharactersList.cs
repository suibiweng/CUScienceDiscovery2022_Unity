using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersList : MonoBehaviour
{
    int index;
    public GameObject [] Dragons;
    // Start is called before the first frame update
    void Start()
    {

        index=0;
        for(int i=0;i<Dragons.Length;i++){
            Dragons[i].SetActive(false);
        }
            Dragons[index].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    


        if(Input.GetKeyDown(KeyCode.A)){
            Previous();
        }

         if(Input.GetKeyDown(KeyCode.D)){

                Next();
        }

        
    }

    void Next(){


  for(int i=0;i<Dragons.Length;i++){
            Dragons[i].SetActive(false);
        }
index = index+1;
 if(index>Dragons.Length-1)
        index=0;


    Dragons[index].SetActive(true);

    }

    
    
    
    void Previous(){


  for(int i=0;i<Dragons.Length;i++){
            Dragons[i].SetActive(false);
        }
index = index-1;

    if(index<0)
        index=Dragons.Length-1;


    Dragons[index].SetActive(true);


    }



}

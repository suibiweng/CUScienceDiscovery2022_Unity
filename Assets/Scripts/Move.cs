using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
public int Score;
public Text ScoreText;

    // Start is called before the first frame update
public float speed;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKey(KeyCode.W))
        {

            transform.Translate(new Vector3(0,0,speed));

        }

        if(Input.GetKey(KeyCode.S))
        {

            transform.Translate(new Vector3(0,0,-speed));

        }

              if(Input.GetKey(KeyCode.A))
        {

             transform.Translate(new Vector3(-speed,0,0));

        }

              if(Input.GetKey(KeyCode.D))   
        {

            transform.Translate(new Vector3(speed,0,0));

        }
        ScoreText.text="Score: "+Score;
        
    }

    void OnCollisionEnter(Collision collision){

    if(collision.gameObject.tag != "Floor"){
      //  collision.gameObject.SetActive(false);

      
    }
    if(collision.gameObject.tag == "Enemy"){
        Score=Score+1;


        float Rx;
        float Rz;

        Rx= Random.RandomRange(-5,5);
        Rz= Random.RandomRange(-5,5);

        collision.gameObject.transform.position=
        new Vector3(Rx,
        collision.gameObject.transform.position.y,
        Rz );




    }



            

    }
     
}

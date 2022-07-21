using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheBall : MonoBehaviour
{

    public GameObject VFX;
    public Text Score1_text;
     public Text Score2_text;

public int Score1;
public int Score2;
  public  float speedX;
    public  float speedY;
    // Start is called before the first frame update
    void Start()
    {
        speedX=-0.01f;
        speedY=0.01f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speedX,0,speedY));
     Score1_text.text=""+Score1;
    Score2_text.text=""+Score2;


        
    }
    void OnCollisionEnter(Collision collision){

    Instantiate(VFX,transform.position,Quaternion.identity);

        if(collision.gameObject.tag == "LongWall"){

        speedY=speedY*-1;


        }

    if(collision.gameObject.tag == "SideWallRight"){

        speedX=speedX*-1;
            ResetBall();
            Score1=Score1+1;
        }



            if(collision.gameObject.tag == "SideWallLeft"){

        speedX=speedX*-1;
            ResetBall();

                 Score2=Score2+1;
        }



        if(collision.gameObject.tag =="Pedal"){

            speedX=speedX*-1;

        }

    }
    void ResetBall(){
            transform.position=new Vector3(0,0.5f,0);

    }



}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class bubble : MonoBehaviour {

    // Use this for initialization
    private sceneLoader sceneLoader;
    public Sprite[] hitsprites;
    private int timesHit;
    public Text score;

       private   bool isBreakable ;

    public int maxHit;
    public static int bubbleBreakCount=0 ;



    public AudioClip crack;
    float volume = 441f;


    
   public  static  int scores = 0;





    void Start () {



        scores = 0;



        bool isBreakable = (this.tag == "Breakable");

        if(isBreakable)
        {
            bubbleBreakCount++;//shuru me hi cunt krke raklo ki scene me kitne bubbles h
            Debug.Log(bubbleBreakCount);
         
        }
        timesHit = 0;
        sceneLoader = GameObject.FindObjectOfType<sceneLoader>();
	}
	




	// Update is called once per frame
	void Update () {

        score.text = "Score : " + scores.ToString();


    }



   



     void OnCollisionEnter2D(Collision2D collision)
    {
       if(gameObject.tag=="Breakable")
        {
            handleHits();
            scores+=Random.Range(1,3);
        
        }
        AudioSource.PlayClipAtPoint(crack, transform.position,volume);

    }




    void handleHits()
    {
        timesHit++;//to track  the times it got breaked partially or full

        if (timesHit >= maxHit)
        {
            bubbleBreakCount--;//means one bricj destroyed( track)
            Debug.Log(bubbleBreakCount);




            checkLevelClear(); //agar kuch ni bacha fodne ko to nextscene pe jao




            Destroy(gameObject);

        }
        else
        {
            loadSprite();
        }


    }







    void loadSprite()
    {


        int spriteIndex = timesHit - 1;//-1 beacuse it starts from 0
        this.GetComponent<SpriteRenderer>().sprite = hitsprites[spriteIndex];//look in inspector also 
    }








    
    void checkLevelClear()

    {
        if (bubbleBreakCount <= 0)
        {



            Debug.Log("levelCleared");




            //FIRSE BUBBLES INSTATIATE KARAO





            sceneLoader.loadNxtScene();



        }
    }
}

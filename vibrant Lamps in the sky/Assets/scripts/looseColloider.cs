using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class looseColloider : MonoBehaviour {


    public bubble bubble;

    public Ball ball;
    public SceneManager sm;





  void OnTriggerEnter2D(Collider2D collision)

    {






       
        
            bubble.bubbleBreakCount = 0;//agle scene me natak na ho diff bubbles dekh kar,thats why
            SceneManager.LoadScene("gameOver");

        
       
      
    }


    
   



}



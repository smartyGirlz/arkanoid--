using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {






        private Camera cam;

        void Start()
        {
        //if cam=null
           cam = Camera.main;

   

    }

        void Update()
        {




            float mousePosX = cam.ScreenToWorldPoint(Input.mousePosition).x;
        //Transforms position from screen space into world space. screentowordspace
        this.gameObject.transform.position = new Vector2(mousePosX, this.gameObject.transform.position.y);

        // means y k lie wai transform raega jo phle se h


    }




    //annother method to translate screenspace to world space
    //screen space- ddefined by pixels
    //viewportspace- size of viewport and we translate our position to word space

    // so first we need camera

    /*
     now inside fixedupdate-ie called once per phy
     
     
     void fidexupdate()
     {
     
    vector3 rawpositn=    cam.ScreenToWorldPoint( and what we wanna change ie.  Input.mousePosition)//works fr android also
    
    vector3 targetpos= new vector3(rawpositn.x,0,0);
    Rigidbody2d.moveposition(targetposition);

    OR IF TO CLAMP

    VECTOR3 uppercorener=new vector3(Screen.widht,Screen.Height,0)
    

    }
     
     
     */
}



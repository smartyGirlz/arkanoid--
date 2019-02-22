using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class gps : MonoBehaviour
{


    public GameObject ss;
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesPlatform.Activate();
        login();
    }

 


    public void login()
    {
        if(Social.localUser.authenticated)
        {
            print("logged in succesfully");
            ss.SetActive(true);
        }
        else
        {
            print("na na na login");
        }
    }
}

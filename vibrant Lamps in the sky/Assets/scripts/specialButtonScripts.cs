using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class specialButtonScripts : MonoBehaviour {
    
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }


    public void rateus()
    {
#if UNITY_ANDROID
        Application.OpenURL("market://details?id=com.sclub.arkanoid");
#elif UNITY_IPHONE
 Application.OpenURL("itms-apps://itunes.apple.com/app/idYOUR_ID");
#endif
    }

    public void instructn()
    {
        SceneManager.LoadScene("Instructions");
    }
}

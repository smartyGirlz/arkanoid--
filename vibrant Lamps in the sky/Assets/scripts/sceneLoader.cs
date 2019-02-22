using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneLoader : MonoBehaviour
{

    public int currentSceneIndex;

    public int savage;





    //NEXT SCENE LOAD
    public void loadNxtScene()

    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex + 1);

    }




    //START SCENE LOADING
    public void loadStartScene()
    {

        SceneManager.LoadScene(0);

    }














}
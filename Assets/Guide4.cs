using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide4 : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void goNextScene()
    {
        SceneManager.LoadSceneAsync(6);
    }
    public void goPreviousScene()
    {
        SceneManager.LoadSceneAsync(4);
    }
}

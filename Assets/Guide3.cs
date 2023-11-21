using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide3 : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void goNextScene()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void goPreviousScene()
    {
        SceneManager.LoadSceneAsync(3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide2 : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void goNextScene()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void goPreviousScene()
    {
        SceneManager.LoadSceneAsync(2);
    }
}

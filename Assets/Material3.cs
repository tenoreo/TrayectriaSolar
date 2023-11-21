using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Material3 : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void goPreviousScene()
    {
        SceneManager.LoadSceneAsync(10);
    }
}

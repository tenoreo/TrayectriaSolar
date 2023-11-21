using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Material1 : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void goNextScene()
    {
        SceneManager.LoadSceneAsync(10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide7 : MonoBehaviour
{
    public void goHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void goPrevious()
    {
        SceneManager.LoadSceneAsync(7);
    }
}

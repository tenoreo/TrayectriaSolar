using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainCamera : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void goGuide()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void goMaterial()
    {
        SceneManager.LoadSceneAsync(9);
    }
}

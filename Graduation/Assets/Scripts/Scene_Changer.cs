using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    [SerializeField]
    private int nextSceneIndex;
    [SerializeField]
    private bool overRide = false;
    [SerializeField]
    private int newPreviousSceneIndex;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: nextSceneIndex);
    }

    public void PreviousScene()
    {
        

        if (overRide == true)
        {
            SceneManager.LoadScene(sceneBuildIndex: newPreviousSceneIndex);
        }
        else
        {
            SceneManager.LoadScene(sceneBuildIndex: nextSceneIndex - 2);
        }

    }
}

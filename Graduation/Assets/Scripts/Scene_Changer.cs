using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    [SerializeField]
    private int nextSceneIndex;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneBuildIndex: nextSceneIndex);
    }

    public void PreviousScene()
    {
        int previousSceneIndex = nextSceneIndex - 1;

        if (previousSceneIndex <= 0)
        {
            //Do nothings
        }
        else
        {
            SceneManager.LoadScene(sceneBuildIndex: nextSceneIndex - 1);
        }
    }
}

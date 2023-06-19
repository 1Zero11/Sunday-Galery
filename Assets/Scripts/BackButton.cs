using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public string BackSceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            StartCoroutine(LoadSceneAsyncAndChangeOrientation());
        }
    }

    public void Back()
    {
        StartCoroutine(LoadSceneAsyncAndChangeOrientation());
    }

    IEnumerator LoadSceneAsyncAndChangeOrientation()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(BackSceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        
        Screen.orientation = ScreenOrientation.Portrait;
    }
}

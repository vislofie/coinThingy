using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneLoadManager : MonoBehaviour
{
    public int CurrentSceneIndex { get { return SceneManager.GetActiveScene().buildIndex; } }

    public static SceneLoadManager _instance;
    public static SceneLoadManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<SceneLoadManager>();
            return _instance;
        }
    }

    private Coroutine _loadingCoroutine;

    /// <summary>
    /// Loads scene by given in index after given seconds
    /// </summary>
    /// <param name="sceneBuildIndex">scene build index</param>
    /// <param name="time">time in seconds</param>
    public void LoadSceneAfterGivenTime(int sceneBuildIndex, float time)
    {
        if (_loadingCoroutine != null)
            StopCoroutine(_loadingCoroutine);

        _loadingCoroutine = StartCoroutine(LoadSceneAfterGivenTimeRoutine(sceneBuildIndex, time));
    }

    private IEnumerator LoadSceneAfterGivenTimeRoutine(int sceneIndex, float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneIndex);
    }
}

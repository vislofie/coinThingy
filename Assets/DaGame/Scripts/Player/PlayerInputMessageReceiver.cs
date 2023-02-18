using UnityEngine;

public class PlayerInputMessageReceiver : MonoBehaviour
{
    private void OnRestart()
    {
        SceneLoadManager.Instance.LoadSceneAfterGivenTime(SceneLoadManager.Instance.CurrentSceneIndex, 0);
    }
}

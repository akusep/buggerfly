using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class SceneSwitcher : MonoBehaviour
{
    public void SwitchScene()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode

        SceneManager.LoadScene("Buggerfly");

    }
}
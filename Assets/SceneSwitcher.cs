using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class SceneSwitcher : MonoBehaviour
{
    public void SwitchScene()
    {
        transform.DOPunchScale(new Vector3(1, 2, 3), 3);
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode

        SceneManager.LoadScene("Buggerfly", LoadSceneMode.Additive);

    }
}
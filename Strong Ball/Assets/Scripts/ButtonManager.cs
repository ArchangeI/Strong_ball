using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public string sceneName;
    public Button playButton;
    public Button exitButton;

    void Start()
    {
        playButton.onClick.AddListener(PlayOnClick);
        exitButton.onClick.AddListener(ExitOnClick);
    }

    void PlayOnClick()
    {
        SceneManager.LoadScene(sceneName);
    }

    void ExitOnClick()
    {
        Application.Quit();
    }
}

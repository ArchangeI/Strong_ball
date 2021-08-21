using UnityEngine;
using UnityEngine.SceneManagement;

public class PressToMenu : MonoBehaviour
{
    public string sceneName;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(Input.GetKey(KeyCode.R))
        {
            RestartOnClick();
        }
    }
    void RestartOnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}

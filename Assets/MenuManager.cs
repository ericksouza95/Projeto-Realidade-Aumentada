using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    void PlayGame()
    {
        SceneManager.LoadScene("LuaScene");
    }

    void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}

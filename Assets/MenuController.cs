using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Button playButton; // Botão Play
    public Button quitButton; // Botão Quit

    void Start()
    {
        // Adiciona eventos aos botões
        playButton.onClick.AddListener(PlayGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    void PlayGame()
    {
        SceneManager.LoadScene("NomeDaCenaDoJogo"); // Substitua pelo nome da sua cena do jogo
    }

    void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}

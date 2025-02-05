using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // Importa suporte para botões

public class SceneLoader : MonoBehaviour
{
    public Button playButton;  // Referência ao botão Play

    void Start()
    {
        if (playButton != null)
        {
            playButton.onClick.AddListener(() => LoadScene("LuaScene"));  // Adiciona evento ao botão
        }
        else
        {
            Debug.LogError("Botão não foi atribuído no Inspector!");  // Mensagem de erro
        }
    }

    void LoadScene(string sceneName)
    {
        Debug.Log("Carregando cena: " + sceneName);
        SceneManager.LoadScene(sceneName);  // Carrega a cena
    }
}
i
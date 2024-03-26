using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;

    private void Start()
    {
        _startGameButton.onClick.AddListener(StartGameButton);
    }
    private void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }

}

 

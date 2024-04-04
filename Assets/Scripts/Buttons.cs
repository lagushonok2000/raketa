using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _level1;
    [SerializeField] private Button _level2;
    [SerializeField] private Button _level3;
    [SerializeField] private Button _level4;
    [SerializeField] private Button[] _massivButtons;
    private void Start()
    {
        for (int pizda = 0; pizda < _massivButtons.Length; pizda++)
        {
            int j = pizda;
            _massivButtons[pizda].onClick.AddListener(() => ChangeLevels(j));
        }
        //_level1.onClick.AddListener(() => ChangeLevels(0));
        //_level2.onClick.AddListener(() => ChangeLevels(1));
        //_level3.onClick.AddListener(() => ChangeLevels(2));
        //_level4.onClick.AddListener(() => ChangeLevels(3));
        Debug.Log(CurrentLevel.LevelIndex);
        _startGameButton.onClick.AddListener(StartGameButton);
     
    }
    private void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }

    private void ChangeLevels(int levelIndex)
    {
        CurrentLevel.LevelIndex = levelIndex;
        StartGameButton();
    }

}

 

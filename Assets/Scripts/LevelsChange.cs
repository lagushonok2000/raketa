using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsChange : MonoBehaviour
{
    [SerializeField] private GameObject[] _levels;

    private void Start()
    {
        Debug.Log(CurrentLevel.LevelIndex);
        for (int i = 0; i < _levels.Length; i++)
        {
            _levels[i].SetActive(false);
        }
        _levels[CurrentLevel.LevelIndex].SetActive(true);
    }
}

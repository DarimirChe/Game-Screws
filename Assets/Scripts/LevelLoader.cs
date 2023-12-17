using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;

    public void Start()
    {
        _levelText.text = "Уровень " + (Progress.Instance.Level + 1).ToString();
    }
    public void StartLevel()
    {
        int level = Progress.Instance.Level;
        SceneManager.LoadScene(level + 1);
    }
}
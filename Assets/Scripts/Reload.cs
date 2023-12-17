using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    public void ReloadLevel()
    {
        int level = Progress.Instance.Level;
        SceneManager.LoadScene(level + 1);
    }
}

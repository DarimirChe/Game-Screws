using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private int _cnt;
    [SerializeField] private GameManager _gameManager;

    private void Start()
    {
        _cnt *= 15;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        Destroy(other.gameObject);
        _cnt--;
        if (_cnt == 0)
        {
            Debug.Log("Win!");
            _gameManager.Win();
        }
    }
}

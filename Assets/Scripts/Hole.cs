using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] GameObject _holeTrigger; // ссылка на префаб триггера
    [SerializeField] GameObject _screw; // ссылка на префаб болта
    [SerializeField] Transform _spawnPoint;
    [SerializeField] private bool _isOpen = true;

    private void OnMouseDown() // Когда на отверстие нажали
    {
        Debug.Log("OnMouseDown " + gameObject.name);
        Krytit();
    }

    public void Krytit()
    {
        if (_isOpen && GlobalScrewStatus.isHaveScrew) // если отверстие "открыто" и болт выбран
        {
            GlobalScrewStatus.CurrentScrew.Move(_spawnPoint.position);
            GlobalScrewStatus.isHaveScrew = false;
            GlobalScrewStatus.CurrentScrew = null;
        }
    }

    public void SetOpen(bool isOpen)
    {
        _isOpen = isOpen;
    }
}
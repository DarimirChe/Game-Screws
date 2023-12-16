using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    [SerializeField] private Hole _hole;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Detail" || other.GetComponent<Screw>())
        {
            _hole.SetOpen(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Detail" || other.GetComponent<Screw>())
        {
            _hole.SetOpen(true);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown " + gameObject.name);
        _hole.Krytit();
    }
}

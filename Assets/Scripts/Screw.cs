using UnityEngine;

public class Screw : MonoBehaviour
{
    private Vector3 _startPos;
    private bool _isUp = false;

    void Start()
    {
        _startPos = transform.position;
    }

    public void Move(Vector3 position)
    {
        transform.position = position;
        _startPos = position;
    }
    private void OnMouseDown()
    {
        if (!GlobalScrewStatus.isHaveScrew)
        {
            _isUp = true;
            MoveScrew(_isUp);
            //GlobalScrewStatus.ReverseStatus();
            //GlobalScrewStatus.Screw(this.gameObject);
            GlobalScrewStatus.CurrentScrew = this;
            GlobalScrewStatus.isHaveScrew = true;
            Debug.Log("OnMouseDown " + gameObject.name);
        }
        else if (GlobalScrewStatus.CurrentScrew == this)
        {
            _isUp = false;
            MoveScrew(_isUp);
            GlobalScrewStatus.CurrentScrew = null;
            GlobalScrewStatus.isHaveScrew = false;
        }
    }

    public static void DestroyScrew()
    {
    }
    private void MoveScrew(bool _screwStatus)
    {
        if (_screwStatus)
        {
            transform.position = new Vector3(_startPos.x, _startPos.y, _startPos.z - 0.25f);
        }
        else
        {
            transform.position = new Vector3(_startPos.x, _startPos.y, _startPos.z);
        }
    }
}

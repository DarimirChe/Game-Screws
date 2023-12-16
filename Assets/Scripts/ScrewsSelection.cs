using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrewsSelection : MonoBehaviour
{
    //[SerializeField] GameObject Screw;

    public bool Twisted = false;

    //обьявляем переменную для луча
    //   RaycastHit hit;
    //  Ray MyRay;

    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }




    //if (Input.GetKeyDown(KeyCode.Mouse0))
    //{
    //    MyRay = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    Debug.DrawRay(MyRay.origin, MyRay.direction * 10, Color.yellow);
    //    if (Physics.Raycast(MyRay, out hit, 100))
    //    {
    //        MeshFilter filter = hit.collider.GetComponent(typeof(MeshFilter)) as MeshFilter;
    //        if (filter)
    //        {
    //            //имя обьекта по которому щелкнули мышей               
    //           // Debug.Log(filter.gameObject.name);
    //            if (filter.gameObject.name == "hole")
    //            {
    //                Debug.Log("OnHole");
    //                Vector3 scores = filter.gameObject.transform.position;
    //                Screw.transform.position = scores;
    //                SelectScrew(true);

    //            }
    //        }
    //    }
    //}
    void OnMouseDown()
    {

        Twisted = !Twisted;
        SelectScrew(Twisted);
    }


    public void SelectScrew(bool Twisted)
    {
        if (Twisted)
        {
            anim.SetTrigger("Out");
            Debug.Log("Untwisted");

        }
        else
        {
            anim.SetTrigger("In");
            Debug.Log("Twisted");


        }
    }

}

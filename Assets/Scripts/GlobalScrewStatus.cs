using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScrewStatus : MonoBehaviour
{
    public static bool isHaveScrew = false;
    public static bool OpenHole = false;
    public static GameObject ScrewToDelete;
    public static Screw CurrentScrew;

    public static void ReverseStatus()
    {
        isHaveScrew = !isHaveScrew;
    }
    public static void Screw(GameObject screwToDelete)
    {
        ScrewToDelete = screwToDelete;
    }
    public static void DeleteScrew()
    {
        if (isHaveScrew)
        {
            Destroy(ScrewToDelete);
            isHaveScrew = !isHaveScrew;
        }
    }

    public static void OpenHoleTrue()
    {
        OpenHole = true;
    }
    public static void OpenHoleFalse()
    {
        OpenHole = false;
    }
}

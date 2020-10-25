using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public static CheckPointController instance;
    private CheckPoint actual_checkPoint;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public static CheckPointController GetInstance()
    {
        return instance;
    }

    public CheckPoint ActualCheckPoint()
    {
        return actual_checkPoint;
    }

    public void changeCheckPoint(CheckPoint checkPoint)
    {
        if(actual_checkPoint != null)
        {
            if(!actual_checkPoint.Equals(checkPoint))
            {
                actual_checkPoint = checkPoint;
            }
        }
        else
        {
            actual_checkPoint = checkPoint;
        }
    }
}

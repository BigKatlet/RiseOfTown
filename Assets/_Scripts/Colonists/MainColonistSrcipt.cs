using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MainColonistSrcipt : MonoBehaviour
{
    public string COLONIST_WORK_PROFESSION;

    private string COLONIST_BIOGRAPHY_NAME;


    //Some theory 
    /// 
    /// eventTimes:
    /// 0 - go sleep,
    /// 51 - go work
    /// 101 - go eat (and kick some asses)
    /// 
    /// 0 - 50: sleep
    /// 51 - 100: work
    /// 101 - 120: eat, kick some asses
    /// repeat
    /// profit
    /// -------------------------------------

    private void Start()
    {
        COLONIST_BIOGRAPHY_NAME = COLONIST_BIOGRAPHY_GetRandomName();
    }

    //Biography
    private string COLONIST_BIOGRAPHY_GetRandomName()
    {
        string ranName;
        string[] ranNames = { "Anne", "John", "Albert"};
        ranName = ranNames[Random.Range(0, ranNames.Length)];
        return ranName;
    }
}

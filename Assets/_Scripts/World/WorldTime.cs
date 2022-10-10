using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldTime : MonoBehaviour
{
    [SerializeField] private float TIME_current;
    public static float TIME_world;
    private float TIME_dayPast;

    private bool halfOfDay;
    private float TIME_dayLen = 120; //(sec)

    //DEBUG
    public Text DEBUG_IND_DAYTIME;
    public Text DEBUG_IND_DAYPAST;
    //Some theory
    /// work time:
    /// dayLen:
    /// # - dark
    /// $ - mid
    /// & - light
    ///
    /// 0 10 20 30 40 50 60 70 80 90 100 110 120
    /// # #  #  #  $  $  &  &  &  &  &   $   $
    /// 




    private void Start()
    {
        TIME_current = 110; TIME_world = TIME_current;
        DEBUG_IND_DAYTIME.text = TIME_world.ToString();
        TIME_dayPast = 0; DEBUG_IND_DAYPAST.text = "Day: " + TIME_dayPast.ToString();
        StartCoroutine(CountTime());
    }

    //Time counter
    private IEnumerator CountTime()
    {
        //Waiting 1s
        yield return new WaitForSeconds(1f);
        //Adding time
        TIME_current++; TIME_world = TIME_current; DEBUG_IND_DAYTIME.text = TIME_world.ToString();
        //Next day
        if (TIME_world > TIME_dayLen) { 
            //Time magic
            TIME_current = 0; TIME_world = TIME_current;
            DEBUG_IND_DAYTIME.text = TIME_world.ToString();
            TIME_dayPast++; DEBUG_IND_DAYPAST.text = "Day: " + TIME_dayPast.ToString();
        }
        //Infinite loop
        StartCoroutine(CountTime());
    }

    //Za warudo!
    /*private void StopTime()
    {

    }*/
}

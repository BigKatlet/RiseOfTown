using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeColonistScript : MonoBehaviour
{

    public GameObject COLONIST_LIFE_POINTS_WORK;
    public GameObject COLONIST_LIFE_POINTS_SLEEP;
    public GameObject COLONIST_LIFE_POINTS_RELAX;

    public GameObject COLONIST_LIFE_IMAGE;

    
    
    private bool isWorkDone;

    public int[] eventTimes = { 0, 50, 100 };

    private void Start()
    {
        isWorkDone = false;
    }

    private void GoToWork()
    {
        transform.position += (COLONIST_LIFE_POINTS_WORK.transform.position - transform.position).normalized * 5 * Time.deltaTime;
        COLONIST_LIFE_IMAGE.GetComponent<SpriteRenderer>().enabled = true;
        if (Vector2.Distance(COLONIST_LIFE_POINTS_WORK.transform.position, this.gameObject.transform.position) < 0.1f)
        {
            this.gameObject.transform.position = COLONIST_LIFE_POINTS_WORK.transform.position;
            COLONIST_LIFE_IMAGE.GetComponent<SpriteRenderer>().enabled = false;
            if(isWorkDone == false)
            {
                this.gameObject.GetComponent<WorkColonistScript>().COLONIST_WORK_WORK();
            }
            else
            {
                //Work done, nuh the bebra.
            }
            isWorkDone = true;
        }
    }
    private void GoToSleep()
    {
        transform.position += (COLONIST_LIFE_POINTS_SLEEP.transform.position - transform.position).normalized * 5 * Time.deltaTime;
        COLONIST_LIFE_IMAGE.GetComponent<SpriteRenderer>().enabled = true;
        if (Vector2.Distance(COLONIST_LIFE_POINTS_SLEEP.transform.position, this.gameObject.transform.position) < 0.1f)
        {
            this.gameObject.transform.position = COLONIST_LIFE_POINTS_SLEEP.transform.position;
            COLONIST_LIFE_IMAGE.GetComponent<SpriteRenderer>().enabled = false;
        }
        isWorkDone = false;
    }
    private void GoToRelax()
    {
        transform.position += (COLONIST_LIFE_POINTS_RELAX.transform.position - transform.position).normalized * 5 * Time.deltaTime;
        COLONIST_LIFE_IMAGE.GetComponent<SpriteRenderer>().enabled = true;
        if (Vector2.Distance(COLONIST_LIFE_POINTS_RELAX.transform.position, this.gameObject.transform.position) < 0.1f)
        {
            this.gameObject.transform.position = COLONIST_LIFE_POINTS_RELAX.transform.position;
            COLONIST_LIFE_IMAGE.GetComponent<SpriteRenderer>().enabled = false;
        }
        isWorkDone = false;
    }

    private void Update()
    {
        //0                                    //50
        if (WorldTime.TIME_world > eventTimes[0] && WorldTime.TIME_world < eventTimes[1])
        {
            //SLEEP

            //DEBUG
            //Debug.Log("[COLONIST WORK]:Sleep time");

            GoToSleep();
            
        }
        //50                                    //100
        if (WorldTime.TIME_world > eventTimes[1] && WorldTime.TIME_world < eventTimes[2])
        {
            //WORK

            //DEBUG
            //Debug.Log("[COLONIST WORK]:Work time");

            GoToWork();
        }
        //100                          //120           
        if (WorldTime.TIME_world > eventTimes[2] && WorldTime.TIME_world < 120)
        {
            //RELAX

            //DEBUG
            //Debug.Log("[COLONIST WORK]:Relax time");

            GoToRelax();
        }
    }
}

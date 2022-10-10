using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkColonistScript : MonoBehaviour
{
    private GameObject WORK_PLACE;

    private Vector2 PRODUCTION_SPAWN_POINT;

    private void Start()
    {
        WORK_PLACE = this.gameObject.GetComponent<LifeColonistScript>().COLONIST_LIFE_POINTS_WORK;
        PRODUCTION_SPAWN_POINT.x = WORK_PLACE.transform.position.x;
        PRODUCTION_SPAWN_POINT.y = WORK_PLACE.transform.position.y; PRODUCTION_SPAWN_POINT.y -= 1;
    }

    public void COLONIST_WORK_WORK()
    {
        //Debug
        Debug.Log("[WORKING]: Colonist is working");
        //Adding to scene
        GameObject production = WORK_PLACE.GetComponent<WorkHouseScript>().PRODUCTION;
        GameObject PRODUCTION_SHEET = Instantiate(production, PRODUCTION_SPAWN_POINT, Quaternion.identity);
        Object PRODUCITON_RESULT = PRODUCTION_SHEET.GetComponent<Object>();
        //
        PRODUCITON_RESULT.OBJECT_AMOUNT = 25;
    }
}

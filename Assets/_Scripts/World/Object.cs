using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Object : MonoBehaviour
{
    public int OBJECT_AMOUNT;
    public int OBJECT_ID;

    public Text OBJECT_IND_AMOUNT;

    private void Update()
    {
        OBJECT_IND_AMOUNT.text = OBJECT_AMOUNT.ToString();
    }
}

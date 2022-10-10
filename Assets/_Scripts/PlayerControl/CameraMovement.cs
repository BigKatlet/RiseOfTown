using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private float movSpeed;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        //Ask
        Vector3 movInput = new Vector2();
        movInput.x = Input.GetAxis("Horizontal"); movInput.y = Input.GetAxis("Vertical");
        //Arbeiten
        this.transform.position += movInput * movSpeed;
    }
}

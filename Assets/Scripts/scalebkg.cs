using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class scalebkg : MonoBehaviour
{
    void Update()
    {
        Vector3 scl = transform.localScale;
        Vector3 screenCoordsFull = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector3 screenCoordsEmpty = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        scl.x = screenCoordsFull.x - screenCoordsEmpty.x;
        scl.y = screenCoordsFull.y - screenCoordsEmpty.y;
        scl *= 0.1f;
        scl.z = 1;
        transform.localScale = scl;
    }
}

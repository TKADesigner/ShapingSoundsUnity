using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public Transform boundaryBottom;
    public Transform boundaryTop;
    public Transform boundaryLeft;
    public Transform boundaryRight;

    Vector2 resolution;

    private void Start()
    {
        resolution = new Vector2(Screen.width, Screen.height);
        UpdateBoundaryPositions();
    }

    private void Update()
    {
        if (resolution.x != Screen.width || resolution.y != Screen.height)
        {
            UpdateBoundaryPositions();
        }
    }

    private void UpdateBoundaryPositions()
    {
        boundaryBottom.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, 0));
        boundaryBottom.position = new Vector3(boundaryBottom.position.x, boundaryBottom.position.y, 0);
        boundaryBottom.localScale = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 1, 1);
;
        boundaryTop.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height, 0));
        boundaryTop.position = new Vector3(boundaryTop.position.x, boundaryTop.position.y, 0);
        boundaryTop.localScale = new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 1, 1);

        boundaryLeft.position = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, 0));
        boundaryLeft.position = new Vector3(boundaryLeft.position.x, boundaryLeft.position.y, 0);
        boundaryLeft.localScale = new Vector3(1, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2, 1);

        boundaryRight.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, 0));
        boundaryRight.position = new Vector3(boundaryRight.position.x, boundaryRight.position.y, 0);
        boundaryRight.localScale = new Vector3(1, Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2, 1);
    }
}

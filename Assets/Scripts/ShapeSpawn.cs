using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawn : MonoBehaviour
{
    public GameObject shape;
    public GameObject shape1;
    public GameObject shape2;
    public GameObject spawn;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject newShape = Instantiate(shape);
            newShape.transform.position = spawn.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject newShape = Instantiate(shape1);
            newShape.transform.position = spawn.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject newShape = Instantiate(shape2);
            newShape.transform.position = spawn.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }
    }
}

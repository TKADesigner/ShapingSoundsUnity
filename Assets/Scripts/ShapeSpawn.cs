using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShapeSpawn : MonoBehaviour
{
    public GameObject shape;
    public GameObject shape1;
    public GameObject shape2;
    public GameObject spawn;
    public List<GameObject> shapes;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject newShape = Instantiate(shape);
            newShape.transform.position = spawn.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            shapes.Add(newShape);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject newShape = Instantiate(shape1);
            newShape.transform.position = spawn.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            shapes.Add(newShape);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject newShape = Instantiate(shape2);
            newShape.transform.position = spawn.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            shapes.Add(newShape);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            foreach (GameObject shapeobj in shapes)
            {
                Destroy(shapeobj);
            }
        }
    }
}

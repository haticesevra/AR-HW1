using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCubeScript : MonoBehaviour
{
    private GameObject cube;
    private ZeminScript circle;

    // Start is called before the first frame update
    void Start()
    {
        circle = FindObjectOfType<ZeminScript>();
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject go = Instantiate(cube, circle.transform.position, circle.transform.rotation);
        }

    }
}

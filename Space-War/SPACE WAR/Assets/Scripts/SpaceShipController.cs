using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public float playerDepth = 10;
    public float lerpFactor;
    public Camera mainCamera;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * playerDepth);
        transform.position = Vector3.Lerp(transform.position, worldPos, lerpFactor);
    }
}

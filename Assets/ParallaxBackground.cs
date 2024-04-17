using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxMultiplier;
    private GameObject cameraTransform;
    private Vector3 lastCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = GameObject.FindGameObjectWithTag("Player");
        lastCameraPosition = cameraTransform.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.transform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * parallaxMultiplier.x, deltaMovement.y * parallaxMultiplier.y);
        lastCameraPosition = cameraTransform.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plane;
    public Color newColor = Color.blue; // Set the new color here
    public float moveSpeed = 2.5f; 
    private bool movingUp = true;

    void Start()
    {
        // Get the mesh renderer component of the plane
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Set the new color for the material
        meshRenderer.material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        oscillate();
    }

    private void oscillate(){
        // Move the plane's position along the y-axis based on the input
        if(movingUp){
            plane.transform.Translate(Vector3.up  * moveSpeed * Time.deltaTime);
            if(plane.transform.position.y > 3){
                movingUp = false;
            }   
        } else {
            plane.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
             if(plane.transform.position.y <= 0){
                movingUp = true;
            } 
        }
    }
    
}

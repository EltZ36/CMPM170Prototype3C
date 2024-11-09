using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class waveLauncher : MonoBehaviour
{   
    public Vector2[] positions = new Vector2[3];
    public GameObject plane;
    public Color newColor = Color.blue; // Set the new color here
    public float moveSpeed = 22.0f; 
    // Start is called before the first frame update
    void Start()
    {
        positions[0] = new Vector2(-120, -100);
        positions[1] = new Vector2(-120, 0);
        positions[2] = new Vector2(-120, 100);
    }

    // Update is called once per frame
    void Update()
    {
        plane.transform.Translate(new Vector3(0, 1,0)  * moveSpeed * Time.deltaTime);
    }
}

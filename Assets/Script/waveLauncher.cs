using UnityEngine;

public class waveLauncher : MonoBehaviour
{   
    public GameObject plane;
    // public Color newColor = Color.blue; // Set the new color here
    private Vector3[] positions = new Vector3[3];
    [SerializeField] private float moveSpeed = 15.0f; 
    // Start is called before the first frame update
    void Start()
    {
        positions[0] = new Vector3(-120,0, -100);
        positions[1] = new Vector3(-120,0, 0);
        positions[2] = new Vector3(-120,0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        plane.transform.Translate(new Vector3(0, 1,0)  * moveSpeed * Time.deltaTime);
        if(plane.transform.position.y > 100){
            resetWave(positions[Random.Range(0, positions.Length)]); // does this need to be length -1
        }
    }

    void resetWave(Vector3 newPos){
        plane.transform.position = newPos;
    }
}

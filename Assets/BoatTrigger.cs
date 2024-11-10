using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int boatHealth = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Wave"))
        {
            Debug.Log("Boat is hit");
            boatHealth -= 10;
        }
    }
}

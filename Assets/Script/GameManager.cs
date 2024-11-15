using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError(message: "GameManager is null");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public int NumObjects
    {
        get;
        set;
    }
    private void Update()
    {
        if (NumObjects <= 0)
        {
            ResetGame();
        }
    }

    private void ResetGame()
    {
        Debug.Log("All objects cleared! Resetting game...");

        GameObject[] objects = GameObject.FindGameObjectsWithTag("boat");
        foreach (GameObject obj in objects)
        {
            obj.transform.position = GetRandomPosition();
        }

        NumObjects = objects.Length;
    }

    private Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(-10f, 10f), 1f, Random.Range(-10f, 10f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    public GameObject[] gameObjects;
    public int espacioSpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            Instantiate(gameObjects[i], new Vector3(5, 0, i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

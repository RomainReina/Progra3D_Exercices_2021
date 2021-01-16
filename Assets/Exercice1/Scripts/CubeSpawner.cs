using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private int nbCube = 3;
    [SerializeField] private int radius = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= nbCube; i += 1)
        {
            // Je cree l angle pour les differents cubes
            float angle = Mathf.PI * 2 * i / nbCube;
            
            float x = radius * Mathf.Cos(angle);
            float y = radius * Mathf.Sin(angle);
            float z = 0;
            
            // Je cree les cube en questions
            GameObject cube = (GameObject)Instantiate(Resources.Load("Cube"),
                new Vector3(x, y, z),
                Quaternion.Euler(new Vector3(x, y, z)));
            cube.name = "CubeLoaded"; 
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

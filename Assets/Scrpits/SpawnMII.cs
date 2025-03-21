using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMII : MonoBehaviour
{
    public int cantidadClonaciones = 3;
    public int distanciaSeparacion = 2;
    public GameObject objetoAClonar;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objetoAClonar);
        for (int i = 0; i < cantidadClonaciones; i++)
        {
            Instantiate(objetoAClonar, new Vector3(0, 0, 0 + distanciaSeparacion * i), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CibleController : MonoBehaviour
{
    [SerializeField] private Transform spawnPointTransform;
    [SerializeField] private Transform CibleHolderTransform;
    private LayerMask ballLayer;
    public Material cibleMaterial;
    

    private float flag=10;
    private float y = 0f;
    private float z=0f;

    
    // Update is called once per frame
    void Update()
    {
        while (flag != 0)
        {
            Vector3 posGO = spawnPointTransform.position;
            Vector3 newPos = posGO + new Vector3(0f, y, z);

            // Permet de cree des cibles en haut ou en bas alternativement espacées de 6m
            Instantiate(Resources.Load("Cible"),
                newPos,
                Quaternion.identity,
                CibleHolderTransform);

            if (y == 0f)
            {
                y += 1f;
            }
            else
            {
                y -= 1f;
            }

            z += 6;

            flag -= 1;
        }
    }

    

    
}
           


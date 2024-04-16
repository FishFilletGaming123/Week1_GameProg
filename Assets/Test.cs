using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int hp;
    public int str;
    public MeshRenderer pMesh;
    public Color pColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pMesh.material.color = pColor;
        hp = str * 100;
    }
}

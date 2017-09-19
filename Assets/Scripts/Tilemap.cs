using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class Tilemap : MonoBehaviour {


	// Use this for initialization
	void Start ()
    {
        BuildMesh();        
	}

    void BuildMesh()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        //https://www.youtube.com/watch?v=haelMvLyqDQ&list=PLbghT7MmckI4qGA0Wm_TZS8LVrqS47I9R&index=2
    }

}

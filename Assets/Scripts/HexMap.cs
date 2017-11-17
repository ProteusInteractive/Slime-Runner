using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexMap : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GenerateMap();
	}

    public GameObject HexPrefab;

    public Material[] HexMaterials;

    int mapHeight = 60;
    int mapWidth = 20;

    public void GenerateMap()
    {
        for (int column = 0; column < mapHeight; column++)
        {
            for (int row = 0; row < mapWidth; row++)
            {
                Hex h = new Hex(column, row);

                GameObject hexGO = (GameObject)Instantiate
                    (
                    HexPrefab, 
                    h.Position(), 
                    Quaternion.identity, 
                    this.transform
                    );

                MeshRenderer mr = hexGO.GetComponentInChildren<MeshRenderer>();
                mr.material = HexMaterials[Random.Range(0, HexMaterials.Length)];
            }
        }
    }
}

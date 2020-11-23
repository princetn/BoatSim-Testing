using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFilter;
    public int UVscale = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] vertices = meshFilter.mesh.vertices;
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i].y = WaterController.current.GetWaveYPos(transform.position+ new Vector3(vertices[i].x, vertices[i].y, vertices[i].z), Time.time);
            
        }
        Vector2[] uv = meshFilter.mesh.uv;

        int dimension = (int) Mathf.Sqrt(uv.Length);
        for(int i = 0; i<dimension;i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                int I = j + i * dimension;
                uv[I] = new Vector2((i/ UVscale) % 2, (i / UVscale) % 2); 
            }
               
        }

        meshFilter.mesh.vertices = vertices;
        meshFilter.mesh.uv = uv;
        meshFilter.mesh.RecalculateBounds();
        meshFilter.mesh.RecalculateNormals();
    }
    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
    }
}

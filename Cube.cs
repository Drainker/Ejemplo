using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3(0, 0, 0), //vertice0
        new Vector3(1, 0, 0), //vertice1
        new Vector3(1, 1, 0), //vertice2
        new Vector3(0, 1, 0), //vertice3
        new Vector3(0, 1, 1), //vertice4
        new Vector3(1, 1, 1), //vertice5
        new Vector3(1, 0, 1), //vertice6
        new Vector3(0, 0, 1), //vertice7

    };


    int[] triangulos =
        {
        0, 2, 1,
        0, 3, 2,
        2, 3, 4,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        0, 7, 4,
        0, 4, 3,
        5, 4, 7,
        5, 7, 6,
        0, 6, 7,
        0, 1, 6,



     };



    // Start is called before the first frame update
    void Start()
    {

        objToSpawn = new GameObject("Cube");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;  
        objToSpawn.transform.position = Vector3.one;




    }

    // Update is called once per frame
    void Update()
    {

        GameObject tempGameObject = Instantiate(objToSpawn);
        tempGameObject.name = "Cubo";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;




    }

        
     void Awake()
    {
        GameObject tempGameObject = Instantiate(objToSpawn);
        tempGameObject.name = "Cubo";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;



    }


}











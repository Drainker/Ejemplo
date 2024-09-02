using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    GameObject objToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        objToSpawn = new GameObject("Capsule");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
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

        GameObject tempGameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        tempGameObject.name = "Capsule";
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;

    }



}

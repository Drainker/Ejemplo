using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {

        x = 0; 
        print("algo paso");
        Debug.LogError("Algo muy malo paso");
        Debug.LogWarning("algo medianamentemalo paso");
        




        
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log("x");
        Debug.Log("hola desde update");

    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde fixed update cada 50 frames");
        
    }

    private void LateUpdate()
    {
        Debug.Log("hola desde late update");
        
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
        
    }

    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado");

    }

}

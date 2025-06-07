using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    public int X =5;
    public int Y =3 ;
    public int Z = 5;
   
    public void Update()
    {
        transform.Rotate(Vector3.right, X*Time.deltaTime); 
        transform.Rotate(Vector3.up, Y * Time.deltaTime);
        transform.Rotate(Vector3.down, Z * Time.deltaTime);
    }
}


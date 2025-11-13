using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Street_Generator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh figura = new Mesh();
        GetComponent<MeshFilter>().mesh = figura;

        Vector3[] vertices = new Vector3[43];

        vertices[0] = new Vector3(-25.9f, 0, -10.4f);
        vertices[1] = new Vector3(-25.9f, 0, -8.7f);
        vertices[2] = new Vector3(-25.9f, 0, -8.3f);
        vertices[3] = new Vector3(-25.9f, 0, -6.8f);
        vertices[4] = new Vector3(-25.9f, 0, 7.4f);
        vertices[5] = new Vector3(-25.9f, 0, 8.9f);
        vertices[6] = new Vector3(-25.9f, 0, 9.5f);
        vertices[7] = new Vector3(-25.9f, 0, 11.2f);
        vertices[8] = new Vector3(-22.5f, 0, -4f);
        vertices[9] = new Vector3(-21.7f, 0, -4.9f);
        vertices[10] = new Vector3(-18.7f, 0, 0.2f);
        vertices[11] = new Vector3(-17.9f, 0, -0.8f);
        vertices[12] = new Vector3(-16.9f, 0, -0.9f);
        vertices[13] = new Vector3(-16f, 0, -1.9f);
        vertices[14] = new Vector3(-15.1f, 0, -2f);
        vertices[15] = new Vector3(-4.4f, 0, -12.7f);
        vertices[16] = new Vector3(-3.1f, 0, -12.7f);
        vertices[17] = new Vector3(-14.6f, 0, -1.25f);
        vertices[18] = new Vector3(-18f, 0, 1f);
        vertices[19] = new Vector3(-17.8f, 0, 1.2f);
        vertices[20] = new Vector3(-16.5f, 0, 1.6f);
        vertices[21] = new Vector3(-15.5f, 0, 1.4f);
        vertices[22] = new Vector3(-15.5f, 0, 0.1f);
        vertices[23] = new Vector3(-14.1f, 0, 1.8f);
        vertices[24] = new Vector3(-14f, 0, 0.5f);
        vertices[25] = new Vector3(-14f, 0, 0f);
        vertices[26] = new Vector3(16.8f, 0, 4.4f);
        vertices[27] = new Vector3(16.2f, 0, 5.6f);
        vertices[28] = new Vector3(9.4f, 0, 12.7f);
        vertices[29] = new Vector3(10.7f, 0, 12.7f);
        vertices[30] = new Vector3(17.1f, 0, 6.2f);
        vertices[31] = new Vector3(17.5f, 0, 6.2f);
        vertices[32] = new Vector3(18.6f, 0, 7.9f);
        vertices[33] = new Vector3(23.1f, 0, 12.7f);
        vertices[34] = new Vector3(24.4f, 0, 12.7f);
        vertices[35] = new Vector3(19.5f, 0, 7.5f);
        vertices[36] = new Vector3(18.6f, 0, 5.95f);
        vertices[37] = new Vector3(18.6f, 0, 4.6f);
        vertices[38] = new Vector3(25.9f, 0, 6.9f);
        vertices[39] = new Vector3(25.9f, 0, 5.7f);
        vertices[40] = new Vector3(25.9f, 0, 5.45f);
        vertices[41] = new Vector3(25.9f, 0, 4.35f);
        vertices[42] = new Vector3(18f, 0, 3.35f);

        figura.vertices = vertices;
        figura.triangles = new int[] {0, 1, 12, 0, 12, 13, 2, 3, 8, 2, 8, 9, 8, 10, 9, 9, 10, 11, 4, 5, 18, 4, 18, 10, 6, 7, 20, 6, 20, 19, 14, 17, 16,
                                      14, 16, 15, 22, 25, 17, 25, 26, 17, 17, 26, 42, 26, 37, 42, 37, 40, 42, 42, 40, 41, 20, 21, 22, 21, 23, 22, 22, 
                                      23, 24, 23, 27, 24, 24, 27, 26, 27, 36, 26, 26, 36, 37, 36, 38, 37, 37, 38, 39, 27, 30, 31, 27, 31, 36, 28, 29, 27,
                                      29, 30, 27, 31, 32, 36, 32, 35, 36, 32, 33, 35, 35, 33, 34, 10, 12, 11, 10, 18, 12, 18, 19, 12, 19, 20, 12, 12, 20,
                                      22, 12, 22, 17, 12, 17, 13, 13, 17, 14};
        GetComponent<MeshRenderer>().material.color = new Color(0.2f, 0.2f, 0.2f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

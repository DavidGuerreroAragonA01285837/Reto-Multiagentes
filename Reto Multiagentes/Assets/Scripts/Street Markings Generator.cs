using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class StreetMarkingsGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Mesh figura = new Mesh();
        GetComponent<MeshFilter>().mesh = figura;

        Vector3[] vertices = new Vector3[3050];

        vertices[0] = new Vector3(-14.91923f, 0, -1.78f);
        vertices[1] = new Vector3(-14.89917f, 0, -1.76f);
        vertices[2] = new Vector3(-14.7f, 0, -1.565f);
        vertices[3] = new Vector3(-14.68346f, 0, -1.545f);
        vertices[4] = new Vector3(-14.8189f, 0, -1.88f);
        vertices[5] = new Vector3(-14.79884f, 0, -1.86f);
        vertices[6] = new Vector3(-14.60319f, 0, -1.665f);
        vertices[7] = new Vector3(-14.58312f, 0, -1.645f);

        for (int i = 8; i < 464; i++)
        {
            vertices[i] = vertices[i - 4];
            vertices[i].x += 0.10033f;
            vertices[i].z -= 0.1f;
        }

        vertices[464] = new Vector3(-25.91923f, 0, 10.35f);
        vertices[465] = new Vector3(-25.89917f, 0, 10.37f);

        for (int i = 466; i < 634; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.10033f;
            vertices[i].z -= 0.1025f;
        }

        vertices[634] = new Vector3(-25.91923f, 0, 8.13f);
        vertices[635] = new Vector3(-25.89917f, 0, 8.15f);

        for (int i = 636; i < 782; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.10033f;
            vertices[i].z -= 0.10001f;
        }

        vertices[782] = new Vector3(-25.84859f, 0, -9.78488f);
        vertices[783] = new Vector3(-25.83003f, 0, -9.80630f);

        for (int i = 784; i < 962; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.092f;
        }

        vertices[962] = new Vector3(-25.84859f, 0, -9.25488f);
        vertices[963] = new Vector3(-25.83003f, 0, -9.27630f);

        for (int i = 964; i < 1138; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.092f;
        }

        vertices[1138] = new Vector3(-25.84859f, 0, -7.45488f);
        vertices[1139] = new Vector3(-25.83003f, 0, -7.47630f);

        for (int i = 1140; i < 1210; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.087f;
        }

        for (int i = 1210; i < 1278; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.117f;
        }

        vertices[1279] = new Vector3(-15.64859f, 0, 0.75488f);
        vertices[1278] = new Vector3(-15.63003f, 0, 0.78630f);

        for (int i = 1280; i < 1310; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.027f;
        }

        for (int i = 1310; i < 1998; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.01348f;
        }

        vertices[1998] = new Vector3(-14.64859f, 0, -0.65488f);
        vertices[1999] = new Vector3(-14.63003f, 0, -0.68630f);

        for (int i = 2000; i < 2798; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.015f;
        }

        vertices[2798] = new Vector3(10.01923f, 0, 12.75f);
        vertices[2799] = new Vector3(9.96917f, 0, 12.77f);

        for (int i = 2800; i < 2930; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.10033f;
            vertices[i].z -= 0.1025f;
        }

        vertices[2931] = new Vector3(18.14859f, 0, 6.15488f);
        vertices[2930] = new Vector3(18.13003f, 0, 6.17630f);

        for (int i = 2932; i < 2952; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.173f;
        }

        for (int i = 2952; i < 3050; i++)
        {
            vertices[i] = vertices[i - 2];
            vertices[i].x += 0.107f;
            vertices[i].z += 0.114f;
        }

        /*figura.vertices = vertices;
        figura.triangles = new int[] {0, 1, 4, 1, 5, 4, 2, 3, 6, 3, 7, 6};
        */

        figura.vertices = vertices;

        int[] triangle = new int[4548];

        
        triangle[0] = 0;
        triangle[1] = 1;
        triangle[2] = 4;
        triangle[3] = 1;
        triangle[4] = 5;
        triangle[5] = 4;
        triangle[6] = 2;
        triangle[7] = 3;
        triangle[8] = 6;
        triangle[9] = 3;
        triangle[10] = 7;
        triangle[11] = 6;

        for (int i = 12; i < 672; i++)
        {
            triangle[i] = triangle[i - 12] + 8;
        }

        triangle[672] = 464;
        triangle[673] = 465;
        triangle[674] = 466;
        triangle[675] = 466;
        triangle[676] = 465;
        triangle[677] = 467;

        for (int i = 678; i < 1146; i++)
        {
            triangle[i] = triangle[i - 6] + 4;
        }

        triangle[1146] = 783;
        triangle[1147] = 782;
        triangle[1148] = 784;
        triangle[1149] = 783;
        triangle[1150] = 784;
        triangle[1151] = 785;

        for (int i = 1152; i < 4548; i++)
        {
            triangle[i] = triangle[i - 6] + 4;
        }

        

        figura.triangles = triangle;

        

        GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1, 1);
        figura.RecalculateNormals();
        figura.RecalculateBounds();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

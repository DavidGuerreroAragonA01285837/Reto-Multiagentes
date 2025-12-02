using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Movement : MonoBehaviour
{
    public List<List<float>> path { get; set; }
    public List<int> positions { get; set; }
    int animationPosition;

    // Start is called before the first frame update
    void Start()
    {
        animationPosition = 1;
        transform.position = new Vector3(path[0][positions[animationPosition]], 0, path[1][positions[animationPosition]]);
        StartCoroutine(UpdateEverySecond());
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

    }

    IEnumerator UpdateEverySecond()
    {
        while (true)
        {
            animationPosition += 1;

            if (animationPosition < positions.Count){
                transform.position = new Vector3(path[0][positions[animationPosition]], 0, path[1][positions[animationPosition]]);
                Vector3 dir = new Vector3(path[0][positions[animationPosition] - 1], 0, path[1][positions[animationPosition] - 1]) - transform.position;
                float angle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, -angle + 90f, 0);

            }
            else
            {
                Destroy(gameObject);
            }
            
            yield return new WaitForSeconds(0.1f);
        }
    }
}

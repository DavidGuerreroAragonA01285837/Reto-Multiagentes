using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;


public class CarroReporte
{
    public List<List<float>> path {  get; set; }
    public List<int> positions { get; set; }
    public int start {  get; set; }
    public int end { get; set; }
}

public class SemaforoReporte
{
    public int carros_servidos { get; set; }
    public List<string> statuses { get; set; }
}

public class ReporteUnity
{
    public List<CarroReporte> carros { get; set; }
    public List<SemaforoReporte> semaforos { get; set; }
}

public class Simulator_Manager : MonoBehaviour
{
    List<GameObject> carros = new List<GameObject>();

    public List<GameObject> semaforos;

    bool finished = false;

    string jsonPath;

    string json;

    public List<GameObject> gameObjects;

    ReporteUnity data;

    int step = 0;

    int carIndex;
    // Start is called before the first frame update
    public void Initiate()
    {
        jsonPath = Application.dataPath + "/output.json";

        json = File.ReadAllText(jsonPath);

        data = JsonConvert.DeserializeObject<ReporteUnity>(json);

        Debug.Log(data.carros.Count);

        carIndex = 0;

        data.carros.Sort((a, b) => a.start.CompareTo(b.start));

        StartCoroutine(UpdateEverySecond());
    }

    // Update is called once per frame
    IEnumerator UpdateEverySecond()
    {
        while (true)
        {

            if (carIndex < data.carros.Count)
            {
                if (data.carros[carIndex].start  == step && !finished)
                {
                    if (data.carros[carIndex].positions.Count > 5)
                    {
                        int selection = UnityEngine.Random.Range(0, gameObjects.Count);
                        GameObject newCar = Instantiate(gameObjects[selection]);
                        newCar.GetComponent<Car_Movement>().path = data.carros[carIndex].path;
                        newCar.GetComponent<Car_Movement>().positions = data.carros[carIndex].positions;
                        carros.Add(newCar);
                    }
                    carIndex ++;
                }

                if (carIndex == data.carros.Count)
                {
                    finished = true;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (data.semaforos[i].statuses[step] == "green")
                {
                    semaforos[i].GetComponent<MeshRenderer>().material.color = Color.green;
                }
                else if (data.semaforos[i].statuses[step] == "yellow")
                {
                    semaforos[i].GetComponent<MeshRenderer>().material.color = Color.yellow;
                }
                else
                {
                    semaforos[i].GetComponent<MeshRenderer>().material.color = Color.red;
                }

            }

            step++;

            if (step == 150)
            {
                for (int i = 0; i < carros.Count; i++)
                {
                    if (carros[i] != null)
                    {
                        Destroy(carros[i]);
                    }
                }
                carros.Clear();
                carIndex = 0;
                step = 0;
                finished = false;
            }

            Debug.Log(step);
            yield return new WaitForSeconds(0.1f);

        }
    }
}

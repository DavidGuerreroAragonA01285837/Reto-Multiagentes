using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GitHub_Downloader : MonoBehaviour
{
    public string url = "https://raw.githubusercontent.com/YOUR_USERNAME/YOUR_REPO/main/output.json";

    public GameObject simulation;

    IEnumerator Start()
    {
        UnityWebRequest www = UnityWebRequest.Get(url);

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.Success)
        {
            string json = www.downloadHandler.text;
            Debug.Log("Downloaded: " + json);

            // Example: save locally
            System.IO.File.WriteAllText(Application.dataPath + "/output.json", json);

            simulation.GetComponent<Simulator_Manager>().Initiate();

            // TODO: parse JSON, spawn objects, update UI, etc.
        }
        else
        {
            Debug.LogError("Download failed: " + www.error);
        }
    }
}

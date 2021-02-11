using System;
using UnityEngine;
using System.IO;


public class GameManagerScript : MonoBehaviour
{
    public string filepath = "textfile.txt";
    // Start is called before the first frame update
    void Start()
    {
        CreateFile();
        WriteFile();
    }
   
    // Question 1: Text File Generation and Writing

    private void CreateFile()
    {
        //using a relative path "textfile.txt"

        if (!File.Exists(filepath))
        {
            File.Create(filepath).Close();
        }
    }

    private void WriteFile()
    {
        using (StreamWriter write = new StreamWriter(filepath))
        {
            write.WriteLine("Hello World");
        }
    }


    // Question 2: Startup/ShutDown messages with timestamps

    void Awake()
    {
        Debug.Log("Start Application TimeStamp: " + DateTime.Now);
    }

    void OnApplicationQuit()
    {
        Debug.Log("Quit Application Timestamp: " + DateTime.Now);
    }



    // Question 3: User Input Tracking (Spacebar)

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar Pressed TimeStamp: " + DateTime.Now);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Spacebar Released TimeStamp: " + DateTime.Now);
        }
    }

}

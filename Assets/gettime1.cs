using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class gettime1 : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    string data;
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse input
        time += Time.deltaTime;


    }

    private void OnMouseDown()
    {
        Debug.Log("clicked " + time + Application.persistentDataPath);
        data = "Time for experiment 3D: " + time.ToString();
        WriteString();
        NextScene();

    }
    public void WriteString()
    {
        string path = Application.persistentDataPath + "/test.txt";
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(data);
        writer.Close();
        StreamReader reader = new StreamReader(path);
        //Print the text from the file
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
    public static void ReadString()
    {
        string path = Application.persistentDataPath + "/test.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
    public void NextScene()
    {
        SceneManager.LoadScene("Final");
    }
}
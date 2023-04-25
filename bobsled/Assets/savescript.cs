using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class savescript : MonoBehaviour
{
    private string dataDirPath = "SavedData";
    private string dataFileName;

    /*public savescript(string dataDirPath, string dataFileName)
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }*/

    public void Save( double times, string position)//, int wipeouts, int runs)
    {

        dataFileName = position;
        string fullpath = Path.Combine(dataDirPath, dataFileName);
        
        try
        {
            
            Directory.CreateDirectory(Path.GetDirectoryName(fullpath));

            string dataToStore = JsonUtility.ToJson(times, true);

            using (FileStream stream = new FileStream(fullpath, FileMode.Create)) 
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(times);
                    Debug.Log("wrote" + times + dataToStore);
                }
            }
        }
        catch(Exception e)
        {
            
            Debug.LogError("Error occured when trying to save data to file" + fullpath + "\n" + e);
        }
        
    }

    public double Load(string position)
    {
        dataFileName = position;
        string fullpath = Path.Combine(dataDirPath, dataFileName);
        double loadedData = 0;
        if(File.Exists(fullpath))
        {
            try
            {
                string dataToLoad = "";
                using (FileStream stream = new FileStream(fullpath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }
                Debug.Log("wrote" + dataToLoad);

                loadedData = float.Parse(dataToLoad);// JsonUtility.FromJson<double>(dataToLoad);
            }
            catch(Exception e)
            {
                Debug.LogError("error loading" + e);
            }
        }
        return loadedData;
    }
}

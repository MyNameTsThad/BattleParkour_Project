using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class SaveAndLoadManager : MonoBehaviour
{
    private CoinCount _cc;

    private void Awake()
    {
        _cc = GameObject.FindObjectOfType<CoinCount>();
        Load();

    }
    private void Update()
    {
        Save();
    }
    public void Save()
    {

        FileStream stream = new FileStream(Application.persistentDataPath + "/player.bpgs", FileMode.OpenOrCreate);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
        }

        catch (SerializationException e)
        {
            Debug.LogError("An Issue occored Exeption : " + e.Message);
        }
        finally
        {
            stream.Close();
        }

    }
    public void Load()
    {
        FileStream stream = new FileStream(Application.persistentDataPath + "/player.bpgs", FileMode.Open);
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            
        }
        catch(SerializationException e)
        {
            Debug.LogError("An Issue occored Exeption : " + e.Message);
        }
        finally
        {
            stream.Close();
        }
       

        

    }
}

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SavingSystem
{
    public static void SaveSystem(CoinCount coinCount)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/savegame.bpgs";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(coinCount);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadSystem()
    {
        string path = Application.persistentDataPath + "/savegame.bpgs";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("404 File Not Found in " + path);
            return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;


[System.Serializable]
public class Data
{

    public Dictionary<string, string> livretexte = new Dictionary<string, string>();

    void Clear()
    {
        livretexte.Clear();
    }

}
public class TextManager 
{
    private static string path = Path.Combine(Application.dataPath, "data.dat");
    private static Data data = new Data();
    private static bool loaded = false;



    public static void Load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file;

        try
        {
            file = File.Open(path, FileMode.Open);
        }
        catch (FileNotFoundException)
        {
            return;
        }
        try
        {
            data = bf.Deserialize(file) as Data;
            loaded = true;
        }
        finally
        {
            file.Close();
        }

    }


    public static void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file;

        file = File.Open(path, FileMode.Create);

        try
        {
            bf.Serialize(file, data);
        }
        finally
        {
            file.Close();
        }
    }

    // Appel des sauvegardes

    public static void SetBook(string name, TMP_Text texte)
    {
        data.livretexte[name] = texte.text;
        Save();
        Debug.Log("Sauvegardé");
    }

    public static string GetBook (string name)
    {
        if (!loaded)
        {
            Load();
        }

        string livre = string.Empty;
        if (data.livretexte.ContainsKey(name))
        {
            livre = data.livretexte[name];
        }
        return livre;
    }
}
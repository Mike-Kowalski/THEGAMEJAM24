using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

using System.Linq;
using JetBrains.Annotations;

public static class file_handler
{
    public static void saveToJson<T>(T tosave, string fileName)
    {
        Debug.Log(getPath(fileName));
        string content = JsonUtility.ToJson(tosave);

        writeFile(getPath(fileName), content);
    }

    public static T readFromJson<T>(string fileName)
    {
        string content = readFile(getPath(fileName));
        if (string.IsNullOrEmpty(content) || content == "{ }")
        {
            return default(T);
        }
        T res = JsonUtility.FromJson<T>(content);
        return res;
    }
       
        static string getPath(string fileName)
        {
            return Application.persistentDataPath + "/" + fileName;
        }
        private static void writeFile(string path, string content)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);

            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.Write(content);
            }
        }

    private static string readFile(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                return content;
            }
        }
        return "";
    }
           
    public static class JsonHelper
    {
        public static T[] FromJson<T>(string json)
        {
            Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
            return wrapper.Items;
        }

        public static string ToJson<T>(T[] array)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.Items = array;
            return JsonUtility.ToJson(wrapper);
        }

        public static string ToJson<T>(T[] array, bool prettyPrint)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.Items = array;
            return JsonUtility.ToJson(wrapper, prettyPrint);
        }

        [Serializable]
        private class Wrapper<T>
        {
            public T[] Items;
        }
    }
}



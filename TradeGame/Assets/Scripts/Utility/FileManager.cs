﻿using System;
using System.IO;
using UnityEngine;

public static class FileManager
{
    public static bool WriteToFile(string a_FileName, string a_FileContents)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, a_FileName);

        try
        {
            File.WriteAllText(fullPath, a_FileContents);
            return true;
        }
        catch (Exception e)
        {
            Debug.LogError($"Failed to write to {fullPath} with exception {e}");
            return false;
        }
    }

    public static bool LoadFromFile(string a_FileName, out string result)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, a_FileName);

        try
        {
            if (File.Exists(fullPath))
            {
                result = File.ReadAllText(fullPath);
                return true;
            }
            
            result = string.Empty;
            return false;

        }
        catch (Exception e)
        {
            Debug.LogWarning($"Failed to read from {fullPath} with exception {e}");
            result = "";
            return false;
        }
    }
    
    public static void DeleteFile(string a_FileName)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, a_FileName);
        if (File.Exists(fullPath)) File.Delete(fullPath);
    }
}
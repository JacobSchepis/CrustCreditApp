using CrustCreditApp;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;

public static class CreditStore
{
    private static string filePath = "credits.json";

    public static List<CreditEntry> CreditEntries = new List<CreditEntry>();

    public static void LoadCredits()
    {
        if (!File.Exists(filePath))
            CreditEntries = new List<CreditEntry>();

        try
        {
            string json = File.ReadAllText(filePath);
            CreditEntries = JsonConvert.DeserializeObject<List<CreditEntry>>(json) ?? new List<CreditEntry>();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading credits: " + ex.Message);
            CreditEntries = new List<CreditEntry>();
        }
    }

    public static void SaveCredits()
    {
        try
        {
            string json = JsonConvert.SerializeObject(CreditEntries, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error saving credits: " + ex.Message);
        }
    }

    public static void SetSavePath(string path)
    {
        filePath = path;
    }
}

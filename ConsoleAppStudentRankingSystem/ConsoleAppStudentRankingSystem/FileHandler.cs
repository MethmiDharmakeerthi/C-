using System;
using System.Security.Cryptography.X509Certificates;

public class FileHandler

{ 
    private static string txtFile = @"D:\hey\C#\ConsoleAppStudentRankingSystem\ConsoleAppStudentRankingSystem\Log.txt";
         
    public static string StudentName { get; private set; }
    public static int RankofStudent { get; private set; }

    public static void LogFile(string action, string message, string eventType = "Normal")
    {
        // String txtFile = @"D:\hey\C#\ConsoleAppStudentRankingSystem\ConsoleAppStudentRankingSystem\Log.txt";

        string filePath = "Output.CSV";
        try
        {
            using (System.IO.StreamWriter csvfile = new System.IO.StreamWriter(filePath, true))
            {
                csvfile.Write(StudentName, RankofStudent);
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Cannot write to csv file");
        }
    }
    public static void writeLog(int typeofMsg, string message, string Class, string Method)
    {
        string msgDetails;
        switch (typeofMsg)
        {
            //default:
                //msgDetails = "[Info]";
            case 1:
                msgDetails = "[Warn]";
                break;
           case 2:
                msgDetails = "[Error]";
                break;
            

        }
        try
        {
            using (System.IO.StreamWriter LogFile = new System.IO.StreamWriter(txtFile, true))
            {
                LogFile.WriteLine(DateTime.Now + " | " + Class + " | " + Method + " | " + message);

            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException("Cannot write to Log file", ex);
        }
    }

 

    /*

    StreamWriter log;
    if (!File.Exists(txtFile))
    {
        log = new StreamWriter(txtFile);
    }
    else
    {
        log = File.AppendText(txtFile);
    }
    log.WriteLine(DateTime.Now);
    if (eventType == "error")
    {
        log.WriteLine("Error type: " + action);
        log.WriteLine("Message: " + message);
    }
    else
    {
        log.WriteLine("Action: " + action);
        log.WriteLine("Message: " + message);
    }
    log.Close
    */
}



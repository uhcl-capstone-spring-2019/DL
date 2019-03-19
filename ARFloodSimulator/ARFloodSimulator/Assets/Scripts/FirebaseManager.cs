using UnityEngine;
using Firebase.Database;
using System;
using System.Collections;
using UnityEngine.Networking;

public static class FirebaseManager
{
    //private static readonly string _databaseURL = "";
    public static DatabaseReference dataRef;

    static FirebaseManager()
    {
        InitialiseFirebase();
    }

    private static void InitialiseFirebase()
    {
        try
        {
            if (dataRef == null)
            {
                try
                {
                    dataRef = FirebaseDatabase.DefaultInstance.RootReference;
                    Debug.Log("Firebase database initialization completed.");
                }
                catch (Exception)
                {
                    Debug.LogError("Unable to connect to firebase. Check internet connection.");
                }
            }
        }
        catch (Exception ex)
        {
            if (ex.Message != null)
            {
                Debug.LogError(ex.Message);
            }

            if (ex.InnerException != null && ex.InnerException.Message != null)
            {
                Debug.LogError(ex.InnerException.Message);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntreEscenas : MonoBehaviour
{
    private void Awake()
    {
        var noDestruirEntreEscenas = FindObjectsOfType<EntreEscenas>();
        if (noDestruirEntreEscenas.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public void CambiarEscena(int escenaObejtivo)
    {
        SceneManager.LoadScene(escenaObejtivo);
    }
}

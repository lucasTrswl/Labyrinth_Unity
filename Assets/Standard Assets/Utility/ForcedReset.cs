using System;
using UnityEngine;
using UnityEngine.UI; // Ajouter cette ligne pour utiliser UI.Image
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof (Image))] // Utiliser Image au lieu de GUITexture
public class ForcedReset : MonoBehaviour
{
private void Update()
{
// si on a forcé une réinitialisation ...
if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
{
//... recharger la scène
UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
}
}
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cryptogramme : MonoBehaviour
{
    // La réponse correcte au cryptogramme.
    public string reponse = "Labyrinthe";

    // Le texte affiché dans la boîte de dialogue.
    public string texteDialogue = "Déchiffrez le message : ntiivbrl aheint!";

    // La boîte de dialogue UI.
    public Text boiteDialogue;

    // La boîte de saisie UI.
    public InputField boiteSaisie;

    // Le panneau UI qui contient la boîte de dialogue et la boîte de saisie.
    public GameObject panneau;

    // Indique si le joueur a résolu l'énigme.
    private bool resolu = false;

    void Start()
    {
        // Masque le panneau au début.
        panneau.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        // Si le joueur entre dans la zone de l'énigme, affiche le panneau de dialogue.
        if (other.CompareTag("Player") && !resolu)
        {
            panneau.SetActive(true);
            boiteDialogue.text = texteDialogue;
        }
    }

    public void ValiderReponse()
    {
        // Vérifie si la réponse saisie par le joueur est correcte.
        if (boiteSaisie.text.ToLower() == reponse.ToLower())
        {
            // Si la réponse est correcte, masque le panneau et indique que l'énigme est résolue.
            panneau.SetActive(false);
            resolu = true;
        }
        else
        {
            // Si la réponse est incorrecte, efface la boîte de saisie et affiche un message d'erreur.
            boiteSaisie.text = "";
            boiteDialogue.text = "Ce n'est pas la bonne réponse. Essayez encore.";
        }
    }
}

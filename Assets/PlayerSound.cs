using UnityEngine;
public class PlayerSound : MonoBehaviour {
   public AudioSource sound;
   public Collider triggerCollider;

   void Start() {
       // Assurez-vous que le collider est défini pour être un trigger (et non une collision)
       triggerCollider.isTrigger = true;
   }

   void OnTriggerEnter(Collider other) {
       if (other.tag == "Enemy") {
           sound.Play();
       }
   }
}

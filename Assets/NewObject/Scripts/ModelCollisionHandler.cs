using UnityEngine;

public class ModelCollisionHandler : MonoBehaviour
{
    public GameObject obj;
    public ParticleSystem particleSystems;
    public Material materials;
    public AudioClip collisionSound;
    private void OnParticleCollision(GameObject other)
    {
        Renderer renderers = obj.GetComponent<Renderer>();

        if (renderers != null)
        {
            renderers.material = materials;
        }

        AudioSource audioSource = obj.GetComponent<AudioSource>();

        if (audioSource != null && collisionSound != null)
        {
            audioSource.clip = collisionSound;
            audioSource.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        //if (collision.gameObject.CompareTag("water"))
        //{
        //Debug.Log("Ok");
        //Renderer renderers = obj.GetComponent<Renderer>();
        //if (renderers != null)
        //{
        //    renderers.material = materials;
        //}
        //AudioSource audioSource = obj.GetComponent<AudioSource>();

        //if (audioSource != null && collisionSound != null)
        //{
        //    audioSource.clip = collisionSound;
        //    audioSource.Play();
        //} 
        //}

        //}
    }
}

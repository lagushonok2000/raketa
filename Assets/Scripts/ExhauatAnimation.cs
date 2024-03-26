using UnityEngine;

public class ExhauatAnimation : MonoBehaviour
{
    [SerializeField] private ParticleSystem _flames;

    public void Flames()
    {
       _flames.Play();
    }
}

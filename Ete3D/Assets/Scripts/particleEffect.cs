using UnityEngine;

/// <summary>
/// Effets de particules sans efforts
/// </summary>
public class particleEffect : MonoBehaviour
{
    public static particleEffect Instance;

    public ParticleSystem[] particleSystems;


    void Awake()
    {
        // On garde une référence du singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SpecialEffectsHelper!");
        }

        Instance = this;
    }
    
    public void onHitEffect(Vector3 position)
    {
        instantiate(particleSystems[0], position);
    }

    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(
          prefab,
          position,
          Quaternion.identity
        ) as ParticleSystem;
        newParticleSystem.gameObject.layer = 4;
        // Destruction programmée
        Destroy(
          newParticleSystem.gameObject,
          newParticleSystem.startLifetime
        );

        return newParticleSystem;
    }
}

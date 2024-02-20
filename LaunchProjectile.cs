using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Apply forward force to instantiated prefab
/// </summary>
public class LaunchProjectile : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The projectile that's created")]
    private GameObject projectilePrefab = null;

    [SerializeField]
    [Tooltip("The point that the project is created")]
    private Transform startPoint = null;

    private void Fire()
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shieldPrefab;
    public int numberOfShields = 3;
    public float orbitRadius = 1f;
    public float orbitSpeed = 50f;
    private List<GameObject> shields = new List<GameObject>();
    public bool IsOnEnemy;

    public void SpawnShields()
    {
        for (int i = 0; i < numberOfShields; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfShields;
            Vector3 shieldPosition = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * orbitRadius;
            GameObject shield = Instantiate(shieldPrefab, transform.position + shieldPosition, Quaternion.identity);
            shield.transform.parent = transform;
            shields.Add(shield);
        }

        StartCoroutine(RotateShields());
    }

    IEnumerator RotateShields()
    {
        while (true)
        {
            for (int i = 0; i < shields.Count; i++)
            {
                if (shields[i] != null)
                {
                    shields[i].transform.RotateAround(transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
                    shields[i].transform.rotation = Quaternion.identity;
                }
            }
            yield return null;
        }
    }

    public void Upgrade(){
        numberOfShields++;
    }

    void DeleteShields(){
        for (int i = 0; i < numberOfShields; i++)
        {
            Destroy(shields[i]);
        }
    }
}

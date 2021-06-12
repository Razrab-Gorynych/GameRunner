using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationTracks : MonoBehaviour
{
    public GameObject[] TrackPrefabs;
    private float spownTrack = 0;
    private List<GameObject> activeTracks = new List<GameObject>();
    private float lengthTrack = 100;
    [SerializeField] private Transform player;
    private int startTracks = 6;

    void Start()
    {
        for (int i = 0; i < startTracks; i++)
        {
            SpownTrack(Random.Range(0, TrackPrefabs.Length));
        }
    } 

    
    void Update()
    {
        if (player.position.x - 70 > spownTrack - (startTracks * lengthTrack))
        {
            SpownTrack(Random.Range(0, TrackPrefabs.Length));
            DeleteTrack();
        }           
    }

    void SpownTrack(int trackIndex)
    {
        GameObject nextTrack = Instantiate(TrackPrefabs[trackIndex], transform.forward * spownTrack, transform.transform.rotation = Quaternion.Euler(0, 90, 0));
        activeTracks.Add(nextTrack);
        spownTrack += lengthTrack;
    }

    void DeleteTrack()
    {
        Destroy(activeTracks[0]);
        activeTracks.RemoveAt(0);
    }
}

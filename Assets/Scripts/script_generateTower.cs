using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_generateTower : MonoBehaviour {

    public List<GameObject> startingRooms;
    public List<GameObject> endingRooms;
    public List<GameObject> rooms;

    public int roomNumber;
    public int roomAltitude;
    public int roomOffset;

	// Use this for initialization
	void Start () {

        var chooseSpawn = (int)Random.Range(0, startingRooms.Count);
        var newSpawn = Instantiate<GameObject>(startingRooms[chooseSpawn]);
        newSpawn.transform.position = Vector3.zero;

        for(var i = 0; i < roomNumber; i += 1)
        {

            var nextRoom = (int)Random.Range(0, rooms.Count);
            var newRoom = Instantiate<GameObject>(rooms[nextRoom]);
            roomAltitude += roomOffset;
            newRoom.transform.position = new Vector3(0, roomAltitude, 0);

        }

        var chooseEnd = (int)Random.Range(0, endingRooms.Count);
        var newEnd = Instantiate<GameObject>(endingRooms[chooseEnd]);

        roomAltitude += roomOffset;
        newEnd.transform.position = new Vector3(0, roomAltitude, 0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

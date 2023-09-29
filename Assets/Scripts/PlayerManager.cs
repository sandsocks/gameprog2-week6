using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    public GameObject player;
    public PlayerLocomotion playerLocomotive;
    public InputManager inputManager;
    public Rigidbody rigidBody;

    //Player Stats
    public float moveSpeed;
    public float rotSpeed;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponent<InputManager>();
        playerLocomotive = player.GetComponent<PlayerLocomotion>();
        rigidBody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        playerLocomotive.HandlesAllMovement();
    }
}


using UnityEngine;

[RequireComponent(typeof(Moviment))]
public class Pacman : MonoBehaviour
{
    public Moviment moviment { get;private set; }

    private void Awake()
    {
        this.moviment = GetComponent<Moviment>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetAxis("Vertical")>0 || Input.GetAxisRaw("Vertical") > 0)
        {
            this.moviment.SetDirection(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetAxis("Vertical") < 0 || Input.GetAxisRaw("Vertical") < 0)
        {
            this.moviment.SetDirection(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetAxis("Horizontal") < 0 || Input.GetAxisRaw("Horizontal") < 0)
        {
            this.moviment.SetDirection(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetAxis("Horizontal") > 0 || Input.GetAxisRaw("Horizontal") > 0)
        {
            this.moviment.SetDirection(Vector2.right);
        }
        


        float angle = Mathf.Atan2(this.moviment.direction.y, this.moviment.direction.x);
        this.transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }
}

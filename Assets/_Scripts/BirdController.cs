using UnityEngine;

public class BirdController : MonoBehaviour
{
  public float speed = 0.5f;
  private Vector2 initPosition;
  void Start()
  {
    // scene loaded, this grabs the inital position of the bird; storing it in position variable
    initPosition = gameObject.transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.RightArrow))
    {
      // create a new vector where we modify the x pos of game obj
      Vector2 pos = new Vector2(
        gameObject.transform.position.x + speed,
        gameObject.transform.position.y);

      // assign new pos vector to game obj
      gameObject.transform.position = pos;

    }

    else if (Input.GetKey(KeyCode.LeftArrow))
    {
      // create a new vector where we modify the x pos of game obj
      Vector2 pos = new Vector2(
        gameObject.transform.position.x - speed,
        gameObject.transform.position.y);

      // assign new pos vector to game obj
      gameObject.transform.position = pos;

    }

    else if (Input.GetKey(KeyCode.UpArrow))
    {
      // create a new vector where we modify the x pos of game obj
      Vector2 pos = new Vector2(
        gameObject.transform.position.x,
        gameObject.transform.position.y + speed);

      // assign new pos vector to game obj
      gameObject.transform.position = pos;

    }

    else if (Input.GetKey(KeyCode.DownArrow))
    {
      // create a new vector where we modify the x pos of game obj
      Vector2 pos = new Vector2(
        gameObject.transform.position.x,
        gameObject.transform.position.y - speed);

      // assign new pos vector to game obj
      gameObject.transform.position = pos;

    }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.tag == "Obstacle")
    {
      // Destroy(gameObject);
      // plays scream audio when bird dies
      gameObject.GetComponent<AudioSource>().Play();

      // bird dies; is sent back to initPosition to restart
      gameObject.transform.position = initPosition;
    }
  }
}

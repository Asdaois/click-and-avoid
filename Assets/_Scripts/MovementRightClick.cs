using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementRightClick : MonoBehaviour
{
  [SerializeField]
  float speed = 5f;
  public Vector2 targetPosition;
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    ChangeTargetPosition();
    MoveToTarget();

    void ChangeTargetPosition()
    {
      if (Input.GetMouseButtonDown(1))
      {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log($"Moving from {transform.position} to {targetPosition}");
      }
    }

    void MoveToTarget()
    {
      transform.position = Vector2.MoveTowards(
              transform.position,
              targetPosition,
              Time.deltaTime * speed);
    }
  }
}

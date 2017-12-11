using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Actor {

    int state = 1; // 1 = grazing
                   // 2 = fleeing

    private Vector3 target_pos;
    private Vector3 danger_location;
    private Rigidbody2D sheep_rb;

    protected override void Awake()
    {
        base.Awake();
        sheep_rb = GetComponent<Rigidbody2D>();
    }

    public override void click()
    {
        state = 2;
    }

    public override void move(Vector3 target_pos)
    {
        var move_delta = (transform.position - target_pos).normalized * Time.deltaTime * 2f;
        sheep_rb.MovePosition(transform.position + move_delta);

        Vector2 v = (transform.position - target_pos).normalized;
        var angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    // Update is called once per frame
    protected override void Update () {

        base.Update();

        if(state == 1)
        {
            if (Vector3.Distance(transform.position, target_pos) < 0.2f)
            {
                target_pos = new Vector3(Random.Range(-3f, 3f), Random.Range(-2f, -1f), 0f);
            }
            else
            {
                //transform.Translate((target_pos - transform.position).normalized * Time.deltaTime * 2f);
                transform.position += (target_pos - transform.position).normalized * Time.deltaTime * 2f;
                Vector2 v = (target_pos - transform.position).normalized;
                var angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }

		
	}
}

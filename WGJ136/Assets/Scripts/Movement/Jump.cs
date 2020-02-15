﻿using System;
using UnityEngine;

namespace WGJ136.Movement
{
    public class Jump 
    {
        private float jumpForce = 2f;
        private float fallMultiplier = 2.5f;
        private float lowJumpMultiplier = 2f;

        private Rigidbody2D rb;
        // Start is called before the first frame update

        public Jump(Rigidbody2D rb)
        {
            this.rb = rb;
        }
    
        // Update is called once per frame
        public void Update()
        {
            BetterJump();
        }
    
        public void StartJump()
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity += Vector2.up * jumpForce;
        }

        private void BetterJump()
        {
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * (fallMultiplier - 1) * Time.deltaTime;
            }
        }
    }
}
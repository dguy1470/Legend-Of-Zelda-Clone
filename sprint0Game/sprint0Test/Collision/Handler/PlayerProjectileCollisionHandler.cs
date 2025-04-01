using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using sprint0Test.Link1;
using sprint0Test;
using sprint0Test.Enemy;
using sprint0Test.Projectiles;

namespace sprint0Test
{
    public class PlayerProjectileCollisionHandler
    {
        public void HandleCollisionList(List<IProjectile> _active)
        {
            foreach (var block in _active)
            {
                HandleCollision(block);
            }
        }

        public void HandleCollision(IProjectile projectile)
        {
            if (CollisionDetectProjectile.isTouchingLeft(projectile))
            {
                Link.Instance.MoveLeft();
                Link.Instance.TakeDamage();
                projectile.Deactivate();
            }

            if (CollisionDetectProjectile.isTouchingRight(projectile))
            {
                Link.Instance.MoveRight();
                Link.Instance.TakeDamage();
                projectile.Deactivate();
            }

            if (CollisionDetectProjectile.isTouchingBottom(projectile))
            {
                Link.Instance.MoveDown();
                Link.Instance.TakeDamage();
                projectile.Deactivate();
            }

            if (CollisionDetectProjectile.isTouchingTop(projectile))
            {
                Link.Instance.MoveUp();
                Link.Instance.TakeDamage();
                projectile.Deactivate();
            }
        }

    }
}

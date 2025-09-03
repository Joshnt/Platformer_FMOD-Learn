using FMODUnity;
using Platformer.Core;
using Platformer.Mechanics;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the health component on an enemy has a hitpoint value of  0.
    /// </summary>
    /// <typeparam name="EnemyDeath"></typeparam>
    public class EnemyDeath : Simulation.Event<EnemyDeath>
    {
        public EnemyController enemy;

        public override void Execute()
        {
            enemy._collider.enabled = false;
            enemy.control.enabled = false;
            RuntimeManager.PlayOneShotAttached(enemy.ouchReference, enemy.gameObject);
            enemy.idleInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            enemy.idleInstance.release();
        }
    }
}
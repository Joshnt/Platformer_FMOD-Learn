using Platformer.Core;
using Platformer.Mechanics;
using FMODUnity;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player performs a Jump.
    /// </summary>
    /// <typeparam name="PlayerJumped"></typeparam>
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;

        public override void Execute()
        {
            RuntimeManager.PlayOneShot(player.jumpEvent);
        }
    }
}
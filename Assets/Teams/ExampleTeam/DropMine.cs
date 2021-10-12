using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DoNotModify;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityCharacterController
{
    public class DropMine : Action
    {

        public SharedGameObject _spaceShip;
        private SpaceShip spaceShip;

        public override void OnAwake()
        {
            spaceShip = _spaceShip.Value.gameObject.GetComponent<SpaceShip>();

            base.OnAwake();
        }

        public override TaskStatus OnUpdate()
        {
            spaceShip.DropMine();
            return base.OnUpdate();
        }

        public override void OnEnd()
        {
            base.OnEnd();
        }
    }

}



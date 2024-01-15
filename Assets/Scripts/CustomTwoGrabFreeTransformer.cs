/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 * All rights reserved.
 *
 * Licensed under the Oculus SDK License Agreement (the "License");
 * you may not use the Oculus SDK except in compliance with the License,
 * which is provided at the time of installation or download, or which
 * otherwise accompanies this software in either electronic or hard copy form.
 *
 * You may obtain a copy of the License at
 *
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Oculus SDK
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using UnityEngine;
using System;

namespace Oculus.Interaction
{
    /// <summary>
    /// A Transformer that transforms the target in a free form way for an intuitive
    /// two hand translation, rotation and scale.
    /// </summary>
    public class CustomTwoGrabFreeTransformer : MonoBehaviour, ITransformer
    {
        // The active rotation for this transformation is tracked because it
        // cannot be derived each frame from the grab point information alone.
        private Quaternion _activeRotation;
        private Vector3 _initialLocalScale;
        private float _initialDistance;
        private float _initialScale = 1.0f;
        private float _activeScale = 1.0f;

        private Pose _previousGrabPointA;
        private Pose _previousGrabPointB;

        //Anthony edit
        public Transform leftController;
        public Transform rightController;

        [HideInInspector]
        public float originControllerDistanceX;
        [HideInInspector]
        public float controllerDistanceX;
        [HideInInspector]
        public float controllerDifferenceFromOriginX;
        [HideInInspector]
        public float localScaleOriginX;

        [HideInInspector]
        public float currentPositionLeftX;
        [HideInInspector]
        public float currentPositionRightX;

        [HideInInspector]
        public float originControllerDistanceY;
        [HideInInspector]
        public float controllerDistanceY;
        [HideInInspector]
        public float controllerDifferenceFromOriginY;
        [HideInInspector]
        public float localScaleOriginY;

        [HideInInspector]
        public float currentPositionLeftY;
        [HideInInspector]
        public float currentPositionRightY;

        [HideInInspector]
        public bool firstTime = false;

        //end of Anthony edit

        [Serializable]
        public class TwoGrabFreeConstraints
        {
            [Tooltip("If true then the constraints are relative to the initial scale of the object " +
                     "if false, constraints are absolute with respect to the object's x-axis scale.")]
            public bool ConstraintsAreRelative;
            public FloatConstraint MinScale;
            public FloatConstraint MaxScale;
        }

        [SerializeField]
        private TwoGrabFreeConstraints _constraints;

        public TwoGrabFreeConstraints Constraints
        {
            get
            {
                return _constraints;
            }

            set
            {
                _constraints = value;
            }
        }

        private IGrabbable _grabbable;

        public void Initialize(IGrabbable grabbable)
        {
            _grabbable = grabbable;
        }

        public void BeginTransform()
        {
            //Anthony edit
            firstTime = true;
            //end of Anthony edit

            var grabA = _grabbable.GrabPoints[0];
            var grabB = _grabbable.GrabPoints[1];

            // Initialize our transformer rotation
            Vector3 diff = grabB.position - grabA.position;
            _activeRotation = Quaternion.LookRotation(diff, Vector3.up).normalized;
            _initialDistance = diff.magnitude;
            if (!_constraints.ConstraintsAreRelative)
            {
                _activeScale = _grabbable.Transform.localScale.x;
            }
            _initialScale = _activeScale;
            _initialLocalScale = _grabbable.Transform.localScale / _initialScale;

            _previousGrabPointA = new Pose(grabA.position, grabA.rotation);
            _previousGrabPointB = new Pose(grabB.position, grabB.rotation);
        }

        public void UpdateTransform()
        {
            //Anthony edit

            //get origin
            if (firstTime)
            {
                firstTime = false;

                //get local position origin of controllers
                //for X
                var originLeftX = leftController.transform.localPosition.x;
                var originRightX = rightController.transform.localPosition.x;

                var maxValueX = Mathf.Max(originLeftX, originRightX);
                var minValueX = Mathf.Min(originLeftX, originRightX);

                originControllerDistanceX = maxValueX - minValueX;
                localScaleOriginX = transform.localScale.x;

                //for Y
                var originLeftY = leftController.transform.localPosition.y;
                var originRightY = rightController.transform.localPosition.y;

                var maxValueY = Mathf.Max(originLeftY, originRightY);
                var minValueY = Mathf.Min(originLeftY, originRightY);

                originControllerDistanceY = maxValueY - minValueY;
                localScaleOriginY = transform.localScale.y;
            }

            //get updated local positions of controllers
            //for X
            currentPositionLeftX = leftController.transform.localPosition.x;
            currentPositionRightX = rightController.transform.localPosition.x;

            var xMax = Mathf.Max(currentPositionLeftX, currentPositionRightX);
            var xMin = Mathf.Min(currentPositionLeftX, currentPositionRightX);

            controllerDistanceX = xMax - xMin;
            controllerDifferenceFromOriginX = controllerDistanceX - originControllerDistanceX;
            controllerDifferenceFromOriginX *= 2; // a bit faster

            //for Y
            currentPositionLeftY = leftController.transform.localPosition.y;
            currentPositionRightY = rightController.transform.localPosition.y;

            var yMax = Mathf.Max(currentPositionLeftY, currentPositionRightY);
            var yMin = Mathf.Min(currentPositionLeftY, currentPositionRightY);

            controllerDistanceY = yMax - yMin;
            controllerDifferenceFromOriginY = controllerDistanceY - originControllerDistanceY;
            controllerDifferenceFromOriginY *= 2; // a bit faster for X axis


            //update the interactable transform
            transform.localScale = new Vector3(localScaleOriginX + controllerDifferenceFromOriginX, localScaleOriginY + controllerDifferenceFromOriginY, transform.localScale.z);
          
            //end of Anthony edit
        }

        public void MarkAsBaseScale()
        {
            _activeScale = 1.0f;
        }

        public void EndTransform() { }

        #region Inject

        public void InjectOptionalConstraints(TwoGrabFreeConstraints constraints)
        {
            _constraints = constraints;
        }

        #endregion
    }
}

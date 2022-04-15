using System.Collections;
using System.Collections.Generic;

namespace spatC
{
    public class PIDControl
    {
        public float kP;
        public float kI;
        public float kD;

        public float limitMax;
        public float limitMin;

        private float beforePoint = 0.0f;

        public PIDControl()
        {
            this.kP = 1.0f;
            this.kI = 0.0f;
            this.kD = 0.0f;
        }
        public PIDControl(float kP, float kI, float kD)
        {
            this.kP = kP;
            this.kI = kI;
            this.kD = kD;
        }
        public PIDControl(float kP, float kI, float kD, float limitMax, float limitMin)
        {
            this.kP = kP;
            this.kI = kI;
            this.kD = kD;
            this.limitMax = limitMax;
            this.limitMin = limitMin;
        }

        public float PID(float setPoint, float delta)
        {
            float output = 
                Proportional(setPoint) +
                Integral(setPoint) +
                Differential(setPoint, delta);

            output *= delta;

            return output;
        }
        public float PIDWithLimit(float setPoint, float delta)
        {
            float output = 
                Proportional(setPoint) +
                Integral(setPoint) +
                Differential(setPoint, delta);

            if(output > limitMax) output = limitMax;
            else if(output < limitMin) output = limitMin;

            output *= delta;

            return output;
        }

        private float Proportional(float setPoint)
        {
            float output = setPoint * kP;
            return output;
        }

        private float Integral(float setPoint)
        {
            float output = 0.0f;
            return output;
        }

        private float Differential (float setPoint, float delta)
        {
            float output = (setPoint - beforePoint) * kD / delta;
            beforePoint = setPoint;
            return output;
        }
    }
}
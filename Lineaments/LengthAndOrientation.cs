﻿using System;

namespace Lineaments
{
    //test

    public static class CalculateOrientation
    {
        public static double ReturnOrientation(LineObject lineament)
        {
            double dblDirection = 0.0;


            double dblDx = lineament.dblEndX - lineament.dblStartX;

            //get the inverse tangent
            double dblInverse = Math.Atan(dblOrient);

            //as Atan returns radians, convert to degress
            double dblDeg = dblInverse * (180 / Math.PI);


        }


        public static double ReturnLength(LineObject lineament)
        {
            double dblLength = 0.0;
            double dblMeasurement = 0.0;

            dblMeasurement = Math.Pow(lineament.dblStartX - lineament.dblEndX, 2) + Math.Pow(lineament.dblStartY - lineament.dblEndY, 2);

            dblLength = dblMeasurement * dblMeasurement;

            return dblLength;
        }

    }

    public class LineObject
    {
        public double dblStartX { get; set; }
        public double dblStartY { get; set; }
        public double dblEndX { get; set; }
        public double dblEndY { get; set; }

    }
}
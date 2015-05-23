//-----------------------------------------------------------------------
// <copyright file="Q161CS.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CSharpLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Q161 Traffic Lights in C#
    /// </summary>

    public static class Q161CS
    {
        public static TimeSpan GetAnswer(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentException("input is null");
            }

            if (!input.ToList().TrueForAll(x => 10 <= x && x <= 90))
            {
                throw new ArgumentException("Cycle times will not be less than 10 seconds, nor more than 90 seconds.");
            }

            if (!(2 <= input.Length && input.Length <= 100))
            {
                throw new ArgumentException("There will always be at least two signals in a scenario and never more than 100.");
            }

            List<TrafficLights> tls = new List<TrafficLights>();
            foreach (var item in input)
            {
                var tl = new TrafficLights(item);
                tls.Add(tl);
            }

            int sec = 0;

            // skip first all green
            while (tls.TrueForAll(x => x.Status == LightStatus.Green))
            {
                tls.ForEach(x => x.PassOneSceond());
                sec++;
            }

            // find next all green
            for (; sec < 18001; sec++)
            {
                tls.ForEach(x => x.PassOneSceond());
                if (tls.TrueForAll(x => x.Status == LightStatus.Green))
                {
                    return new TimeSpan(0, 0, sec);
                }
            }

            throw new TimeoutException("Signals fail to synchronise in 5 hours");
        }
    }

    /// <summary>
    /// A Traffic Lights
    /// </summary>
    internal class TrafficLights
    {
        /// <summary>
        /// Timer.
        /// </summary>
        private int innerClock;

        /// <summary>
        /// Green light trigger second.
        /// </summary>
        private int greenPeriod;

        /// <summary>
        /// Yellow light trigger second.
        /// </summary>
        private int yellowPeriod;

        /// <summary>
        /// Red light trigger second
        /// </summary>
        private int redPeriod;

        /// <summary>
        /// Gets or sets the Light Status.
        /// </summary>
        /// <value>The Light.</value>
        public LightStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TrafficLights"/> class.
        /// </summary>
        /// <param name="sec">period</param>
        public TrafficLights(int sec)
        {
            redPeriod = sec;

            // explicitly enable overflow-checking for integral-type arithmetic operations and conversions.
            checked
            {
                yellowPeriod = sec - 5;
                greenPeriod = sec * 2;
            }
            innerClock = 0;
            Status = LightStatus.Green;
        }

        /// <summary>
        /// Pass a second...
        /// </summary>
        public void PassOneSceond()
        {
            innerClock++;
            switch (Status)
            {
                case LightStatus.Green:
                    if (innerClock > yellowPeriod)
                    {
                        Status = LightStatus.Yellow;
                    }
                    break;

                case LightStatus.Yellow:
                    if (innerClock > redPeriod)
                    {
                        Status = LightStatus.Red;
                    }
                    break;

                case LightStatus.Red:
                    if (innerClock > greenPeriod)
                    {
                        Status = LightStatus.Green;
                        innerClock = innerClock - greenPeriod;
                    }
                    break;
            }
        }
    }

    /// <summary>
    /// Light status
    /// </summary>
    internal enum LightStatus
    {
        /// <summary>
        /// Green Light
        /// </summary>
        Green,

        /// <summary>
        /// Yellow Light
        /// </summary>
        Yellow,

        /// <summary>
        /// Red Light
        /// </summary>
        Red
    }
}
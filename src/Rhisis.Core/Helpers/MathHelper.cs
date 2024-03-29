﻿using System;

namespace Rhisis.Core.Helpers;

public static class MathHelper
{
    /// <summary>
    /// Converts a randian angle to degree.
    /// </summary>
    /// <param name="radians"></param>
    /// <returns></returns>
    public static float ToDegree(float radians) => (float)(radians * (180.0f / Math.PI));

    /// <summary>
    /// Converts a degree angle to radian.
    /// </summary>
    /// <param name="degree"></param>
    /// <returns></returns>
    public static float ToRadian(float degree) => (float)(degree * (Math.PI / 180.0f));

    /// <summary>
    /// Gives the percentage of a value.
    /// </summary>
    /// <param name="value">Reference value</param>
    /// <param name="percents">Percentage wanted</param>
    /// <returns></returns>
    public static int Percentage(int value, int percents) => (value * percents) / 100;
}

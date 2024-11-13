﻿using System.Runtime.Intrinsics;
using QuadTree.Abstractions;

namespace QuadTree.Tests
{
    public struct SimplePoint : IPoint
  {
    private Vector128<double> Point { get; init; }

    public double X => Point[0];

    public double Y => Point[1];

    public SimplePoint(Vector128<double> point) => Point = point;
    public static implicit operator Vector128<double>(SimplePoint point) => point.Point;
    public static implicit operator SimplePoint(Vector128<double> point) => new SimplePoint(point);
  }
}
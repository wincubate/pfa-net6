using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

IEnumerable<int> sequence = new List<int> { 2, -3, 7, 1, 4, -6, 9, -8 };

int result = sequence
    .Aggregate(
        new ComputationState(0, 0),
        ( state, i ) => state with
        {
            MaxEndingHere = Max(i, state.MaxEndingHere + i),
            MaxSoFar = Max(state.MaxSoFar, Max(i, state.MaxEndingHere + i))
        },
    x => x.MaxSoFar
);

Console.WriteLine( $"Maximum subsum is {result}");

record struct ComputationState(int MaxEndingHere, int MaxSoFar);
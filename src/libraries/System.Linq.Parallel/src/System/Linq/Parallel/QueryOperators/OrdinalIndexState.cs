// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// OrdinalIndexState.cs
//
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace System.Linq.Parallel
{
    /// <summary>
    /// Describes the state of order preservation index associated with an enumerator.
    /// </summary>
    internal enum OrdinalIndexState : byte
    {
        Indexable = 0,   // Indices of elements are 0,1,2,... An element with any index can be accessed in constant time.
        Correct = 1,     // Indices of elements are 0,1,2,... Within each partition, elements are in the correct order.
        Increasing = 2,  // Indices of elements are strictly increasing (i1 < i2 < i3...). Within each partition, elements are in the correct order.
        Shuffled = 3,    // Indices are of arbitrary type. Elements appear in an arbitrary order in each partition.
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Functions.Intefrations.Test
{
    [CollectionDefinition(nameof(TestCollection))]
    public class TestCollection : ICollectionFixture<TestFixture>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RestaurantTPTest
{
    public class TestServeur
    {
        [Fact]
        public void Test1()
        {
            var serveurTest = new ServeurBuilder()
                .Nomme("Test")
                .Build();

            Assert.Equal(0, serveurTest.ChiffreAffaires);
        }
        
    }
}

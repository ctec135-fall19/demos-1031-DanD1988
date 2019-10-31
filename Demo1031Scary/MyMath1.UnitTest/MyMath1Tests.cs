namespace MyMath1.UnitTest
{
    class MyMath1Tests
    {
        [Test]

        public void Add_SumWithInByteRange
        {
            Assert.AreEqual(200,MyMath.MyMath1.Add(101, 99));
        }

        [Test] 
        public void Add_sumOutsinByteRange_AlternateAssert()
    {
        Assert.AreEqual(200, MyMath.MyMath1.Add(101, 99));
    }
    }
}
}

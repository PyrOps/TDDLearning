namespace Ytreza.fizzbuzz {
  //
  // Step 1 : Test list
  // - Covering non fizzbuzz values
  //    FizzBuzz(0)
  //    FizzBuzz(1)
  //    FizzBuzz(2)
  // - Covering fizz values (multiples of 3)
  //    FizzBuzz(3)
  //    FizzBuzz(6)
  //    FizzBuzz(9)
  // - Covering buzz values (multiples of 5)
  //    FizzBuzz(5)
  //    FizzBuzz(10)
  //    FizzBuzz(20)
  // - Covering fizzbuzz values multiples of 15)
  //    FizzBuzz(15)
  //    FizzBuzz(30)
  //    FizzBuzz(45)
  //

  // Step 2 : Test writing
  // 1. FizzBuzz(0)

  public class FizzBuzzTest {
    [Fact]
    public void TestFizzBuzzZero() {
      Assert.Equal("0", FizzBuzz.Check(0));
    }
  }

  public class FizzBuzz {
    public static string Check(int value) {
      throw new NotImplementedException();
    }
  }
}
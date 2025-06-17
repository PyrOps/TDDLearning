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
  // 2. FizzBuzz(1)
  // 3. FizzBuzz(2)
  // 4. FizzBuzz(3)
  // 5. FizzBuzz(6)

  public class FizzBuzzTest {
    [Fact]
    public void TestFizzBuzzZero() {
      Assert.Equal("0", FizzBuzz.Check(0));
    }

    [Fact]
    public void TestFizzBuzzOne() {
      Assert.Equal("1", FizzBuzz.Check(1));
    }

    [Fact]
    public void TestFizzBuzzTwo() {
      Assert.Equal("2", FizzBuzz.Check(2));
    }

    [Fact]
    public void TestFizzBuzzThree() {
      Assert.Equal("fizz", FizzBuzz.Check(3));
    }

    [Fact]
    public void TestFizzBuzzSix() {
      Assert.Equal("fizz", FizzBuzz.Check(6));
    }

    [Fact]
    public void TestFizzBuzzNine() {
      Assert.Equal("fizz", FizzBuzz.Check(9));
    }
  }

  public class FizzBuzz {
    public static string Check(int value) {
      if (value == 3 || value == 6 || value == 9) return "fizz";
      return value.ToString();
    }
  }
}
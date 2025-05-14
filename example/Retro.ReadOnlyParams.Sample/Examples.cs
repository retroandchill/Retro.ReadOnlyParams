// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Retro.ReadOnlyParams.Sample;

// If you don't see warnings, build the Analyzers Project.

public class Examples {

  public void ToStars() {
    var spaceship = new Spaceship(299_792_458);
    spaceship.SetSpeed(300000000); // Invalid value, it should be highlighted.
    spaceship.SetSpeed(42);
  }
}
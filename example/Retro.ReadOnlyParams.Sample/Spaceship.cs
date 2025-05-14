using System;
using Retro.ReadOnlyParams.Annotations;

namespace Retro.ReadOnlyParams.Sample;

public class Spaceship([ReadOnly] long maxSpeed) {
  public void SetSpeed([ReadOnly] long speed) {
    if (speed > maxSpeed) {
      // Uncomment this line to trigger the analyzer
      //maxSpeed = speed;
      throw new ArgumentOutOfRangeException(nameof(speed));
    }

  }
}
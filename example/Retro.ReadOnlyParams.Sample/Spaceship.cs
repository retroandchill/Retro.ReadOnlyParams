using System;
using Retro.ReadOnlyParams.Annotations;

namespace Retro.ReadOnlyParams.Sample;

public class Spaceship {
  public void SetSpeed([ReadOnly] long speed) {
    speed = 4;
    if (speed > 299_792_458)
      throw new ArgumentOutOfRangeException(nameof(speed));
  }
}
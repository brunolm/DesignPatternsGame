using DesingPatternsGame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsGame.State
{
    public interface IMoveState
    {
        Animation Animation { get; }
    }
}

using DesignPatternsGame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.State
{
    public interface IMoveState
    {
        Animation Animation { get; }
    }
}

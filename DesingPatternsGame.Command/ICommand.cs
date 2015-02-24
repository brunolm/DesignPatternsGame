using DesingPatternsGame.Common;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System;

namespace DesingPatternsGame.Command
{
    public interface ICommand
    {
        GameSprite Execute(ContentManager content);
    }
}

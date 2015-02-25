using DesignPatternsGame.Common;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System;

namespace DesignPatternsGame.Command
{
    public interface ICommand
    {
        GameSprite Execute(ContentManager content);
    }
}

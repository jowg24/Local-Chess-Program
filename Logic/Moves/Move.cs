﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Move
    {
        public abstract MoveType Type { get; }
        public abstract Position FromPos { get; }
        public abstract Position ToPos { get; }

        public abstract bool Execute(Board board);

        public virtual bool IsLegal(Board board)
        {
            Player player = board[FromPos].Colour;
            Board boardCopy = board.Copy();
            Execute(boardCopy);
            return !boardCopy.IsInCheck(player);
        }
    }
}
